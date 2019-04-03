using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using FluentSpecification.Core;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if candidate is empty.
    /// </summary>
    /// <remarks>
    ///     Empty means:
    ///     <list type="bullet">
    ///         <item>
    ///             <term>Null reference</term>
    ///         </item>
    ///         <item>
    ///             <term>Empty string</term>
    ///         </item>
    ///         <item>
    ///             <term>Collection without elements</term>
    ///         </item>
    ///         <item>
    ///             <term>Object is equal to default value of</term>
    ///             <description>
    ///                 <typeparamref name="T" />
    ///             </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public sealed class EmptySpecification<T> :
        ComplexSpecification<T>
    {
        private readonly MethodInfo _anyMethodInfo;
        private readonly bool _checkIsCollectionNull;
        private readonly T _defaultValue;
        private readonly bool _isCollection;
        private readonly bool _isString;

        /// <summary>
        ///     Creates <c>Specification</c> with specific compare method,
        ///     depends on <typeparamref name="T" /> type.
        /// </summary>
        /// <param name="linqToEntities">>Is linq to entities (without null check of collection in <c>Expression</c>).</param>
        [PublicAPI]
        public EmptySpecification(bool linqToEntities = false)
        {
            _isString = typeof(T) == typeof(string);
            _isCollection = typeof(T).IsGenericEnumerable();
            _checkIsCollectionNull = !linqToEntities;
            _defaultValue = default(T);

            if (_isCollection)
            {
                var enumerableType = typeof(T).GetEnumerableGenericTypeArgument();
                var baseMethod = typeof(Enumerable)
                    .GetMethods().First(m => m.Name == nameof(Enumerable.Any) && m.GetParameters().Length == 1);
                _anyMethodInfo = baseMethod.MakeGenericMethod(enumerableType);
            }
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(T candidate)
        {
            return "Object is not empty";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateNegationFailedMessage(T candidate)
        {
            return "Object is empty";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return null;
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildValueTypeExpressionBody(Expression arg)
        {
            var checkExpression = _isString ? Expression.Equal(arg, Expression.Constant(string.Empty)) :
                _isCollection ? Expression.Not(Expression.Call(_anyMethodInfo, arg)) :
                (Expression) Expression.Equal(arg, Expression.Constant(_defaultValue, typeof(T)));
            return checkExpression;
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            var checkNullExpression = Expression.Equal(arg, Expression.Constant(null, typeof(T)));

            var expression = _isString || !_isCollection || _checkIsCollectionNull
                ? Expression.OrElse(checkNullExpression, BuildValueTypeExpressionBody(arg))
                : BuildValueTypeExpressionBody(arg);
            return expression;
        }
    }
}