using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Utils
{
    /// <summary>
    ///     Extensions methods for <see cref="Type" />.
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        ///     Checks if current type is numeric.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns>
        ///     true - <paramref name="type" /> is numeric;
        ///     false - <paramref name="type" /> is not numeric
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when cannot get underlying type of nullable.</exception>
        [PublicAPI]
        public static bool IsNumericType([NotNull] this Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                case TypeCode.Object:
                    if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                        return IsNumericType(Nullable.GetUnderlyingType(type) ?? throw new InvalidOperationException());

                    return false;
                default:
                    return false;
            }
        }

        /// <summary>
        ///     Checks if current type has equality (==) operator.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns>
        ///     true - <paramref name="type" /> has operator;
        ///     false - <paramref name="type" /> hasn't
        /// </returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        public static bool HasEqualityOperator([NotNull] this Type type)
        {
            return GetEqualityOperator(type) != null;
        }

        /// <summary>
        ///     Checks if current type has inequality (!=) operator.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns>
        ///     true - <paramref name="type" /> has operator;
        ///     false - <paramref name="type" /> hasn't
        /// </returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        public static bool HasInequalityOperator([NotNull] this Type type)
        {
            return GetInequalityOperator(type) != null;
        }

        /// <summary>
        ///     Checks if current type has less than (&lt;) operator.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns>
        ///     true - <paramref name="type" /> has operator;
        ///     false - <paramref name="type" /> hasn't
        /// </returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        public static bool HasLessThanOperator([NotNull] this Type type)
        {
            return GetLessThanOperator(type) != null;
        }

        /// <summary>
        ///     Checks if current type has less than or equal (&lt;=) operator.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns>
        ///     true - <paramref name="type" /> has operator;
        ///     false - <paramref name="type" /> hasn't
        /// </returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        public static bool HasLessThanOrEqualOperator([NotNull] this Type type)
        {
            return GetLessThanOrEqualOperator(type) != null;
        }

        /// <summary>
        ///     Checks if current type has greater than (&gt;) operator.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns>
        ///     true - <paramref name="type" /> has operator;
        ///     false - <paramref name="type" /> hasn't
        /// </returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        public static bool HasGreaterThanOperator([NotNull] this Type type)
        {
            return GetGreaterThanOperator(type) != null;
        }

        /// <summary>
        ///     Checks if current type has greater than or equal (&gt;=) operator.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns>
        ///     true - <paramref name="type" /> has operator;
        ///     false - <paramref name="type" /> hasn't
        /// </returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        public static bool HasGreaterThanOrEqualOperator([NotNull] this Type type)
        {
            return GetGreaterThanOrEqualOperator(type) != null;
        }

        /// <summary>
        ///     Gets equality (==) operator method for <paramref name="type" />.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> equality operator.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetEqualityOperator([NotNull] this Type type)
        {
            return type.GetMethod("op_Equality",
                BindingFlags.Static | BindingFlags.Public, null, new[] {type, type}, null);
        }

        /// <summary>
        ///     Gets inequality (!=) operator method for <paramref name="type" />.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> inequality operator.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetInequalityOperator([NotNull] this Type type)
        {
            return type.GetMethod("op_Inequality",
                BindingFlags.Static | BindingFlags.Public, null, new[] {type, type}, null);
        }

        /// <summary>
        ///     Gets less than (&lt;) operator method for <paramref name="type" />.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> less than operator.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetLessThanOperator([NotNull] this Type type)
        {
            return type.GetMethod("op_LessThan",
                BindingFlags.Static | BindingFlags.Public, null, new[] {type, type}, null);
        }

        /// <summary>
        ///     Gets less than or equal (&lt;=) operator method for <paramref name="type" />.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> less than or equal operator.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetLessThanOrEqualOperator([NotNull] this Type type)
        {
            return type.GetMethod("op_LessThanOrEqual",
                BindingFlags.Static | BindingFlags.Public, null, new[] {type, type}, null);
        }

        /// <summary>
        ///     Gets grater than (&gt;) operator method for <paramref name="type" />.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> greater than operator.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetGreaterThanOperator([NotNull] this Type type)
        {
            return type.GetMethod("op_GreaterThan",
                BindingFlags.Static | BindingFlags.Public, null, new[] {type, type}, null);
        }

        /// <summary>
        ///     Gets grater than or equal (&gt;=) operator method for <paramref name="type" />.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> greater than or equal operator.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetGreaterThanOrEqualOperator([NotNull] this Type type)
        {
            return type.GetMethod("op_GreaterThanOrEqual",
                BindingFlags.Static | BindingFlags.Public, null, new[] {type, type}, null);
        }

        /// <summary>
        ///     Gets <c>Equals</c> method with parameter of <typeparamref name="T" />.
        ///     See <see cref="IEquatable{T}" />.
        /// </summary>
        /// <remarks>
        ///     When strongly typed <c>Equals</c>s is not available, returns base <c>Object</c> method (
        ///     <see cref="object.Equals(object)" />)
        /// </remarks>
        /// <typeparam name="T">Type of <c>Equals</c> method parameter.</typeparam>
        /// <param name="type">Self type.</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> <c>Equals</c> method.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetEqualsMethod<T>([NotNull] this Type type)
        {
            return type.GetEqualsMethod(typeof(T));
        }

        /// <summary>
        ///     Gets <c>Equals</c> method with parameter of <paramref name="genericType" />.
        ///     See <see cref="IEquatable{T}" />.
        /// </summary>
        /// <param name="type">Self type.</param>
        /// <param name="genericType">Type of <c>Equals</c> method parameter.</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> <c>Equals</c> method.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="genericType" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetEqualsMethod([NotNull] this Type type, [NotNull] Type genericType)
        {
            return type.GetMethod(nameof(IEquatable<object>.Equals),
                new[] {genericType ?? throw new ArgumentNullException(nameof(genericType))});
        }

        /// <summary>
        ///     Gets base <c>Equals</c> method.
        /// </summary>
        /// <param name="type">Self type.</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> base <c>Equals</c> method.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown when cannot get <c>Equals</c> method.</exception>
        [PublicAPI]
        [NotNull]
        public static MethodInfo GetEqualsMethod([NotNull] this Type type)
        {
            return type.GetMethod(nameof(object.Equals), new[] {typeof(object)})
                   ?? throw new InvalidOperationException();
        }

        /// <summary>
        ///     Gets <c>CompareTo</c> method with parameter of <typeparamref name="T" />.
        ///     See <see cref="IComparable{T}" />.
        /// </summary>
        /// <typeparam name="T">Type of <c>CompareTo</c> method parameter.</typeparam>
        /// <param name="type">Self type.</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> <c>CompareTo</c> method.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetCompareToMethod<T>([NotNull] this Type type)
        {
            return type.GetCompareToMethod(typeof(T));
        }

        /// <summary>
        ///     Gets <c>CompareTo</c> method with parameter of <paramref name="genericType" />.
        ///     See <see cref="IComparable{T}" />.
        /// </summary>
        /// <param name="type">Self type.</param>
        /// <param name="genericType">Type of <c>CompareTo</c> method parameter.</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> <c>CompareTo</c> method.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="genericType" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetCompareToMethod([NotNull] this Type type, [NotNull] Type genericType)
        {
            return type.GetMethod(nameof(IComparable.CompareTo), new[] {genericType});
        }

        /// <summary>
        ///     Gets <c>CompareTo</c> method.
        ///     See <see cref="IComparable" />.
        /// </summary>
        /// <param name="type">Self type.</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> <c>CompareTo</c> method.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetCompareToMethod([NotNull] this Type type)
        {
            return type.GetMethod(nameof(IComparable.CompareTo), new[] {typeof(object)});
        }

        /// <summary>
        ///     Checks if type implements <see cref="IEnumerable{T}" />.
        /// </summary>
        /// <param name="type">Self type.</param>
        /// <returns>
        ///     <para>true - type is <see cref="IEnumerable{T}" />.</para>
        ///     <para>false - type is not.</para>
        /// </returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        public static bool IsGenericEnumerable([NotNull] this Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>) || type
                       .GetInterfaces()
                       .Any(i => i.Name.StartsWith(nameof(IEnumerable)) && i.GenericTypeArguments.Length == 1);
        }

        /// <summary>
        ///     Gets generic type argument of <see cref="IEnumerable{T}" />.
        /// </summary>
        /// <param name="type">Self type.</param>
        /// <returns>Generic type argument.</returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static Type GetEnumerableGenericTypeArgument([NotNull] this Type type)
        {
            if (!type.IsGenericEnumerable())
                return null;

            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>)
                ? type.GenericTypeArguments.First()
                : type.GetInterfaces()
                    .Where(i => i.Name.StartsWith(nameof(IEnumerable)) && i.GenericTypeArguments.Length == 1)
                    .Select(t => t.GenericTypeArguments.First())
                    .FirstOrDefault();
        }
    }
}