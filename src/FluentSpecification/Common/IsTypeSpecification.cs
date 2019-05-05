using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Core;
using FluentSpecification.Core.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if candidate is compatible with a given type.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verification.</typeparam>
    [PublicAPI]
    public sealed class IsTypeSpecification<T> :
        ComplexSpecification<T>
    {
        private readonly Type _expected;

        /// <summary>
        ///     Basic constructor
        /// </summary>
        /// <param name="expected">Expected type of candidate.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="expected" /> is null.</exception>
        [PublicAPI]
        public IsTypeSpecification([NotNull] Type expected)
        {
            _expected = expected ?? throw new ArgumentNullException(nameof(expected));
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(T candidate)
        {
            return $"Object is not type of [{SpecificationResultGenerator.GetTypeShortName(_expected)}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateNegationFailedMessage(T candidate)
        {
            return $"Object is type of [{SpecificationResultGenerator.GetTypeShortName(_expected)}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"Expected", _expected}
            };
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            var expression = Expression.TypeIs(arg, _expected);
            return expression;
        }
    }
}