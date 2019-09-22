using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using JetBrains.Annotations;

namespace FluentSpecification.Common.Abstractions
{
    /// <summary>
    ///     Base implementation for all <c>Specifications</c> with candidate less than value comparison.
    /// </summary>
    /// <typeparam name="T">Type of compared objects.</typeparam>
    [PublicAPI]
    public abstract class BaseLessCompareSpecification<T> :
        BaseCompareSpecification<T>,
        IParameterizedSpecification
    {
        /// <summary>
        ///     Creates <c>Specification</c> for candidate value comparison.
        /// </summary>
        /// <param name="lessThan">Candidate should be less than value.</param>
        /// <param name="compareExpression"><c>Linq</c> <c>Expression</c> for values comparison.</param>
        /// <param name="comparer">Comparer.</param>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        protected BaseLessCompareSpecification([CanBeNull] T lessThan,
            [NotNull] Func<Expression, Expression, Expression> compareExpression,
            [CanBeNull] IComparer<T> comparer = null) :
            base(lessThan, compareExpression, comparer)
        {
        }

        /// <inheritdoc />
        [PublicAPI]
        public IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"LessThan", Limit}
            };
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBodyWithLimit(Expression arg)
        {
            var nullExpression = Expression.Equal(arg, Expression.Constant(null, typeof(T)));
            var expression = Expression.OrElse(nullExpression,
                BuildValueTypeExpressionBody(
                    !IsNullable ? arg : Expression.Property(arg, "Value")));

            return expression;
        }
    }
}