using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Validation;
using JetBrains.Annotations;
using System;

namespace FluentSpecification.Core
{
    /// <summary>
    ///     Internal adapter, extends <c>ValidationSpecification</c> object by custom error message.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class TranslatableSpecification<T> : ValidationSpecification<T>
    {
        private readonly ISpecification<T> _baseSpecification;
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

            _baseSpecification = baseSpecification ?? throw new ArgumentNullException(nameof(baseSpecification));
            _message = message;
        }

        /// <inheritdoc />
        public override bool IsSatisfiedBy(T candidate)
        {
            return _baseSpecification.IsSatisfiedBy(candidate);
        }

        /// <inheritdoc />
        protected override string CreateFailedMessage(T candidate)
        {
            return _message;
        }

        /// <inheritdoc />
        protected override SpecificationResult CreateResult(T candidate, bool isSatisfiedBy)
        {
            var traceMessage = CreateTraceMessage(candidate, isSatisfiedBy);

            SpecificationResult result;
            if (isSatisfiedBy)
                result = new SpecificationResult(true, traceMessage);
            else
                result = new SpecificationResult(false, traceMessage,
                    new FailedSpecification(_baseSpecification.GetType(), GetParameters(), candidate, CreateFailedMessage(candidate)));

            return result;
        }

        /// <inheritdoc />
        protected override string CreateTraceMessage(T candidate, bool result)
        {
            var message = SpecificationResultGenerator.GetSpecificationShortName(_baseSpecification);
            if (!result)
                message += "+Failed";

            return message;
        }
    }
}
