using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core;
using FluentSpecification.Core.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Common.Abstractions
{
    /// <summary>
    ///     Base implementation of <c>Specification</c> executed for collection elements
    /// </summary>
    /// <typeparam name="T">Collection type to iterate (<see cref="IEnumerable{T}" />).</typeparam>
    /// <typeparam name="TType">Type of collection element to verify.</typeparam>
    /// <example>
    ///     See <see cref="AllSpecification{T,TType}" /> and <see cref="AnySpecification{T,TType}" />.
    /// </example>
    [PublicAPI]
    public abstract class BaseCollectionSpecification<T, TType> :
        IComplexSpecification<T>
        where T : IEnumerable<TType>
    {
        private readonly bool _hasCheckNullExpression;

        /// <summary>
        ///     Creates <c>Specification</c> for candidate (collection) elements.
        /// </summary>
        /// <param name="collectionElementSpecification">Specification for candidate one element.</param>
        /// <param name="linqToEntities">Is linq to entities (without null check of collection in <c>Expression</c>).</param>
        [PublicAPI]
        protected BaseCollectionSpecification([NotNull] ISpecification<TType> collectionElementSpecification,
            bool linqToEntities)
        {
            collectionElementSpecification = collectionElementSpecification ??
                                             throw new ArgumentNullException(nameof(collectionElementSpecification));

            CollectionElementSpecification = collectionElementSpecification.AsComplexSpecification();
            _hasCheckNullExpression = !linqToEntities;
        }

        /// <summary>
        ///     <c>Specification</c> executed for collection element.
        /// </summary>
        [PublicAPI]
        [NotNull]
        protected IComplexSpecification<TType> CollectionElementSpecification { get; }

        /// <summary>
        ///     Method to call on candidate (collection) with <see cref="CollectionElementSpecification" />.
        /// </summary>
        [PublicAPI]
        [NotNull]
        protected abstract MethodInfo CollectionElementCallMethodInfo { get; }

        /// <summary>
        ///     Overall result for empty candidate (collection).
        /// </summary>
        [PublicAPI]
        protected abstract bool OverallForEmpty { get; }

        /// <summary>
        ///     String connector for elements trace.
        /// </summary>
        [PublicAPI]
        [CanBeNull]
        protected abstract string TraceConnector { get; }

        /// <inheritdoc />
        [PublicAPI]
        public abstract bool IsSatisfiedBy(T candidate);

        /// <summary>
        ///     Checks if <c>Specification</c> is satisfied by <paramref name="candidate" /> elements.
        ///     Elements are verified by <typeparamref name="TType" /> <c>Specification</c>.
        ///     Returns validation <paramref name="result" /> no matter is satisfied or not.
        /// </summary>
        /// <param name="candidate">Candidate with <typeparamref name="TType" /> elements to verification.</param>
        /// <param name="result">
        ///     Contains validation summary - errors, types of all executed <c>Specifications</c>
        ///     and trace message in the style of Boole algebra.
        /// </param>
        /// <returns>
        ///     <para>true - <c>Specification</c> is satisfied by <paramref name="candidate" />.</para>
        ///     <para>
        ///         false - is not satisfied or <paramref name="candidate" /> is null.
        ///     </para>
        /// </returns>
        [PublicAPI]
        public bool IsSatisfiedBy(T candidate, out SpecificationResult result)
        {
            if (candidate == null)
            {
                result = new SpecificationResult(false,
                    CreateTraceMessage("", false),
                    new SpecificationInfo(GetType(), GetParameters(), candidate, "Collection is null"));
                return false;
            }

            var overall = OverallForEmpty;
            var failedSpecifications = new List<SpecificationInfo>();
            var traces = new List<string>();

            var idx = 0;
            var total = 1;
            foreach (var el in candidate)
            {
                var specOverall = CollectionElementSpecification.IsSatisfiedBy(el, out var specResult);

                total += specResult.TotalSpecificationsCount;
                if (!string.IsNullOrEmpty(specResult.Trace))
                    traces.Add($"[{idx}]({specResult.Trace})");

                if (!CanContinue(specOverall, ref overall))
                    break;

                if (!specOverall)
                {
                    var failures = CreateFailedSpecifications(specResult.FailedSpecifications, idx);
                    failedSpecifications.AddRange(failures);
                }

                idx++;
            }

            if (!overall)
                failedSpecifications.Insert(0, new SpecificationInfo(
                    GetType(),
                    GetParameters(),
                    candidate,
                    CreateFailedMessage()));
            else
                failedSpecifications.Clear();

            var trace = CreateTraceMessage(string.Join($" {TraceConnector} ", traces), overall);
            result = new SpecificationResult(total, overall, trace, failedSpecifications.ToArray());

            return overall;
        }

        /// <summary>
        ///     Combines <c>Expression</c> from <typeparamref name="TType" /> <c>Specification</c> for
        ///     all candidate elements.
        /// </summary>
        /// <returns>Combined lambda <c>Linq</c> Expression for candidate as collection.</returns>
        [PublicAPI]
        public Expression<Func<T, bool>> GetExpression()
        {
            var collectionExpression = CollectionElementSpecification.GetExpression();
            var arg = Expression.Parameter(typeof(T), "candidate");

            var checkNullExpression = Expression.NotEqual(arg, Expression.Constant(null, typeof(T)));
            var invokeAnyExpression = Expression.Call(
                CollectionElementCallMethodInfo, arg, collectionExpression);

            var andExpression = Expression.AndAlso(
                checkNullExpression, invokeAnyExpression);

            return Expression.Lambda<Func<T, bool>>(
                !typeof(T).GetTypeInfo().IsValueType && _hasCheckNullExpression
                    ? (Expression) andExpression
                    : invokeAnyExpression,
                arg);
        }

        /// <inheritdoc />
        [PublicAPI]
        Expression ILinqSpecification.GetExpression()
        {
            return GetExpression();
        }

        /// <summary>
        ///     Gets validation failed message of whole <c>Specification</c>.
        /// </summary>
        /// <remarks>
        ///     Invoked only when overall result is <c>False</c>.
        /// </remarks>
        /// <returns>Validation failed message.</returns>
        [PublicAPI]
        [NotNull]
        protected abstract string CreateFailedMessage();

        /// <summary>
        ///     Get <c>Specification</c> internal/external parameters, used for candidate verification.
        /// </summary>
        /// <returns>Dictionary with named parameters.</returns>
        [PublicAPI]
        [CanBeNull]
        protected abstract IReadOnlyDictionary<string, object> GetParameters();

        /// <summary>
        ///     Checks if flow can be continued after each element result.
        /// </summary>
        /// <param name="elementOverall">Overall result of current element.</param>
        /// <param name="overall">Overall result for all elements, at this moment.</param>
        /// <returns>
        ///     <para>true - loop can be continue.</para>
        ///     <para>false - break loop.</para>
        /// </returns>
        [PublicAPI]
        protected abstract bool CanContinue(bool elementOverall, ref bool overall);

        /// <summary>
        ///     Creates trace message based on overall result and candidate content.
        /// </summary>
        /// <remarks>
        ///     Returns short name of <c>Specification</c> (without namespaces) by default.
        ///     Failed result contains <c>+Failed</c> suffix.
        /// </remarks>
        /// <param name="specificationTrace">
        ///     Merged trace of <typeparamref name="TType" /> <c>Specification</c> for candidate
        ///     elements.
        /// </param>
        /// <param name="result">Overall <c>Specification</c> result.</param>
        /// <returns>Short trace message.</returns>
        [PublicAPI]
        [NotNull]
        protected string CreateTraceMessage([CanBeNull] string specificationTrace, bool result)
        {
            var message = $"{SpecificationResultGenerator.GetSpecificationShortName(this)}({specificationTrace})";
            if (!result)
                message += "+Failed";

            return message;
        }

        /// <summary>
        ///     Changes error in each element od candidate.
        /// </summary>
        /// <remarks>
        ///     Method adds prefix with index "[<paramref name="idx" />] " to each error message.
        /// </remarks>
        /// <param name="failedSpecifications">Candidate element <see cref="SpecificationInfo" /> collection.</param>
        /// <param name="idx">Current element index.</param>
        /// <returns>New <see cref="SpecificationInfo" /> collection with correct error messages.</returns>
        [PublicAPI]
        [NotNull]
        [ItemNotNull]
        protected IEnumerable<SpecificationInfo> CreateFailedSpecifications(
            IReadOnlyCollection<SpecificationInfo> failedSpecifications, int idx)
        {
            foreach (var spec in failedSpecifications)
                yield return new SpecificationInfo(
                    spec.SpecificationType,
                    spec.Parameters,
                    spec.Candidate,
                    spec.Errors.Select(e => $"[{idx}] {e}").ToArray());
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression{Func}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static implicit operator Expression<Func<T, bool>>([NotNull] BaseCollectionSpecification<T, TType> self)
        {
            return self.GetExpression();
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Func{T, Boolean}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static implicit operator Func<T, bool>([NotNull] BaseCollectionSpecification<T, TType> self)
        {
            return self.IsSatisfiedBy;
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static explicit operator Expression([NotNull] BaseCollectionSpecification<T, TType> self)
        {
            return ((ILinqSpecification) self).GetExpression();
        }
    }
}