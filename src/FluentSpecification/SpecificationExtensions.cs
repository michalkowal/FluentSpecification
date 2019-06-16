using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Common;
using FluentSpecification.Core;
using FluentSpecification.Core.Composite;
using JetBrains.Annotations;

namespace FluentSpecification
{
    public static partial class SpecificationExtensions
    {
        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="ExpressionSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if external <c>Linq</c> <c>Expression</c> is satisfied by candidate.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="expression">External <c>Expression</c>.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Expression<T>([NotNull] this ISpecification<T> self,
            [NotNull] Expression<Func<T, bool>> expression)
        {
            var other = new ExpressionSpecification<T>(expression);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="NullSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is null.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Null<T>([NotNull] this ISpecification<T> self)
        {
            var other = new NullSpecification<T>();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="NullSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is not null.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotNull<T>([NotNull] this ISpecification<T> self)
        {
            var other = new NullSpecification<T>().Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="EmptySpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is empty.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Empty<T>([NotNull] this ISpecification<T> self)
        {
            var other = new EmptySpecification<T>(Specification.LinqToEntities);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="EmptySpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is not empty.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotEmpty<T>([NotNull] this ISpecification<T> self)
        {
            var other = new EmptySpecification<T>(Specification.LinqToEntities).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="EqualSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is equal to expected object.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="expected">Expected object.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Equal<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T expected,
            [CanBeNull] IEqualityComparer<T> comparer = null)
        {
            var other = new EqualSpecification<T>(expected, comparer);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="EqualSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not equal to expected object.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="notExpected">Not expected object.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotEqual<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T notExpected,
            [CanBeNull] IEqualityComparer<T> comparer = null)
        {
            var other = new EqualSpecification<T>(notExpected, comparer).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="LengthSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is equal to specific value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="length">Expected candidate length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Length<T>([NotNull] this ISpecification<T> self, int length)
            where T : IEnumerable
        {
            var other = new LengthSpecification<T>(length, Specification.LinqToEntities);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="LengthSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is not equal to specific value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="length">Not expected candidate length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLength<T>([NotNull] this ISpecification<T> self, int length)
            where T : IEnumerable
        {
            var other = new LengthSpecification<T>(length, Specification.LinqToEntities).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="MinLengthSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is greater than or equal to Min value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="minLength">Minimum candidate length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> MinLength<T>([NotNull] this ISpecification<T> self,
            int minLength)
            where T : IEnumerable
        {
            var other = new MinLengthSpecification<T>(minLength, Specification.LinqToEntities);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="MinLengthSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is not greater than or equal to (is less than) Min value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="minLength">Not minimum candidate length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotMinLength<T>([NotNull] this ISpecification<T> self,
            int minLength)
            where T : IEnumerable
        {
            var other = new MinLengthSpecification<T>(minLength, Specification.LinqToEntities).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="MinLengthSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is lower than or equal to Max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="maxLength">Maximum candidate length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> MaxLength<T>([NotNull] this ISpecification<T> self,
            int maxLength)
            where T : IEnumerable
        {
            var other = new MaxLengthSpecification<T>(maxLength, Specification.LinqToEntities);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="MinLengthSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is not lower than or equal to (is greater than) Max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="maxLength">Not maximum candidate length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotMaxLength<T>([NotNull] this ISpecification<T> self,
            int maxLength)
            where T : IEnumerable
        {
            var other = new MaxLengthSpecification<T>(maxLength, Specification.LinqToEntities).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="LengthBetweenSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is between Min and Max values.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="minLength">Minimum candidate length.</param>
        /// <param name="maxLength">Maximum candidate length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> LengthBetween<T>([NotNull] this ISpecification<T> self,
            int minLength,
            int maxLength)
            where T : IEnumerable
        {
            var other = new LengthBetweenSpecification<T>(minLength, maxLength, Specification.LinqToEntities);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="LengthBetweenSpecification{T}" />
        ///         negation:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is not between Min and Max values.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="minLength">Not minimum candidate length.</param>
        /// <param name="maxLength">Not maximum candidate length.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLengthBetween<T>([NotNull] this ISpecification<T> self,
            int minLength,
            int maxLength)
            where T : IEnumerable
        {
            var other = new LengthBetweenSpecification<T>(minLength, maxLength, Specification.LinqToEntities).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="LessThanSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is lower than expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="lessThan">Candidate should be less than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> LessThan<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T lessThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            var other = new LessThanSpecification<T>(lessThan, comparer);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="LessThanSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not lower than (greater than or equal to) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="notLessThan">Candidate should not be less than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLessThan<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T notLessThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            var other = new LessThanSpecification<T>(notLessThan, comparer).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="LessThanOrEqualSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is lower than or equal to expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="lessThan">Candidate should be less than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> LessThanOrEqual<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T lessThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            var other = new LessThanOrEqualSpecification<T>(lessThan, comparer);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="LessThanOrEqualSpecification{T}" />
        ///         negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not lower than or equal to (greater than) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="notLessThan">Candidate should not be less than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLessThanOrEqual<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T notLessThan, [CanBeNull] IComparer<T> comparer = null)
        {
            var other = new LessThanOrEqualSpecification<T>(notLessThan, comparer).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="GreaterThanSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is greater than expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="greaterThan">Candidate should be greater than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> GreaterThan<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T greaterThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            var other = new GreaterThanSpecification<T>(greaterThan, comparer);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="GreaterThanSpecification{T}" />
        ///         negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not greater than (lower than or equal to) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="notGreaterThan">Candidate should not be greater than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotGreaterThan<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T notGreaterThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            var other = new GreaterThanSpecification<T>(notGreaterThan, comparer).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="GreaterThanOrEqualSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is greater than or equal to expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="greaterThan">Candidate should be greater than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> GreaterThanOrEqual<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T greaterThan, [CanBeNull] IComparer<T> comparer = null)
        {
            var other = new GreaterThanOrEqualSpecification<T>(greaterThan, comparer);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="GreaterThanOrEqualSpecification{T}" />
        ///         negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not greater than or equal to (lower than) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="notGreaterThan">Candidate should not be greater than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotGreaterThanOrEqual<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T notGreaterThan, [CanBeNull] IComparer<T> comparer = null)
        {
            var other = new GreaterThanOrEqualSpecification<T>(notGreaterThan, comparer).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="MatchSpecification" />:
        ///     </para>
        ///     <para>
        ///         Checks if string candidate match a given Regex pattern.
        ///     </para>
        /// </summary>
        /// <param name="self">Self specification.</param>
        /// <param name="pattern">Regex pattern.</param>
        /// <param name="options">Regex matching options.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="pattern" /> is null or empty.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> Match([NotNull] this ISpecification<string> self,
            [NotNull] string pattern,
            RegexOptions options = RegexOptions.None)
        {
            var other = new MatchSpecification(pattern, options);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="MatchSpecification" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if string candidate not match a given Regex pattern.
        ///     </para>
        /// </summary>
        /// <param name="self">Self specification.</param>
        /// <param name="pattern">Regex pattern.</param>
        /// <param name="options">Regex matching options.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="pattern" /> is null or empty.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> NotMatch([NotNull] this ISpecification<string> self,
            [NotNull] string pattern,
            RegexOptions options = RegexOptions.None)
        {
            var other = new MatchSpecification(pattern, options).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="EmailSpecification" />:
        ///     </para>
        ///     <para>
        ///         Checks if string is valid email address.
        ///     </para>
        /// </summary>
        /// <param name="self">Self specification.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> Email([NotNull] this ISpecification<string> self)
        {
            var other = new EmailSpecification();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="EmailSpecification" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if string is not valid email address.
        ///     </para>
        /// </summary>
        /// <param name="self">Self specification.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> NotEmail([NotNull] this ISpecification<string> self)
        {
            var other = new EmailSpecification().Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="ExclusiveBetweenSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is between (exclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="from">Min candidate value.</param>
        /// <param name="to">Max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="from" /> is greater than <paramref name="to" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> ExclusiveBetween<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T from, [CanBeNull] T to,
            [CanBeNull] IComparer<T> comparer = null)
        {
            var other = new ExclusiveBetweenSpecification<T>(from, to, comparer);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="ExclusiveBetweenSpecification{T}" />
        ///         negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not between (exclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="notFrom">Not min candidate value.</param>
        /// <param name="notTo">Not max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="notFrom" /> is greater than <paramref name="notTo" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotExclusiveBetween<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T notFrom,
            [CanBeNull] T notTo, [CanBeNull] IComparer<T> comparer = null)
        {
            var other = new ExclusiveBetweenSpecification<T>(notFrom, notTo, comparer).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="InclusiveBetweenSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is between (inclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="from">Min candidate value.</param>
        /// <param name="to">Max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="from" /> is greater than <paramref name="to" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> InclusiveBetween<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T from, [CanBeNull] T to,
            [CanBeNull] IComparer<T> comparer = null)
        {
            var other = new InclusiveBetweenSpecification<T>(from, to, comparer);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="InclusiveBetweenSpecification{T}" />
        ///         negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not between (inclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="notFrom">Not min candidate value.</param>
        /// <param name="notTo">Not max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="notFrom" /> is greater than <paramref name="notTo" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotInclusiveBetween<T>([NotNull] this ISpecification<T> self,
            [CanBeNull] T notFrom,
            [CanBeNull] T notTo, IComparer<T> comparer = null)
        {
            var other = new InclusiveBetweenSpecification<T>(notFrom, notTo, comparer).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="CreditCardSpecification" />:
        ///     </para>
        ///     <para>
        ///         Checks if string is valid credit card number.
        ///     </para>
        /// </summary>
        /// <param name="self">Self specification.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> CreditCard([NotNull] this ISpecification<string> self)
        {
            var other = new CreditCardSpecification();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="CreditCardSpecification" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if string is not valid credit card number.
        ///     </para>
        /// </summary>
        /// <param name="self">Self specification.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> NotCreditCard([NotNull] this ISpecification<string> self)
        {
            var other = new CreditCardSpecification().Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="AllSpecification{T, TType}" />:
        ///     </para>
        ///     <para>
        ///         Checks if <see cref="ISpecification{TType}" /> is satisfied by ALL elements in candidate collection.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Collection type to iterate (<see cref="IEnumerable{TType}" />).</typeparam>
        /// <typeparam name="TType">Type of collection element to verify.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="allSpecification">Specification for candidate one element.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> All<T, TType>([NotNull] this ISpecification<T> self,
            [NotNull] ISpecification<TType> allSpecification)
            where T : IEnumerable<TType>
        {
            var other = new AllSpecification<T, TType>(allSpecification, Specification.LinqToEntities);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> All<T, TType>([NotNull] this ISpecification<T> self,
            [NotNull] Func<ISpecification<TType>, ISpecification<TType>> creator)
            where T : IEnumerable<TType>
        {
            var allSpecification = creator(Specification.For<TType>());
            var other = new AllSpecification<T, TType>(allSpecification, Specification.LinqToEntities);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="AnySpecification{T, TType}" />:
        ///     </para>
        ///     <para>
        ///         Checks if <see cref="ISpecification{TType}" /> is satisfied by ANY element in candidate collection.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Collection type to iterate (<see cref="IEnumerable{TType}" />).</typeparam>
        /// <typeparam name="TType">Type of collection element to verify.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="anySpecification">Specification for candidate one element.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Any<T, TType>([NotNull] this ISpecification<T> self,
            [NotNull] ISpecification<TType> anySpecification)
            where T : IEnumerable<TType>
        {
            var other = new AnySpecification<T, TType>(anySpecification, Specification.LinqToEntities);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Any<T, TType>([NotNull] this ISpecification<T> self,
            [NotNull] Func<ISpecification<TType>, ISpecification<TType>> creator)
            where T : IEnumerable<TType>
        {
            var anySpecification = creator(Specification.For<TType>());
            var other = new AnySpecification<T, TType>(anySpecification, Specification.LinqToEntities);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="TrueSpecification" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is True.
        ///     </para>
        /// </summary>
        /// <param name="self">Self specification.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<bool> True([NotNull] this ISpecification<bool> self)
        {
            var other = new TrueSpecification();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="FalseSpecification" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is False.
        ///     </para>
        /// </summary>
        /// <param name="self">Self specification.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<bool> False([NotNull] this ISpecification<bool> self)
        {
            var other = new FalseSpecification();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="IsTypeSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is compatible with a given type.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate property to verification.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="expected">Expected type of candidate property.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="expected" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> IsType<T>([NotNull] this ISpecification<T> self,
            [NotNull] Type expected)
        {
            var other = new IsTypeSpecification<T>(expected);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="IsTypeSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is not compatible with a given type.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate property to verification.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="notExpected">Not expected type of candidate property.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="notExpected" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> IsNotType<T>([NotNull] this ISpecification<T> self,
            [NotNull] Type notExpected)
        {
            var other = new IsTypeSpecification<T>(notExpected).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="ContainsSpecification{T, TType}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate contains expected element.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate (collection)</typeparam>
        /// <typeparam name="TType">Type of expected element in collection.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="expected">Expected element in collection.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Contains<T, TType>([NotNull] this ISpecification<T> self,
            [CanBeNull] TType expected,
            [CanBeNull] IEqualityComparer<TType> comparer = null)
            where T : IEnumerable<TType>
        {
            var other = new ContainsSpecification<T, TType>(expected, comparer, Specification.LinqToEntities);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="ContainsSpecification{T, TType}" />
        ///         negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate not contains expected element.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate (collection)</typeparam>
        /// <typeparam name="TType">Type of expected element in collection.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="notExpected">Not expected element in collection.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotContains<T, TType>([NotNull] this ISpecification<T> self,
            [CanBeNull] TType notExpected,
            [CanBeNull] IEqualityComparer<TType> comparer = null)
            where T : IEnumerable<TType>
        {
            var other = new ContainsSpecification<T, TType>(notExpected, comparer, Specification.LinqToEntities).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="ContainsSpecification" />:
        ///     </para>
        ///     <para>
        ///         Checks if string contains another string (case sensitive).
        ///     </para>
        /// </summary>
        /// <param name="self">Self specification.</param>
        /// <param name="expected">Expected substring.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> Contains([NotNull] this ISpecification<string> self,
            [NotNull] string expected)
        {
            var other = new ContainsSpecification(expected);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="ContainsSpecification" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if string not contains another string (case sensitive).
        ///     </para>
        /// </summary>
        /// <param name="self">Self specification.</param>
        /// <param name="notExpected">Not expected substring.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> NotContains([NotNull] this ISpecification<string> self,
            [NotNull] string notExpected)
        {
            var other = new ContainsSpecification(notExpected).Not();
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Composes <paramref name="self" /> <c>Specification</c> with <see cref="CastSpecification{T, TCast}" />:
        ///     </para>
        ///     <para>
        ///         Converts <c>Specification</c> (candidate to verification)
        ///         from <typeparamref name="T" /> to <typeparamref name="TCast" />.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify.</typeparam>
        /// <typeparam name="TCast">Type of candidate to verify after cast.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="specification">Specification to convert.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="specification" /> is null.</exception>
        /// <exception cref="InvalidOperationException">
        ///     Thrown when there is no conversion between
        ///     <typeparamref name="T" /> and <typeparamref name="TCast" />.
        /// </exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Cast<T, TCast>([NotNull] this ISpecification<T> self,
            [NotNull] ISpecification<TCast> specification)
        {
            var other = new CastSpecification<T, TCast>(specification);
            return self
                .Join(other)
                .AsComplexSpecification();
        }

        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Cast<T, TCast>([NotNull] this ISpecification<T> self,
            [NotNull] Func<ISpecification<TCast>, ISpecification<TCast>> creator)
        {
            var specification = creator(Specification.For<TCast>());
            var other = new CastSpecification<T, TCast>(specification);
            return self
                .Join(other)
                .AsComplexSpecification();
        }
    }
}