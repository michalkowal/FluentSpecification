using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using JetBrains.Annotations;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace FluentSpecification.Core
{
    /// <summary>
    ///     Internal adapter, extends <c>ValidationSpecification</c> object by custom error message.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class TranslatableSpecification<T> : IComplexSpecification<T>
    {
        private readonly IComplexSpecification<T> _baseSpecification;
        private readonly string _message;

        /// <summary>
        ///     Creates adapter.
        /// </summary>
        /// <param name="baseSpecification">Base adapted <c>Specification</c>.</param>
        /// <param name="message">Custom error message.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="baseSpecification" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="message" /> is null or empty.</exception>
        public TranslatableSpecification([NotNull] ISpecification<T> baseSpecification, [NotNull] string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException(nameof(message));

            _baseSpecification = baseSpecification?.AsComplexSpecification() ?? throw new ArgumentNullException(nameof(baseSpecification));
            _message = message;
        }

        /// <inheritdoc />
        public Expression<Func<T, bool>> GetExpression()
        {
            return _baseSpecification.GetExpression();
        }

        /// <inheritdoc />
        public bool IsSatisfiedBy(T candidate, out SpecificationResult result)
        {
            var overall = _baseSpecification.IsSatisfiedBy(candidate, out var baseResult);

            result = overall ?
                baseResult :
                new SpecificationResult(baseResult.TotalSpecificationsCount, baseResult.OverallResult,
                    new string[] { _message }, baseResult.Trace, baseResult.FailedSpecifications.ToArray());

            return overall;
        }

        /// <inheritdoc />
        public bool IsSatisfiedBy(T candidate)
        {
            return _baseSpecification.IsSatisfiedBy(candidate);
        }

        /// <inheritdoc />
        Expression ILinqSpecification.GetExpression()
        {
            return GetExpression();
        }
    }
}
