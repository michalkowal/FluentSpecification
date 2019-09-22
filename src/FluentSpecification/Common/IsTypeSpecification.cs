using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if candidate is compatible with a given type.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verification.</typeparam>
    [PublicAPI]
    public sealed class IsTypeSpecification<T> :
        ComplexSpecification<T>,
        IFailableSpecification<T>,
        IFailableNegatableSpecification<T>,
        IParameterizedSpecification
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
        public string GetFailedMessage(T candidate)
        {
            return $"Object is not type of [{_expected.GetShortName()}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedNegationMessage(T candidate)
        {
            return $"Object is type of [{_expected.GetShortName()}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        public IReadOnlyDictionary<string, object> GetParameters()
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