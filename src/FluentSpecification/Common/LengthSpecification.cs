using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Common.Abstractions;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if length of candidate is equal to specific value.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
    [PublicAPI]
    public sealed class LengthSpecification<T> :
        BaseLengthSpecification<T>,
        IFailableSpecification<T>,
        IFailableNegatableSpecification<T>,
        IParameterizedSpecification
        where T : IEnumerable
    {
        private readonly int _length;

        /// <summary>
        ///     Creates <c>Specification</c> for candidate (collection) length verification.
        /// </summary>
        /// <param name="length">Expected candidate length.</param>
        /// <param name="linqToEntities">Is linq to entities (without null check of collection in <c>Expression</c>).</param>
        [PublicAPI]
        public LengthSpecification(int length, bool linqToEntities = false) :
            base(linqToEntities)
        {
            _length = length;
        }

        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedMessage(T candidate)
        {
            return $"Object length is not [{_length}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedNegationMessage(T candidate)
        {
            return $"Object length is [{_length}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        public IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"Length", _length}
            };
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildValueTypeExpressionBody(Expression arg, Expression callExpression)
        {
            var compareExpression = Expression.Equal(
                callExpression, Expression.Constant(_length));
            return compareExpression;
        }
    }
}