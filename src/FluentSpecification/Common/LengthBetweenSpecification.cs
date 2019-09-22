using System;
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
    ///     Checks if length of candidate is between Min and Max values.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
    [PublicAPI]
    public sealed class LengthBetweenSpecification<T> :
        BaseLengthSpecification<T>,
        IFailableSpecification<T>,
        IFailableNegatableSpecification<T>,
        IParameterizedSpecification
        where T : IEnumerable
    {
        private readonly int _max;
        private readonly int _min;

        /// <summary>
        ///     Creates <c>Specification</c> for candidate (collection) length verification.
        /// </summary>
        /// <param name="minLength">Minimum candidate length.</param>
        /// <param name="maxLength">Maximum candidate length.</param>
        /// <param name="linqToEntities">Is linq to entities (without null check of collection in <c>Expression</c>).</param>
        /// <exception cref="ArgumentException">
        ///     Thrown when <paramref name="maxLength" /> is lower than
        ///     <paramref name="minLength" />.
        /// </exception>
        [PublicAPI]
        public LengthBetweenSpecification(int minLength, int maxLength, bool linqToEntities = false) :
            base(linqToEntities)
        {
            if (maxLength < minLength)
                throw new ArgumentException("Max length is lower than min", nameof(maxLength));

            _min = minLength;
            _max = maxLength;
        }

        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedMessage(T candidate)
        {
            return $"Object length is not between [{_min}] and [{_max}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedNegationMessage(T candidate)
        {
            return $"Object length is between [{_min}] and [{_max}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        public IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"MinLength", _min},
                {"MaxLength", _max}
            };
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildValueTypeExpressionBody(Expression arg, Expression callExpression)
        {
            var compareMinExpression = Expression.GreaterThanOrEqual(
                callExpression, Expression.Constant(_min));
            var compareMaxExpression = Expression.LessThanOrEqual(
                callExpression, Expression.Constant(_max));

            return Expression.AndAlso(compareMinExpression, compareMaxExpression);
        }
    }
}