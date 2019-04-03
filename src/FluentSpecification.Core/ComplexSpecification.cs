using System;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using JetBrains.Annotations;

namespace FluentSpecification.Core
{
    /// <summary>
    ///     Base implementation of <see cref="IComplexSpecification{T}" /> and <see cref="INegatableLinqSpecification{T}" />.
    ///     Inherited functionality from <see cref="ValidationSpecification{T}" /> and
    ///     <see cref="NegatableValidationSpecification{T}" />.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public abstract class ComplexSpecification<T> :
        NegatableValidationSpecification<T>,
        IComplexSpecification<T>,
        INegatableLinqSpecification<T>
    {
        private readonly bool _isNullable = Nullable.GetUnderlyingType(typeof(T)) != null;


        /// <inheritdoc />
        [PublicAPI]
        public override bool IsSatisfiedBy(T candidate)
        {
            return GetExpression().Compile().Invoke(candidate);
        }

        /// <inheritdoc />
        [PublicAPI]
        public Expression<Func<T, bool>> GetExpression()
        {
            var arg = Expression.Parameter(typeof(T), "candidate");

            var expression = typeof(T).IsValueType && !_isNullable
                ? BuildValueTypeExpressionBody(arg)
                : BuildExpressionBody(arg);

            return Expression.Lambda<Func<T, bool>>(expression, arg);
        }

        /// <inheritdoc />
        [PublicAPI]
        Expression ILinqSpecification.GetExpression()
        {
            return GetExpression();
        }

        /// <inheritdoc />
        [PublicAPI]
        public Expression<Func<T, bool>> GetNegationExpression()
        {
            var expression = GetExpression();
            var negation = Expression.Not(expression.Body);

            return Expression.Lambda<Func<T, bool>>(negation, expression.Parameters);
        }

        /// <summary>
        ///     Creates special <c>Expression</c> body when <typeparamref name="T" /> is non-value or nullable type.
        /// </summary>
        /// <param name="parameter">Parameter expression with candidate identifier.</param>
        /// <returns>Expression for <see cref="LambdaExpression" /> body.</returns>
        [PublicAPI]
        [NotNull]
        protected abstract Expression BuildExpressionBody([NotNull] Expression parameter);

        /// <summary>
        ///     Creates special <c>Expression</c> body when <typeparamref name="T" /> is value non-nullable type.
        /// </summary>
        /// <remarks>
        ///     Invokes <see cref="BuildExpressionBody" /> by default.
        /// </remarks>
        /// <param name="parameter">Parameter expression with candidate identifier.</param>
        /// <returns>Expression for <see cref="LambdaExpression" /> body.</returns>
        [PublicAPI]
        [NotNull]
        protected virtual Expression BuildValueTypeExpressionBody([NotNull] Expression parameter)
        {
            return BuildExpressionBody(parameter);
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression{Func}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static implicit operator Expression<Func<T, bool>>([NotNull] ComplexSpecification<T> self)
        {
            return self.GetExpression();
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static explicit operator Expression([NotNull] ComplexSpecification<T> self)
        {
            return ((ILinqSpecification) self).GetExpression();
        }
    }
}