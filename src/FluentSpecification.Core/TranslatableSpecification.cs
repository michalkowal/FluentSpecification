using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FluentSpecification.Core
{
    /// <summary>
    ///     Internal adapter, extends <c>ValidationSpecification</c> object by custom error message.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal sealed class TranslatableSpecification<T> : IComplexSpecification<T>
    {
        private readonly IComplexSpecification<T> _baseSpecification;
        private readonly Func<T, IReadOnlyDictionary<string, object>, string> _messageFactory;

        /// <summary>
        ///     Creates decorator.
        /// </summary>
        /// <param name="baseSpecification">Base adapted <c>Specification</c>.</param>
        /// <param name="message">Custom error message.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="baseSpecification" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="message" /> is null or empty.</exception>
        public TranslatableSpecification([NotNull] ISpecification<T> baseSpecification, [NotNull] string message)
            : this(baseSpecification, (c, p) => message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException(nameof(message));
        }

        /// <summary>
        ///     Creates decorator.
        /// </summary>
        /// <param name="baseSpecification">Base adapted <c>Specification</c>.</param>
        /// <param name="messageFactory">Custom message factory based on candidate value.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="baseSpecification" /> is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="messageFactory" /> is null.</exception>
        public TranslatableSpecification([NotNull] ISpecification<T> baseSpecification, [NotNull] Func<T, string> messageFactory)
            : this(baseSpecification, (c, p) => messageFactory(c))
        {
            if (messageFactory == null)
                throw new ArgumentNullException(nameof(messageFactory));
        }

        /// <summary>
        ///     Creates decorator.
        /// </summary>
        /// <param name="baseSpecification">Base adapted <c>Specification</c>.</param>
        /// <param name="messageFactory">Custom message factory based on candidate value and parameters dictionary.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="baseSpecification" /> is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="messageFactory" /> is null.</exception>
        public TranslatableSpecification([NotNull] ISpecification<T> baseSpecification,
            [NotNull] Func<T, IReadOnlyDictionary<string, object>, string> messageFactory)
        {
            if (baseSpecification == null)
                throw new ArgumentNullException(nameof(baseSpecification));
            if (messageFactory == null)
                throw new ArgumentNullException(nameof(messageFactory));

            _baseSpecification = baseSpecification.AsComplexSpecification();
            _messageFactory = messageFactory;
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

            if (overall)
            {
                result = baseResult;
            }
            else
            {
                var message = CreateMessage(candidate, baseResult);
                result = !string.IsNullOrEmpty(message) ?
                    new SpecificationResult(baseResult.TotalSpecificationsCount, baseResult.OverallResult,
                        new[] { message }, baseResult.Trace, baseResult.FailedSpecifications.ToArray()) :
                    baseResult;
            }
            
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

        private string CreateMessage(T candidate, SpecificationResult baseResult)
        {
            try
            {
                var parameters = baseResult.MergeSpecificationParameters();
                return _messageFactory(candidate, parameters);
            }
            catch
            {
                return null;
            }
        }
    }
}
