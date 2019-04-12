using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentSpecification.Core;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;

namespace FluentSpecification.Common.Abstractions
{
    /// <summary>
    ///     Base implementation for all <c>Specifications</c> with two value comparison.
    /// </summary>
    /// <typeparam name="T">Type of compared objects.</typeparam>
    [PublicAPI]
    public abstract class BaseCompareSpecification<T> :
        ComplexSpecification<T>
    {
        private readonly Func<Expression, Expression, Expression> _compareExpression;
        private readonly IComparer<T> _comparer;
        private readonly MethodInfo _compareToMethodInfo;
        private readonly bool _hasOperator;

        /// <summary>
        ///     Creates <c>Specification</c> for candidate value comparison.
        /// </summary>
        /// <param name="limit">Limit value for comparison.</param>
        /// <param name="compareExpression"><c>Linq</c> <c>Expression</c> for values comparison.</param>
        /// <param name="comparer">Comparer.</param>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        protected BaseCompareSpecification([CanBeNull] T limit,
            [NotNull] Func<Expression, Expression, Expression> compareExpression, [CanBeNull] IComparer<T> comparer)
        {
            Limit = limit;
            _compareExpression = compareExpression ?? throw new ArgumentNullException(nameof(compareExpression));
            _comparer = comparer;

            var nullableType = Nullable.GetUnderlyingType(typeof(T));
            IsNullable = nullableType != null;

            _hasOperator = nullableType?.HasLessThanOrEqualOperator() ?? typeof(T).HasLessThanOrEqualOperator();
            _compareToMethodInfo = nullableType == null
                ? typeof(T).GetCompareToMethod<T>() ?? typeof(T).GetCompareToMethod()
                : nullableType.GetCompareToMethod(nullableType) ?? nullableType.GetCompareToMethod();

            if (_comparer == null && !_hasOperator && _compareToMethodInfo == null)
                throw new ArgumentException($"Cannot compare type {typeof(T)}");
        }

        /// <summary>
        ///     Is <typeparamref name="T" /> nullable type.
        /// </summary>
        protected bool IsNullable { get; }

        /// <summary>
        ///     Limit value.
        /// </summary>
        protected T Limit { get; }

        private MethodInfo GetComparerCompareMethodInfo(Type comparerType)
        {
            return comparerType.GetTypeInfo()
                .GetDeclaredMethods(nameof(IComparer<T>.Compare))
                .FirstOrDefault(m => m.ReturnParameter != null &&
                            m.ReturnParameter.ParameterType == typeof(int) &&
                            m.GetParameters().Length == 2 &&
                            m.GetParameters().First().ParameterType == typeof(T) &&
                            m.GetParameters().Last().ParameterType == typeof(T)) ??
                   (comparerType.GetTypeInfo().BaseType != null 
                       ? GetComparerCompareMethodInfo(comparerType.GetTypeInfo().BaseType) 
                       : null);
        }

        /// <summary>
        ///     Gets <c>Expression</c> for <see cref="_comparer" /> method call with values.
        /// </summary>
        /// <param name="arg">Candidate <c>Expression</c> parameter.</param>
        /// <param name="comparerExpression"><c>Expression</c> with comparer method call.</param>
        /// <returns>
        ///     <para>true - <see cref="_comparer" /> defined.</para>
        ///     <para>false - not defined.</para>
        /// </returns>
        [PublicAPI]
        protected bool GetComparerExpression(Expression arg, out Expression comparerExpression)
        {
            if (_comparer != null)
            {
                var compareInfo = GetComparerCompareMethodInfo(_comparer.GetType());
                comparerExpression = _compareExpression(
                    Expression.Call(Expression.Constant(_comparer), compareInfo,
                        arg, Expression.Constant(Limit, typeof(T))),
                    Expression.Constant(0));
                return true;
            }

            comparerExpression = null;
            return false;
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildValueTypeExpressionBody(Expression arg)
        {
            var underlyingType = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);

            if (GetComparerExpression(arg, out var comparerExpression))
                return comparerExpression;

            if (_hasOperator || underlyingType.IsNumericType())
                return _compareExpression(arg, Expression.Constant(Limit, underlyingType));

            var objectCompare = _compareToMethodInfo.GetParameters().First().ParameterType == typeof(object);

            return _compareExpression(
                Expression.Call(arg, _compareToMethodInfo,
                    Expression.Constant(Limit, objectCompare ? typeof(object) : underlyingType)),
                Expression.Constant(0));
        }

        /// <summary>
        ///     Creates special <c>Expression</c> body when Limit value defined.
        /// </summary>
        /// <param name="arg">Parameter expression with candidate identifier.</param>
        /// <returns>Expression for <see cref="LambdaExpression" /> body.</returns>
        [PublicAPI]
        [NotNull]
        protected abstract Expression BuildExpressionBodyWithLimit([NotNull] Expression arg);

        /// <summary>
        ///     Creates special <c>Expression</c> body when Limit value is not defined.
        /// </summary>
        /// <param name="arg">Parameter expression with candidate identifier.</param>
        /// <returns>Expression for <see cref="LambdaExpression" /> body.</returns>
        [PublicAPI]
        [NotNull]
        protected abstract Expression BuildExpressionBodyWithoutLimit([NotNull] Expression arg);

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            if (GetComparerExpression(arg, out var comparerExpression))
                return comparerExpression;

            if (Limit != null) return BuildExpressionBodyWithLimit(arg);

            return BuildExpressionBodyWithoutLimit(arg);
        }
    }
}