using System;
using System.Linq;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Composite
{
    /// <summary>
    ///     Logical NOT <c>Specification</c> implementation.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public sealed class NotSpecification<T> : IComplexSpecification<T>
    {
        struct NotSpecificationTrace
        {
            private readonly SpecificationTrace _trace;

            public NotSpecificationTrace(SpecificationTrace baseTrace)
            {
                _trace = new SpecificationTrace(
                    GenerateTrace(baseTrace.FullTrace),
                    GenerateTrace(baseTrace.ShortTrace));
            }

            private string GenerateTrace(string baseTrace)
            {
                if (!string.IsNullOrEmpty(baseTrace))
                    return $"Not({baseTrace})";

                return null;
            }

            [PublicAPI]
            public static implicit operator SpecificationTrace(NotSpecificationTrace self)
            {
                return self._trace;
            }
        }

        private readonly IComplexSpecification<T> _baseSpecification;
        private readonly Expression<Func<T, bool>> _expression;

        /// <summary>
        ///     Creates negation object of <paramref name="baseSpecification" />.
        /// </summary>
        /// <param name="baseSpecification">Base <c>Specification</c> to negate.</param>
        [PublicAPI]
        public NotSpecification(ISpecification<T> baseSpecification)
        {
            baseSpecification = baseSpecification ?? throw new ArgumentNullException(nameof(baseSpecification));

            _baseSpecification = baseSpecification.AsComplexSpecification();
            if (_baseSpecification is INegatableLinqSpecification<T> negatableSpecification)
                _expression = negatableSpecification.GetNegationExpression();
            else
                _expression = ExpressionComposer.Compose(_baseSpecification.GetExpression(), Expression.Not);
        }

        /// <summary>
        ///     Result negation of <c>Specification</c> passed in constructor.
        /// </summary>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <returns>
        ///     Overall result as negation of base <c>Specifications</c>.
        /// </returns>
        [PublicAPI]
        public bool IsSatisfiedBy(T candidate)
        {
            if (_baseSpecification is INegatableSpecification<T> negatableSpecification)
                return negatableSpecification.IsNotSatisfiedBy(candidate);
            return !_baseSpecification.IsSatisfiedBy(candidate);
        }

        /// <summary>
        ///     Result negation of <c>Specifications</c> passed in constructor.
        /// </summary>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <param name="result">
        ///     Contains validation summary of <c>Specification</c> negation -
        ///     errors, types of all executed <c>Specifications</c>
        ///     and trace message in the style of Boole algebra.
        /// </param>
        /// <returns>
        ///     Overall result as negation of base <c>Specification</c>.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when cannot generate negation result.</exception>
        [PublicAPI]
        public bool IsSatisfiedBy(T candidate, out SpecificationResult result)
        {
            if (_baseSpecification is INegatableValidationSpecification<T> negatableSpecification)
                return negatableSpecification.IsNotSatisfiedBy(candidate, out result);

            var specResult = !_baseSpecification.IsSatisfiedBy(candidate, out var baseSpecResult);

            result = new SpecificationResult(specResult, new NotSpecificationTrace(baseSpecResult.Trace), 
                baseSpecResult.Specifications.ToArray());

            return specResult;
        }

        /// <summary>
        ///     Gets typed lambda <c>Linq</c> Expression with candidate object verification.
        ///     Expression is negation of <c>Linq</c> Expression, from <c>Specification</c> passed in constructor.
        /// </summary>
        /// <returns>Strongly typed, composed lambda <c>Linq</c> Expression.</returns>
        [PublicAPI]
        public Expression<Func<T, bool>> GetExpression()
        {
            return _expression;
        }

        /// <inheritdoc />
        [PublicAPI]
        Expression ILinqSpecification.GetExpression()
        {
            return GetExpression();
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression{Func}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static implicit operator Expression<Func<T, bool>>([CanBeNull] NotSpecification<T> self)
        {
            return self?.GetExpression();
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Func{T, Boolean}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static implicit operator Func<T, bool>([CanBeNull] NotSpecification<T> self)
        {
            return self != null ? self.IsSatisfiedBy : (Func<T, bool>)null;
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static explicit operator Expression([CanBeNull] NotSpecification<T> self)
        {
            return ((ILinqSpecification) self)?.GetExpression();
        }
    }
}