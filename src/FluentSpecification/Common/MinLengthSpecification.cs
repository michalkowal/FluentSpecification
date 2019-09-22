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
    ///     Checks if length of candidate is greater than or equal to Min value.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
    [PublicAPI]
    public sealed class MinLengthSpecification<T> :
        BaseLengthSpecification<T>,
        IFailableSpecification<T>,
        IFailableNegatableSpecification<T>,
        IParameterizedSpecification
        where T : IEnumerable
    {
        private readonly int _min;

        /// <summary>
        ///     Creates <c>Specification</c> for candidate (collection) length verification.
        /// </summary>
        /// <param name="minLength">Minimum candidate length.</param>
        /// <param name="linqToEntities">Is linq to entities (without null check of collection in <c>Expression</c>).</param>
        [PublicAPI]
        public MinLengthSpecification(int minLength, bool linqToEntities = false) :
            base(linqToEntities)
        {
            _min = minLength;
        }

        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedMessage(T candidate)
        {
            return $"Object length is lower than [{_min}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedNegationMessage(T candidate)
        {
            return $"Object length is greater than [{_min}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        public IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"MinLength", _min}
            };
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildValueTypeExpressionBody(Expression arg, Expression callExpression)
        {
            var compareExpression = Expression.GreaterThanOrEqual(
                callExpression, Expression.Constant(_min));
            return compareExpression;
        }
    }
}