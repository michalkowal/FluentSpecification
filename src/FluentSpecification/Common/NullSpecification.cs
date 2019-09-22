using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if candidate is null.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public sealed class NullSpecification<T> :
        ComplexSpecification<T>,
        IFailableSpecification<T>,
        IFailableNegatableSpecification<T>
    {
        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedMessage(T candidate)
        {
            return "Object is not null";
        }

        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedNegationMessage(T candidate)
        {
            return "Object is null";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildValueTypeExpressionBody(Expression arg)
        {
            return Expression.Constant(false);
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            var expression = Expression.Equal(arg, Expression.Constant(null, typeof(T)));
            return expression;
        }
    }
}