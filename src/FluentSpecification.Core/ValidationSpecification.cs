using System;
using System.Collections.Generic;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Core
{
    /// <summary>
    ///     Base implementation of <see cref="IValidationSpecification{T}" />.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public abstract class ValidationSpecification<T> :
        IValidationSpecification<T>
    {
        /// <inheritdoc />
        public abstract bool IsSatisfiedBy(T candidate);

        /// <inheritdoc />
        public bool IsSatisfiedBy(T candidate, out SpecificationResult result)
        {
            var isSatisfiedBy = IsSatisfiedBy(candidate);

            result = CreateResult(candidate, isSatisfiedBy);

            return isSatisfiedBy;
        }

        /// <summary>
        ///     Creates <see cref="SpecificationResult" /> validation object with:
        /// </summary>
        /// <remarks>
        ///     Result contains:
        ///     <list type="bullet">
        ///         <item>
        ///             <term>trace message</term>
        ///         </item>
        ///         <item>
        ///             <term>
        ///                 <c>FailedSpecification</c>
        ///             </term>
        ///         </item>
        ///         <item>
        ///             <term>error message</term>
        ///         </item>
        ///         <item>
        ///             <term>parameters</term>
        ///         </item>
        ///     </list>
        /// </remarks>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <param name="isSatisfiedBy">Overall result is <c>Specification</c> satisfied by candidate.</param>
        /// <returns>Validation object based on overall result and candidate content.</returns>
        [PublicAPI]
        [NotNull]
        protected virtual SpecificationResult CreateResult([CanBeNull] T candidate, bool isSatisfiedBy)
        {
            var traceMessage = CreateTraceMessage(candidate, isSatisfiedBy);

            SpecificationResult result;
            if (isSatisfiedBy)
                result = new SpecificationResult(true, traceMessage);
            else
                result = new SpecificationResult(false, traceMessage,
                    new FailedSpecification(GetType(), GetParameters(), candidate, CreateFailedMessage(candidate)));

            return result;
        }

        /// <summary>
        ///     Gets validation failed message of <c>Specification</c> for <paramref name="candidate" /> content.
        /// </summary>
        /// <remarks>
        ///     Invoked only when overall result is <c>False</c>.
        /// </remarks>
        /// <param name="candidate">Incorrect candidate object.</param>
        /// <returns>Validation failed message.</returns>
        [PublicAPI]
        [NotNull]
        protected abstract string CreateFailedMessage([CanBeNull] T candidate);

        /// <summary>
        ///     Get <c>Specification</c> internal/external parameters, used for candidate verification.
        /// </summary>
        /// <remarks>
        ///     Returns null by default.
        /// </remarks>
        /// <returns>Dictionary with named parameters.</returns>
        [PublicAPI]
        [CanBeNull]
        protected virtual IReadOnlyDictionary<string, object> GetParameters()
        {
            return null;
        }

        /// <summary>
        ///     Creates trace message based on overall result and candidate content.
        /// </summary>
        /// <remarks>
        ///     Returns short name of <c>Specification</c> (without namespaces) by default.
        ///     Failed result contains <c>+Failed</c> suffix.
        /// </remarks>
        /// <param name="candidate">Verified candidate object.</param>
        /// <param name="result">Overall <c>Specification</c> result.</param>
        /// <returns>Short trace message.</returns>
        [PublicAPI]
        [NotNull]
        protected virtual string CreateTraceMessage([CanBeNull] T candidate, bool result)
        {
            var message = SpecificationResultGenerator.GetSpecificationShortName(this);
            if (!result)
                message += "+Failed";

            return message;
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Func{T,TResult}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static implicit operator Func<T, bool>([NotNull] ValidationSpecification<T> self)
        {
            return self.IsSatisfiedBy;
        }
    }
}