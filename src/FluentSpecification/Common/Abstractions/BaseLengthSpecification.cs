using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentSpecification.Core;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;

namespace FluentSpecification.Common.Abstractions
{
    /// <summary>
    ///     Base implementation for all <c>Specifications</c> with collection length verification.
    /// </summary>
    /// <typeparam name="T">Type of <see cref="IEnumerable" /> candidate.</typeparam>
    [PublicAPI]
    public abstract class BaseLengthSpecification<T> :
        ComplexSpecification<T>
        where T : IEnumerable
    {
        private readonly bool _cast;
        private readonly MethodInfo _castMethodInfo;
        private readonly MethodInfo _countMethodInfo;
        private readonly bool _hasCheckNullExpression;
        private readonly bool _isString;

        /// <summary>
        ///     Creates <c>Specification</c> for candidate (collection) length verification.
        /// </summary>
        /// <param name="linqToEntities">Is linq to entities (without null check of collection in <c>Expression</c>).</param>
        [PublicAPI]
        protected BaseLengthSpecification(bool linqToEntities)
        {
            _hasCheckNullExpression = !linqToEntities;

            _isString = typeof(string) == typeof(T);
            if (!_isString)
            {
                var baseMethod = typeof(Enumerable)
                    .GetMethods().First(m => m.Name == nameof(Enumerable.Count) && m.GetParameters().Length == 1);

                if (typeof(T).IsGenericEnumerable())
                {
                    var enumerableType = typeof(T).GetEnumerableGenericTypeArgument();
                    _countMethodInfo = baseMethod.MakeGenericMethod(enumerableType);
                }
                else
                {
                    _cast = true;
                    _countMethodInfo = baseMethod.MakeGenericMethod(typeof(object));
                    var baseCast = typeof(Enumerable).GetMethod(nameof(Enumerable.Cast), new[] {typeof(IEnumerable)});
                    if (baseCast != null)
                        _castMethodInfo = baseCast.MakeGenericMethod(typeof(object));
                }
            }
        }

        /// <summary>
        ///     Builds <c>Expression</c> with compare of result Count() method.
        /// </summary>
        /// <param name="arg">Candidate parameter <c>Expression</c></param>
        /// <param name="callExpression">Count() method call <c>Expression</c></param>
        /// <returns>Expression with count compare.</returns>
        [PublicAPI]
        [NotNull]
        protected abstract Expression BuildValueTypeExpressionBody([NotNull] Expression arg,
            [NotNull] Expression callExpression);

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildValueTypeExpressionBody(Expression arg)
        {
            var callExpression = !_isString
                ? !_cast ? Expression.Call(_countMethodInfo, arg)
                : Expression.Call(_countMethodInfo, Expression.Call(_castMethodInfo, arg))
                : (Expression) Expression.Property(arg, nameof(string.Length));

            var expression = BuildValueTypeExpressionBody(arg, callExpression);

            return expression;
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            var checkNullExpression = Expression.NotEqual(arg, Expression.Constant(null, typeof(T)));

            var expression = _isString || _hasCheckNullExpression
                ? Expression.AndAlso(checkNullExpression, BuildValueTypeExpressionBody(arg))
                : BuildValueTypeExpressionBody(arg);
            return expression;
        }
    }
}