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
    /// <summary>
    ///     API entry point.
    /// </summary>
    [PublicAPI]
    public static partial class Specification
    {
        /// <summary>
        ///     Global switch if <c>Linq Expressions</c> should be build for <c>LinqToEntities</c>.
        /// </summary>
        [PublicAPI]
        public static bool LinqToEntities { get; set; }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="AndSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Join <c>Specifications</c> by logical AND.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify.</typeparam>
        /// <param name="left">Base first <c>Specification</c>.</param>
        /// <param name="right">Base second <c>Specification</c>.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="left" /> or <paramref name="right" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> And<T>([NotNull] ISpecification<T> left,
            [NotNull] ISpecification<T> right)
        {
            return new AndSpecification<T>(left, right);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="AndSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Join <c>Specifications</c> by logical AND. Second <c>Specifications</c> is negated.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify.</typeparam>
        /// <param name="left">Base first <c>Specification</c>.</param>
        /// <param name="right">Base second <c>Specification</c>.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="left" /> or <paramref name="right" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> AndNot<T>([NotNull] ISpecification<T> left,
            [NotNull] ISpecification<T> right)
        {
            return new AndSpecification<T>(left, right.Not());
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="OrSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Join <c>Specifications</c> by logical OR.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify.</typeparam>
        /// <param name="left">Base first <c>Specification</c>.</param>
        /// <param name="right">Base second <c>Specification</c>.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="left" /> or <paramref name="right" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Or<T>([NotNull] ISpecification<T> left,
            [NotNull] ISpecification<T> right)
        {
            return new OrSpecification<T>(left, right);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="OrSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Join <c>Specifications</c> by logical OR. Second <c>Specifications</c> is negated.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify.</typeparam>
        /// <param name="left">Base first <c>Specification</c>.</param>
        /// <param name="right">Base second <c>Specification</c>.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="left" /> or <paramref name="right" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> OrNot<T>([NotNull] ISpecification<T> left,
            [NotNull] ISpecification<T> right)
        {
            return new OrSpecification<T>(left, right.Not());
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ExpressionSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if external <c>Linq</c> <c>Expression</c> is satisfied by candidate.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify.</typeparam>
        /// <param name="expression">External <c>Expression</c>.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Expression<T>([NotNull] Expression<Func<T, bool>> expression)
        {
            return new ExpressionSpecification<T>(expression);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="PropertySpecification{T,TProperty}" />:
        ///     </para>
        ///     <para>
        ///         Verifies if <c>Specification</c> is satisfied by candidate property value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="specification">Specification to verify value of candidate property.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">
        ///     Thrown when <paramref name="selector" /> or <paramref name="specification" />
        ///     is null.
        /// </exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> ForProperty<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            [NotNull] ISpecification<TProperty> specification)
        {
            return new PropertySpecification<T, TProperty>(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="NullSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is null.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Null<T>()
        {
            return new NullSpecification<T>();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="NullSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is not null.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotNull<T>()
        {
            return new NullSpecification<T>().Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="EmptySpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is empty.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Empty<T>()
        {
            return new EmptySpecification<T>(LinqToEntities);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="EmptySpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is not empty.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotEmpty<T>()
        {
            return new EmptySpecification<T>(LinqToEntities).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="EqualSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is equal to expected object.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="expected">Expected object.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Equal<T>([CanBeNull] T expected,
            [CanBeNull] IEqualityComparer<T> comparer = null)
        {
            return new EqualSpecification<T>(expected, comparer);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="EqualSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not equal to expected object.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="notExpected">Not expected object.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotEqual<T>([CanBeNull] T notExpected,
            [CanBeNull] IEqualityComparer<T> comparer = null)
        {
            return new EqualSpecification<T>(notExpected, comparer).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LengthSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is equal to specific value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="length">Expected candidate length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Length<T>(int length)
            where T : IEnumerable
        {
            return new LengthSpecification<T>(length, LinqToEntities);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LengthSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is not equal to specific value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="length">Not expected candidate length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLength<T>(int length)
            where T : IEnumerable
        {
            return new LengthSpecification<T>(length, LinqToEntities).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="MinLengthSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is greater than or equal to Min value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="minLength">Minimum candidate length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> MinLength<T>(int minLength)
            where T : IEnumerable
        {
            return new MinLengthSpecification<T>(minLength, LinqToEntities);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="MinLengthSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is not greater than or equal to (is less than) Min value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="minLength">Not minimum candidate length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotMinLength<T>(int minLength)
            where T : IEnumerable
        {
            return new MinLengthSpecification<T>(minLength, LinqToEntities).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="MinLengthSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is lower than or equal to Max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="maxLength">Maximum candidate length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> MaxLength<T>(int maxLength)
            where T : IEnumerable
        {
            return new MaxLengthSpecification<T>(maxLength, LinqToEntities);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="MinLengthSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is not lower than or equal to (is greater than) Max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="maxLength">Not maximum candidate length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotMaxLength<T>(int maxLength)
            where T : IEnumerable
        {
            return new MaxLengthSpecification<T>(maxLength, LinqToEntities).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LengthBetweenSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is between Min and Max values.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="minLength">Minimum candidate length.</param>
        /// <param name="maxLength">Maximum candidate length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> LengthBetween<T>(int minLength, int maxLength)
            where T : IEnumerable
        {
            return new LengthBetweenSpecification<T>(minLength, maxLength, LinqToEntities);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LengthBetweenSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate is not between Min and Max values.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify (collection or string).</typeparam>
        /// <param name="minLength">Not minimum candidate length.</param>
        /// <param name="maxLength">Not maximum candidate length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLengthBetween<T>(int minLength, int maxLength)
            where T : IEnumerable
        {
            return new LengthBetweenSpecification<T>(minLength, maxLength, LinqToEntities).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LessThanSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is lower than expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="lessThan">Candidate should be less than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> LessThan<T>([CanBeNull] T lessThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            return new LessThanSpecification<T>(lessThan, comparer);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LessThanSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not lower than (greater than or equal to) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="notLessThan">Candidate should not be less than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLessThan<T>([CanBeNull] T notLessThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            return new LessThanSpecification<T>(notLessThan, comparer).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LessThanOrEqualSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is lower than or equal to expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="lessThan">Candidate should be less than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> LessThanOrEqual<T>([CanBeNull] T lessThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            return new LessThanOrEqualSpecification<T>(lessThan, comparer);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LessThanOrEqualSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not lower than or equal to (greater than) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="notLessThan">Candidate should not be less than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLessThanOrEqual<T>([CanBeNull] T notLessThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            return new LessThanOrEqualSpecification<T>(notLessThan, comparer).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="GreaterThanSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is greater than expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="greaterThan">Candidate should be greater than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> GreaterThan<T>([CanBeNull] T greaterThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            return new GreaterThanSpecification<T>(greaterThan, comparer);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="GreaterThanSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not greater than (lower than or equal to) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="notGreaterThan">Candidate should not be greater than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotGreaterThan<T>([CanBeNull] T notGreaterThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            return new GreaterThanSpecification<T>(notGreaterThan, comparer).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="GreaterThanOrEqualSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is greater than or equal to expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="greaterThan">Candidate should be greater than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> GreaterThanOrEqual<T>([CanBeNull] T greaterThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            return new GreaterThanOrEqualSpecification<T>(greaterThan, comparer);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="GreaterThanOrEqualSpecification{T}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not greater than or equal to (lower than) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="notGreaterThan">Candidate should not be greater than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotGreaterThanOrEqual<T>([CanBeNull] T notGreaterThan,
            [CanBeNull] IComparer<T> comparer = null)
        {
            return new GreaterThanOrEqualSpecification<T>(notGreaterThan, comparer).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="MatchSpecification" />:
        ///     </para>
        ///     <para>
        ///         Checks if string candidate match a given Regex pattern.
        ///     </para>
        /// </summary>
        /// <param name="pattern">Regex pattern.</param>
        /// <param name="options">Regex matching options.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="pattern" /> is null or empty.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> Match([NotNull] string pattern,
            RegexOptions options = RegexOptions.None)
        {
            return new MatchSpecification(pattern, options);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="MatchSpecification" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if string candidate not match a given Regex pattern.
        ///     </para>
        /// </summary>
        /// <param name="pattern">Regex pattern.</param>
        /// <param name="options">Regex matching options.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="pattern" /> is null or empty.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> NotMatch([NotNull] string pattern,
            RegexOptions options = RegexOptions.None)
        {
            return new MatchSpecification(pattern, options).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="EmailSpecification" />:
        ///     </para>
        ///     <para>
        ///         Checks if string is valid email address.
        ///     </para>
        /// </summary>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> Email()
        {
            return new EmailSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="EmailSpecification" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if string is not valid email address.
        ///     </para>
        /// </summary>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> NotEmail()
        {
            return new EmailSpecification().Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ExclusiveBetweenSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is between (exclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="from">Min candidate value.</param>
        /// <param name="to">Max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="from" /> is greater than <paramref name="to" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> ExclusiveBetween<T>([CanBeNull] T from, [CanBeNull] T to,
            [CanBeNull] IComparer<T> comparer = null)
        {
            return new ExclusiveBetweenSpecification<T>(from, to, comparer);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ExclusiveBetweenSpecification{T}" />negation :
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not between (exclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="notFrom">Not min candidate value.</param>
        /// <param name="notTo">Not max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="notFrom" /> is greater than <paramref name="notTo" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotExclusiveBetween<T>([CanBeNull] T notFrom, [CanBeNull] T notTo,
            [CanBeNull] IComparer<T> comparer = null)
        {
            return new ExclusiveBetweenSpecification<T>(notFrom, notTo, comparer).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="InclusiveBetweenSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is between (inclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="from">Min candidate value.</param>
        /// <param name="to">Max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="from" /> is greater than <paramref name="to" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> InclusiveBetween<T>([CanBeNull] T from, [CanBeNull] T to,
            [CanBeNull] IComparer<T> comparer = null)
        {
            return new InclusiveBetweenSpecification<T>(from, to, comparer);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="InclusiveBetweenSpecification{T}" />negation :
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not between (Inclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of compared objects.</typeparam>
        /// <param name="notFrom">Not min candidate value.</param>
        /// <param name="notTo">Not max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="notFrom" /> is greater than <paramref name="notTo" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotInclusiveBetween<T>([CanBeNull] T notFrom, [CanBeNull] T notTo,
            [CanBeNull] IComparer<T> comparer = null)
        {
            return new InclusiveBetweenSpecification<T>(notFrom, notTo, comparer).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="CreditCardSpecification" />:
        ///     </para>
        ///     <para>
        ///         Checks if string is valid credit card number.
        ///     </para>
        /// </summary>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> CreditCard()
        {
            return new CreditCardSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="CreditCardSpecification" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if string is not valid credit card number.
        ///     </para>
        /// </summary>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> NotCreditCard()
        {
            return new CreditCardSpecification().Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="AllSpecification{T, TType}" />:
        ///     </para>
        ///     <para>
        ///         Checks if <see cref="ISpecification{TType}" /> is satisfied by ALL elements in candidate collection.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Collection type to iterate (<see cref="IEnumerable{TType}" />).</typeparam>
        /// <typeparam name="TType">Type of collection element to verify.</typeparam>
        /// <param name="allSpecification">Specification for candidate one element.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> All<T, TType>([NotNull] ISpecification<TType> allSpecification)
            where T : IEnumerable<TType>
        {
            return new AllSpecification<T, TType>(allSpecification, LinqToEntities);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="AnySpecification{T, TType}" />:
        ///     </para>
        ///     <para>
        ///         Checks if <see cref="ISpecification{TType}" /> is satisfied by ANY element in candidate collection.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Collection type to iterate (<see cref="IEnumerable{TType}" />).</typeparam>
        /// <typeparam name="TType">Type of collection element to verify.</typeparam>
        /// <param name="anySpecification">Specification for candidate one element.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Any<T, TType>([NotNull] ISpecification<TType> anySpecification)
            where T : IEnumerable<TType>
        {
            return new AnySpecification<T, TType>(anySpecification, LinqToEntities);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="TrueSpecification" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is True.
        ///     </para>
        /// </summary>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<bool> True()
        {
            return new TrueSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="TrueSpecification" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is False.
        ///     </para>
        /// </summary>
        /// <returns>New complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<bool> False()
        {
            return new FalseSpecification();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="IsTypeSpecification{T}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is compatible with a given type.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verification.</typeparam>
        /// <param name="expected">Expected type of candidate.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="expected" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> IsType<T>([NotNull] Type expected)
        {
            return new IsTypeSpecification<T>(expected);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="IsTypeSpecification{TProperty}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate is not compatible with a given type.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verification.</typeparam>
        /// <param name="notExpected">Not expected type of candidate.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="notExpected" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> IsNotType<T>([NotNull] Type notExpected)
        {
            return new IsTypeSpecification<T>(notExpected).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ContainsSpecification{T, TType}" />:
        ///     </para>
        ///     <para>
        ///         Checks if candidate contains expected element.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate (collection)</typeparam>
        /// <typeparam name="TType">Type of expected element in collection.</typeparam>
        /// <param name="expected">Expected element in collection.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Contains<T, TType>([CanBeNull] TType expected,
            [CanBeNull] IEqualityComparer<TType> comparer = null)
            where T : IEnumerable<TType>
        {
            return new ContainsSpecification<T, TType>(expected, comparer, LinqToEntities);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ContainsSpecification{T, TType}" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if candidate not contains expected element.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate (collection)</typeparam>
        /// <typeparam name="TType">Type of expected element in collection.</typeparam>
        /// <param name="notExpected">Not expected element in collection.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotContains<T, TType>([CanBeNull] TType notExpected,
            [CanBeNull] IEqualityComparer<TType> comparer = null)
            where T : IEnumerable<TType>
        {
            return new ContainsSpecification<T, TType>(notExpected, comparer, LinqToEntities).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ContainsSpecification" />:
        ///     </para>
        ///     <para>
        ///         Checks if string contains another string (case sensitive).
        ///     </para>
        /// </summary>
        /// <param name="expected">Expected substring.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> Contains([NotNull] string expected)
        {
            return new ContainsSpecification(expected);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ContainsSpecification" /> negation:
        ///     </para>
        ///     <para>
        ///         Checks if string not contains another string (case sensitive).
        ///     </para>
        /// </summary>
        /// <param name="notExpected">Not expected substring.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<string> NotContains([NotNull] string notExpected)
        {
            return new ContainsSpecification(notExpected).Not();
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="CastSpecification{T, TCast}" />:
        ///     </para>
        ///     <para>
        ///         Converts <c>Specification</c> (candidate to verification)
        ///         from <typeparamref name="T" /> to <typeparamref name="TCast" />.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate to verify.</typeparam>
        /// <typeparam name="TCast">Type of candidate to verify after cast.</typeparam>
        /// <param name="specification">Specification to convert.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="specification" /> is null.</exception>
        /// <exception cref="InvalidOperationException">
        ///     Thrown when there is no conversion between
        ///     <typeparamref name="T" /> and <typeparamref name="TCast" />.
        /// </exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Cast<T, TCast>([NotNull] ISpecification<TCast> specification)
        {
            return new CastSpecification<T, TCast>(specification);
        }
    }
}