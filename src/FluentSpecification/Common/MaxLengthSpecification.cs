using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Common.Abstractions;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if length of candidate is lower than or equal to Max value.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
    [PublicAPI]
    public sealed class MaxLengthSpecification<T> :
        BaseLengthSpecification<T>
        where T : IEnumerable
    {
        private readonly int _max;

        /// <summary>
        ///     Creates <c>Specification</c> for candidate (collection) length verification.
        /// </summary>
        /// <param name="maxLength">Maximum candidate length.</param>
        /// <param name="linqToEntities">Is linq to entities (without null check of collection in <c>Expression</c>).</param>
        [PublicAPI]
        public MaxLengthSpecification(int maxLength, bool linqToEntities = false) :
            base(linqToEntities)
        {
            _max = maxLength;
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(T candidate)
        {
            return $"Object length is greater than [{_max}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateNegationFailedMessage(T candidate)
        {
            return $"Object length is lower than [{_max}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"MaxLength", _max}
            };
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildValueTypeExpressionBody(Expression arg, Expression callExpression)
        {
            var compareExpression = Expression.LessThanOrEqual(
                callExpression, Expression.Constant(_max));
            return compareExpression;
        }
    }
}