using System;
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
        private static bool IsByte(Type type)
        {
            return type == typeof(byte) ||
                   type == typeof(sbyte);
        }

        private static bool IsInteger(Type type)
        {
            return type == typeof(ushort) ||
                   type == typeof(uint) ||
                   type == typeof(ulong) ||
                   type == typeof(short) ||
                   type == typeof(int) ||
                   type == typeof(long);
        }

        private static bool IsFloating(Type type)
        {
            return type == typeof(decimal) ||
                   type == typeof(double) ||
                   type == typeof(float);
        }

        /// <summary>
        ///     Checks if current type is numeric.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns>
        ///     true - <paramref name="type" /> is numeric;
        ///     false - <paramref name="type" /> is not numeric
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when cannot get underlying type of nullable.</exception>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        public static bool IsNumericType([NotNull] this Type type)
        {
            type = type ?? throw new NullReferenceException();

            if (IsByte(type) || IsInteger(type) || IsFloating(type)) return true;

            var typeInfo = type.GetTypeInfo();
            if (typeInfo.IsGenericType && typeInfo.GetGenericTypeDefinition() == typeof(Nullable<>))
                return IsNumericType(Nullable.GetUnderlyingType(type) ?? throw new InvalidOperationException());

            return false;
        }

        /// <summary>
        ///     Checks if current type has equality (==) operator.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns>
        ///     true - <paramref name="type" /> has operator;
        ///     false - <paramref name="type" /> hasn't
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
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
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
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
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
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
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
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
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
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
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
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
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetEqualityOperator([NotNull] this Type type)
        {
            return type.GetTypeInfo().GetDeclaredMethod("op_Equality") ??
                   type.GetTypeInfo().BaseType?.GetEqualityOperator();
        }

        /// <summary>
        ///     Gets inequality (!=) operator method for <paramref name="type" />.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> inequality operator.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetInequalityOperator([NotNull] this Type type)
        {
            return type.GetTypeInfo().GetDeclaredMethod("op_Inequality") ??
                   type.GetTypeInfo().BaseType?.GetInequalityOperator();
        }

        /// <summary>
        ///     Gets less than (&lt;) operator method for <paramref name="type" />.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> less than operator.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetLessThanOperator([NotNull] this Type type)
        {
            return type.GetTypeInfo().GetDeclaredMethod("op_LessThan") ??
                   type.GetTypeInfo().BaseType?.GetLessThanOperator();
        }

        /// <summary>
        ///     Gets less than or equal (&lt;=) operator method for <paramref name="type" />.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> less than or equal operator.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetLessThanOrEqualOperator([NotNull] this Type type)
        {
            return type.GetTypeInfo().GetDeclaredMethod("op_LessThanOrEqual") ??
                   type.GetTypeInfo().BaseType?.GetLessThanOrEqualOperator();
        }

        /// <summary>
        ///     Gets grater than (&gt;) operator method for <paramref name="type" />.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> greater than operator.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetGreaterThanOperator([NotNull] this Type type)
        {
            return type.GetTypeInfo().GetDeclaredMethod("op_GreaterThan") ??
                   type.GetTypeInfo().BaseType?.GetGreaterThanOperator();
        }

        /// <summary>
        ///     Gets grater than or equal (&gt;=) operator method for <paramref name="type" />.
        /// </summary>
        /// <param name="type">Self type</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> greater than or equal operator.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetGreaterThanOrEqualOperator([NotNull] this Type type)
        {
            return type.GetTypeInfo().GetDeclaredMethod("op_GreaterThanOrEqual") ??
                   type.GetTypeInfo().BaseType?.GetGreaterThanOrEqualOperator();
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
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
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
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="genericType" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static MethodInfo GetEqualsMethod([NotNull] this Type type, [NotNull] Type genericType)
        {
            if (genericType == null)
                throw new ArgumentNullException(nameof(genericType));

            return type.GetTypeInfo().GetDeclaredMethods(nameof(IEquatable<object>.Equals))
                       .FirstOrDefault(m =>
                           m.GetParameters().Length == 1 && m.GetParameters().First().ParameterType == genericType) ??
                   type.GetTypeInfo().BaseType?.GetEqualsMethod(genericType);
        }

        /// <summary>
        ///     Gets base <c>Equals</c> method.
        /// </summary>
        /// <param name="type">Self type.</param>
        /// <returns><see cref="MethodInfo" /> of <paramref name="type" /> base <c>Equals</c> method.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown when cannot get <c>Equals</c> method.</exception>
        [PublicAPI]
        [NotNull]
        public static MethodInfo GetEqualsMethod([NotNull] this Type type)
        {
            return type.GetTypeInfo().GetDeclaredMethods(nameof(object.Equals))
                       .FirstOrDefault(m =>
                           m.GetParameters().Length == 1 &&
                           m.GetParameters().First().ParameterType == typeof(object)) ??
                   type.GetTypeInfo().BaseType?.GetEqualsMethod() ??
                   throw new InvalidOperationException();
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
            if (genericType == null)
                throw new ArgumentNullException(nameof(genericType));

            return type.GetTypeInfo().GetDeclaredMethods(nameof(IComparable.CompareTo))
                       .FirstOrDefault(m =>
                           m.GetParameters().Length == 1 && m.GetParameters().First().ParameterType == genericType) ??
                   type.GetTypeInfo().BaseType?.GetCompareToMethod(genericType);
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
            return type.GetTypeInfo().GetDeclaredMethods(nameof(IComparable.CompareTo))
                       .FirstOrDefault(m =>
                           m.GetParameters().Length == 1 &&
                           m.GetParameters().First().ParameterType == typeof(object)) ??
                   type.GetTypeInfo().BaseType?.GetCompareToMethod();
        }

        /// <summary>
        ///     Checks if type implements <see cref="IEnumerable{T}" />.
        /// </summary>
        /// <param name="type">Self type.</param>
        /// <returns>
        ///     <para>true - type is <see cref="IEnumerable{T}" />.</para>
        ///     <para>false - type is not.</para>
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        public static bool IsGenericEnumerable([NotNull] this Type type)
        {
            return type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>) ||
                   type.GetTypeInfo().ImplementedInterfaces
                       .Any(i => i.GetTypeInfo().IsGenericType && i.GetGenericTypeDefinition() == typeof(IEnumerable<>));
        }

        /// <summary>
        ///     Gets generic type argument of <see cref="IEnumerable{T}" />.
        /// </summary>
        /// <param name="type">Self type.</param>
        /// <returns>Generic type argument.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
        [PublicAPI]
        [CanBeNull]
        public static Type GetEnumerableGenericTypeArgument([NotNull] this Type type)
        {
            if (!type.IsGenericEnumerable())
                return null;

            return type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>)
                ? type.GenericTypeArguments.First()
                : type.GetTypeInfo().ImplementedInterfaces
                    .Where(i => i.GetTypeInfo().IsGenericType && i.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                    .Select(t => t.GenericTypeArguments.First())
                    .FirstOrDefault();
        }
    }
}