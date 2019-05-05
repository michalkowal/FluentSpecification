using System.Collections.Generic;
using System.Linq.Expressions;
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
        ComplexSpecification<T>
    {
        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(T candidate)
        {
            return "Object is not null";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateNegationFailedMessage(T candidate)
        {
            return "Object is null";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return null;
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