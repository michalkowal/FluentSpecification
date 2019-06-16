using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using JetBrains.Annotations;

namespace FluentSpecification
{
    public static partial class SpecificationExtensions
    {
        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="ExpressionSpecification{T}" /> for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if external <c>Linq</c> <c>Expression</c> is satisfied by candidate property.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="expression">External <c>Expression</c>.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Expression<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [NotNull] Expression<Func<TProperty, bool>> expression)
        {
            return self.Compose(Expression(selector, expression));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="NullSpecification{TProperty}" /> for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is null.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Null<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector)
        {
            return self.Compose(Null(selector));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="NullSpecification{TType}" /> negation
        ///         for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not null.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotNull<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector)
        {
            return self.Compose(NotNull(selector));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="EmptySpecification{TType}" /> for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is empty.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Empty<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector)
        {
            return self.Compose(Empty(selector));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="EmptySpecification{TType}" /> negation
        ///         for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not empty.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotEmpty<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector)
        {
            return self.Compose(NotEmpty(selector));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="EqualSpecification{TType}" /> for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is equal to expected object.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="expected">Expected object.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Equal<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty expected,
            [CanBeNull] IEqualityComparer<TProperty> comparer = null)
        {
            return self.Compose(Equal(selector, expected, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="EqualSpecification{TType}" /> negation
        ///         for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not equal to expected object.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notExpected">Not expected object.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotEqual<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty notExpected,
            [CanBeNull] IEqualityComparer<TProperty> comparer = null)
        {
            return self.Compose(NotEqual(selector, notExpected, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="LengthSpecification{TProperty}" /> for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is equal to specific value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="length">Expected candidate property length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Length<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, int length)
            where TProperty : IEnumerable
        {
            return self.Compose(Length(selector, length));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="LengthSpecification{TProperty}" />
        ///         negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is not equal to specific value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate property to verify (collection or string).</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="length">Not expected candidate property length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLength<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, int length)
            where TProperty : IEnumerable
        {
            return self.Compose(NotLength(selector, length));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="MinLengthSpecification{TProperty}" />
        ///         for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is greater than or equal to Min value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="minLength">Minimum candidate property length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> MinLength<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, int minLength)
            where TProperty : IEnumerable
        {
            return self.Compose(MinLength(selector, minLength));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="MinLengthSpecification{TProperty}" />
        ///         negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is not greater than or equal to (is less than) Min value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="minLength">Not minimum candidate property length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotMinLength<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, int minLength)
            where TProperty : IEnumerable
        {
            return self.Compose(NotMinLength(selector, minLength));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="MaxLengthSpecification{TProperty}" />
        ///         for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is lower than or equal to Max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="maxLength">Maximum candidate property length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> MaxLength<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, int maxLength)
            where TProperty : IEnumerable
        {
            return self.Compose(MaxLength(selector, maxLength));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="MaxLengthSpecification{TProperty}" />
        ///         negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is not lower than or equal to (is greater than) Max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="maxLength">Not maximum candidate property length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotMaxLength<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, int maxLength)
            where TProperty : IEnumerable
        {
            return self.Compose(NotMaxLength(selector, maxLength));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="LengthBetweenSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is between Min and Max values.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="minLength">Minimum candidate property length.</param>
        /// <param name="maxLength">Maximum candidate property length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">
        ///     Thrown when <paramref name="maxLength" /> is lower than
        ///     <paramref name="minLength" />.
        /// </exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> LengthBetween<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, int minLength, int maxLength)
            where TProperty : IEnumerable
        {
            return self.Compose(LengthBetween(selector, minLength, maxLength));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="LengthBetweenSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is not between Min and Max values.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="minLength">Not minimum candidate property length.</param>
        /// <param name="maxLength">Not maximum candidate property length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">
        ///     Thrown when <paramref name="maxLength" /> is lower than
        ///     <paramref name="minLength" />.
        /// </exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLengthBetween<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, int minLength, int maxLength)
            where TProperty : IEnumerable
        {
            return self.Compose(NotLengthBetween(selector, minLength, maxLength));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="LessThanSpecification{TProperty}" /> for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is lower than expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="lessThan">Candidate property should be less than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> LessThan<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty lessThan,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            return self.Compose(LessThan(selector, lessThan, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="LessThanSpecification{TProperty}" />
        ///         negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not lower than (greater than or equal to) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notLessThan">Candidate property should not be less than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLessThan<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty notLessThan,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            return self.Compose(NotLessThan(selector, notLessThan, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="LessThanOrEqualSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is lower than or equal to expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="lessThan">Candidate property should be less than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> LessThanOrEqual<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty lessThan,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            return self.Compose(LessThanOrEqual(selector, lessThan, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="LessThanOrEqualSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not lower than or equal to (greater than) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notLessThan">Candidate property should not be less than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLessThanOrEqual<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty notLessThan,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            return self.Compose(NotLessThanOrEqual(selector, notLessThan, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="GreaterThanSpecification{TProperty}" />
        ///         for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is greater than expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="greaterThan">Candidate property should be greater than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> GreaterThan<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty greaterThan,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            return self.Compose(GreaterThan(selector, greaterThan, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="GreaterThanSpecification{TProperty}" />
        ///         negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not greater than (lower than or equal to) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notGreaterThan">Candidate property should not be greater than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotGreaterThan<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty notGreaterThan,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            return self.Compose(NotGreaterThan(selector, notGreaterThan, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="GreaterThanOrEqualSpecification{TProperty}" /> candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is greater than or equal to expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="greaterThan">Candidate property should be greater than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> GreaterThanOrEqual<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty greaterThan,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            return self.Compose(GreaterThanOrEqual(selector, greaterThan, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="GreaterThanOrEqualSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not greater than or equal to (lower than) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notGreaterThan">Candidate property should not be greater than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotGreaterThanOrEqual<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty notGreaterThan,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            return self.Compose(NotGreaterThanOrEqual(selector, notGreaterThan, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="MatchSpecification" /> for candidate
        ///         property:
        ///     </para>
        ///     <para>
        ///         Checks if string candidate property match a given Regex pattern.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="pattern">Regex pattern.</param>
        /// <param name="options">Regex matching options.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="pattern" /> is null or empty.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Match<T>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, string>> selector, [NotNull] string pattern,
            RegexOptions options = RegexOptions.None)
        {
            return self.Compose(Match(selector, pattern, options));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="MatchSpecification" /> negation for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string candidate property not match a given Regex pattern.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="pattern">Regex pattern.</param>
        /// <param name="options">Regex matching options.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="pattern" /> is null or empty.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotMatch<T>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, string>> selector, [NotNull] string pattern,
            RegexOptions options = RegexOptions.None)
        {
            return self.Compose(NotMatch(selector, pattern, options));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="EmailSpecification" /> for candidate
        ///         property:
        ///     </para>
        ///     <para>
        ///         Checks if string is valid email address.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Email<T>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, string>> selector)
        {
            return self.Compose(Email(selector));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="EmailSpecification" /> negation for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string is not valid email address.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotEmail<T>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, string>> selector)
        {
            return self.Compose(NotEmail(selector));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="ExclusiveBetweenSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is between (exclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="from">Min candidate value.</param>
        /// <param name="to">Max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="from" /> is greater than <paramref name="to" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> ExclusiveBetween<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty from, [CanBeNull] TProperty to,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            return self.Compose(ExclusiveBetween(selector, from, to, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="ExclusiveBetweenSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not between (exclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notFrom">Not min candidate value.</param>
        /// <param name="notTo">Not max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="notFrom" /> is greater than <paramref name="notTo" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotExclusiveBetween<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty notFrom,
            [CanBeNull] TProperty notTo,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            return self.Compose(NotExclusiveBetween(selector, notFrom, notTo, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="InclusiveBetweenSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is between (inclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="from">Min candidate value.</param>
        /// <param name="to">Max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="from" /> is greater than <paramref name="to" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> InclusiveBetween<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty from, [CanBeNull] TProperty to,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            return self.Compose(InclusiveBetween(selector, from, to, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="InclusiveBetweenSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not between (inclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notFrom">Not min candidate value.</param>
        /// <param name="notTo">Not max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="notFrom" /> is greater than <paramref name="notTo" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotInclusiveBetween<T, TProperty>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty notFrom,
            [CanBeNull] TProperty notTo,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            return self.Compose(NotInclusiveBetween(selector, notFrom, notTo, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="CreditCardSpecification" /> for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string is valid credit card number.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> CreditCard<T>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, string>> selector)
        {
            return self.Compose(CreditCard(selector));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="CreditCardSpecification" /> negation for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string is not valid credit card number.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotCreditCard<T>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, string>> selector)
        {
            return self.Compose(NotCreditCard(selector));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="AllSpecification{TProperty, TPropertyType}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if <see cref="ISpecification{TPropertyType}" /> is satisfied by ALL elements in candidate property
        ///         collection.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TPropertyType">Type of collection element to verify.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="allSpecification">Specification for candidate property one element.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> All<T, TPropertyType>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, IEnumerable<TPropertyType>>> selector,
            [NotNull] ISpecification<TPropertyType> allSpecification)
        {
            return self.Compose(All(selector, allSpecification));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="AnySpecification{TProperty, TPropertyType}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if <see cref="ISpecification{TPropertyType}" /> is satisfied by ANY element in candidate property
        ///         collection.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TPropertyType">Type of collection element to verify.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="anySpecification">Specification for candidate property one element.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Any<T, TPropertyType>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, IEnumerable<TPropertyType>>> selector,
            [NotNull] ISpecification<TPropertyType> anySpecification)
        {
            return self.Compose(Any(selector, anySpecification));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="TrueSpecification" /> for candidate
        ///         property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is True.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> True<T>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, bool>> selector)
        {
            return self.Compose(True(selector));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="FalseSpecification" /> for candidate
        ///         property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is False.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> False<T>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, bool>> selector)
        {
            return self.Compose(False(selector));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="IsTypeSpecification{TProperty}" /> for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is compatible with a given type.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verification.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="expected">Expected type of candidate property.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="expected" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> IsType<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [NotNull] Type expected)
        {
            return self.Compose(IsType(selector, expected));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="IsTypeSpecification{TProperty}" />
        ///         negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not compatible with a given type.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verification.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notExpected">Not expected type of candidate property.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="notExpected" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> IsNotType<T, TProperty>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [NotNull] Type notExpected)
        {
            return self.Compose(IsNotType(selector, notExpected));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="ContainsSpecification{TProperty, TPropertyType}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property contains expected element.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TPropertyType">Type of expected element in collection.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="expected">Expected element in collection.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Contains<T, TPropertyType>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, IEnumerable<TPropertyType>>> selector, TPropertyType expected,
            [CanBeNull] IEqualityComparer<TPropertyType> comparer = null)
        {
            return self.Compose(Contains(selector, expected, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with
        ///         <see cref="ContainsSpecification{TProperty, TPropertyType}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property not contains expected element.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TPropertyType">Type of expected element in collection.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notExpected">Not expected element in collection.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotContains<T, TPropertyType>(
            [NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, IEnumerable<TPropertyType>>> selector, [CanBeNull] TPropertyType notExpected,
            [CanBeNull] IEqualityComparer<TPropertyType> comparer = null)
        {
            return self.Compose(NotContains(selector, notExpected, comparer));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="ContainsSpecification" /> for candidate
        ///         property:
        ///     </para>
        ///     <para>
        ///         Checks if string contains another string (case sensitive).
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="expected">Expected substring.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Contains<T>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, string>> selector, [NotNull] string expected)
        {
            return self.Compose(Contains(selector, expected));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="ContainsSpecification" /> negation for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string not contains another string (case sensitive).
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notExpected">Not expected substring.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotContains<T>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, string>> selector, [NotNull] string notExpected)
        {
            return self.Compose(NotContains(selector, notExpected));
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="CastSpecification{T,TCast}" /> for
        ///         candidate property:
        ///     </para>
        ///     <para>
        ///         Converts <c>Specification</c> (candidate property to verification)
        ///         from <typeparamref name="TProperty" /> to <typeparamref name="TCast" />.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <typeparam name="TCast">Type of candidate to verify after cast.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="propertySpecification">Specification to convert.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="propertySpecification" /> is null.</exception>
        /// <exception cref="InvalidOperationException">
        ///     Thrown when there is no conversion between
        ///     <typeparamref name="TProperty" /> and <typeparamref name="TCast" />.
        /// </exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Cast<T, TProperty, TCast>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, TProperty>> selector, [NotNull] ISpecification<TCast> propertySpecification)
        {
            return self.Compose(Cast(selector, propertySpecification));
        }
    }
}