using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;

namespace FluentSpecification.Common.Abstractions
{
    /// <summary>
    ///     Base implementation for all <c>Specifications</c> with three value comparison.
    /// </summary>
    /// <typeparam name="T">Type of compared objects.</typeparam>
    [PublicAPI]
    public abstract class BaseBetweenSpecification<T> :
        ComplexSpecification<T>,
        IParameterizedSpecification
    {
        private readonly IComplexSpecification<T> _greaterThanSpecification;
        private readonly IComplexSpecification<T> _lessThanSpecification;

        /// <summary>
        ///     Creates <c>Specification</c> for candidate value comparison.
        /// </summary>
        /// <param name="from">Min candidate value.</param>
        /// <param name="to">Max candidate value.</param>
        /// <param name="inclusive">Values can be equal.</param>
        /// <param name="comparer">Comparer.</param>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="from" /> is greater than <paramref name="to" />.</exception>
        [PublicAPI]
        protected BaseBetweenSpecification(T from, T to, bool inclusive, IComparer<T> comparer)
        {
            From = from;
            To = to;

            if (inclusive)
            {
                _lessThanSpecification = new LessThanOrEqualSpecification<T>(to, comparer);
                _greaterThanSpecification = new GreaterThanOrEqualSpecification<T>(from, comparer);
            }
            else
            {
                _lessThanSpecification = new LessThanSpecification<T>(to, comparer);
                _greaterThanSpecification = new GreaterThanSpecification<T>(from, comparer);
            }

            var fromGreaterThanSpec = new GreaterThanOrEqualSpecification<T>(from, comparer);
            if (fromGreaterThanSpec.IsNotSatisfiedBy(to))
                throw new ArgumentException("To must be greater than From", nameof(to));
        }

        /// <summary>
        ///     From value.
        /// </summary>
        [PublicAPI]
        [CanBeNull]
        protected T From { get; }

        /// <summary>
        ///     To value.
        /// </summary>
        [PublicAPI]
        [CanBeNull]
        protected T To { get; }

        /// <inheritdoc />
        [PublicAPI]
        public IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"From", From},
                {"To", To}
            };
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            var fromExpression = _greaterThanSpecification.GetExpression();
            var toExpression = _lessThanSpecification.GetExpression();

            var fromExpressionBody = ExpressionParameterRebinder.ReplaceParameters(
                new Dictionary<ParameterExpression, Expression>
                {
                    {fromExpression.Parameters.First(), arg}
                },
                fromExpression.Body);
            var toExpressionBody = ExpressionParameterRebinder.ReplaceParameters(
                new Dictionary<ParameterExpression, Expression>
                {
                    {toExpression.Parameters.First(), arg}
                },
                toExpression.Body);

            var expression = Expression.AndAlso(fromExpressionBody, toExpressionBody);
            return expression;
        }
    }
}