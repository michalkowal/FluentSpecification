using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentSpecification.Core;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if candidate contains expected element.
    /// </summary>
    /// <typeparam name="T">Type of candidate (collection)</typeparam>
    /// <typeparam name="TType">Type of expected element in collection.</typeparam>
    [PublicAPI]
    public sealed class ContainsSpecification<T, TType> :
        ComplexSpecification<T>
        where T : IEnumerable<TType>
    {
        private readonly IEqualityComparer<TType> _comparer;
        private readonly MethodInfo _containsMethodInfo;
        private readonly TType _expected;
        private readonly bool _hasCheckNullExpression;

        /// <summary>
        ///     Creates <c>Specification</c> for <paramref name="expected" /> element.
        /// </summary>
        /// <param name="expected">Expected element in collection.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <param name="linqToEntities">Is linq to entities (without null check of collection in <c>Expression</c>).</param>
        [PublicAPI]
        public ContainsSpecification([CanBeNull] TType expected, [CanBeNull] IEqualityComparer<TType> comparer = null,
            bool linqToEntities = false)
        {
            _expected = expected;
            _comparer = comparer;
            _hasCheckNullExpression = !linqToEntities;

            var baseMethod = typeof(Enumerable)
                .GetMethods().First(m =>
                    m.Name == nameof(Enumerable.Contains) && m.GetParameters().Length == (comparer == null ? 2 : 3));
            _containsMethodInfo = baseMethod.MakeGenericMethod(typeof(TType));
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(T candidate)
        {
            return $"Collection not contains [{(object) _expected ?? "null"}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateNegationFailedMessage(T candidate)
        {
            return $"Collection contains [{(object) _expected ?? "null"}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"Expected", _expected}
            };
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildValueTypeExpressionBody(Expression arg)
        {
            var expression = _comparer == null
                ? Expression.Call(_containsMethodInfo, arg, Expression.Constant(_expected, typeof(TType)))
                : Expression.Call(_containsMethodInfo, arg, Expression.Constant(_expected, typeof(TType)),
                    Expression.Constant(_comparer));

            return expression;
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            var checkNullExpression = Expression.NotEqual(arg, Expression.Constant(null, typeof(T)));

            var expression = _hasCheckNullExpression
                ? Expression.AndAlso(checkNullExpression, BuildValueTypeExpressionBody(arg))
                : BuildValueTypeExpressionBody(arg);
            return expression;
        }
    }
}