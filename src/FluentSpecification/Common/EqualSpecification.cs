using System;
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
    ///     Checks if candidate object is equal to expected object.
    /// </summary>
    /// <remarks>
    ///     <c>Specification</c> for comparison use:
    ///     <list type="number">
    ///         <item>
    ///             <term>Comparer</term><description><see cref="IEqualityComparer{T}" /> - if available.</description>
    ///         </item>
    ///         <item>
    ///             <term>Equality operator</term><description>if defined for <typeparamref name="T" />.</description>
    ///         </item>
    ///         <item>
    ///             <term>CompareTo() method</term>
    ///             <description>if <typeparamref name="T" /> implements <see cref="IComparable{T}" />.</description>
    ///         </item>
    ///         <item>
    ///             <term>CompareTo(Object) method</term>
    ///             <description>if <typeparamref name="T" /> implements <see cref="IComparable" />.</description>
    ///         </item>
    ///         <item>
    ///             <term>Equals() method</term>
    ///             <description>if <typeparamref name="T" /> implements <see cref="IEquatable{T}" />.</description>
    ///         </item>
    ///         <item>
    ///             <term>Equals(Object) method.</term>
    ///         </item>
    ///     </list>
    /// </remarks>
    /// <typeparam name="T">Type of compared objects.</typeparam>
    [PublicAPI]
    public sealed class EqualSpecification<T> :
        ComplexSpecification<T>
    {
        private readonly bool _baseEquals;
        private readonly IEqualityComparer<T> _comparer;
        private readonly MethodInfo _compareToMethod;
        private readonly MethodInfo _equalsMethod;
        private readonly T _expected;
        private readonly bool _hasOperator;
        private readonly bool _isNullable;

        /// <summary>
        ///     Creates <c>Specification</c> with specific compare method,
        ///     depends on <typeparamref name="T" /> type.
        /// </summary>
        /// <param name="expected">Expected object.</param>
        /// <param name="comparer">Equality comparer.</param>
        [PublicAPI]
        public EqualSpecification([CanBeNull] T expected, [CanBeNull] IEqualityComparer<T> comparer = null)
        {
            _expected = expected;
            _comparer = comparer;

            var nullableType = Nullable.GetUnderlyingType(typeof(T));
            _isNullable = nullableType != null;

            var underlyingType = nullableType ?? typeof(T);

            _hasOperator = underlyingType.HasEqualityOperator();
            _compareToMethod = underlyingType.GetCompareToMethod(underlyingType) ?? underlyingType.GetCompareToMethod();
            _equalsMethod = underlyingType.GetEqualsMethod(underlyingType) ?? underlyingType.GetEqualsMethod();
            _baseEquals = _equalsMethod.GetParameters().First().ParameterType == typeof(object);
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(T candidate)
        {
            return $"Object is not equal to [{(object) _expected ?? "null"}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateNegationFailedMessage(T candidate)
        {
            return $"Object is equal to [{(object) _expected ?? "null"}]";
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

        private MethodInfo GetComparerEqualsMethodInfo(Type comparerType)
        {
            return comparerType.GetTypeInfo()
                       .GetDeclaredMethods(nameof(IEqualityComparer<T>.Equals))
                       .FirstOrDefault(m => m.ReturnParameter != null &&
                                            m.ReturnParameter.ParameterType == typeof(bool) &&
                                            m.GetParameters().Length == 2 &&
                                            m.GetParameters().First().ParameterType == typeof(T) &&
                                            m.GetParameters().Last().ParameterType == typeof(T)) ??
                   (comparerType.GetTypeInfo().BaseType != null
                       ? GetComparerEqualsMethodInfo(comparerType.GetTypeInfo().BaseType)
                       : null);
        }

        private bool GetComparerExpression(Expression arg, out Expression comparerExpression)
        {
            if (_comparer != null)
            {
                var equalsInfo = GetComparerEqualsMethodInfo(_comparer.GetType());
                comparerExpression = Expression.Call(Expression.Constant(_comparer), equalsInfo,
                    arg, Expression.Constant(_expected, typeof(T)));
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
                return Expression.Equal(arg, Expression.Constant(_expected, underlyingType));

            if (_compareToMethod != null)
            {
                var objectCompare = _compareToMethod.GetParameters().First().ParameterType == typeof(object);
                return Expression.Equal(
                    Expression.Call(arg, _compareToMethod,
                        Expression.Constant(_expected, objectCompare ? typeof(object) : underlyingType)),
                    Expression.Constant(0));
            }

            return Expression.Call(arg, _equalsMethod, Expression.Constant(_expected,
                !_baseEquals ? underlyingType : typeof(object)));
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            if (GetComparerExpression(arg, out var comparerExpression))
                return comparerExpression;

            if (_expected != null)
            {
                var exp = Expression.AndAlso(
                    Expression.NotEqual(arg, Expression.Constant(null, typeof(T))),
                    BuildValueTypeExpressionBody(!_isNullable ? arg : Expression.Property(arg, "Value")));
                return exp;
            }

            return Expression.Equal(arg, Expression.Constant(null, typeof(T)));
        }
    }
}