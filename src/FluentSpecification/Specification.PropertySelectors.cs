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
    public static partial class Specification
    {
        /// <summary>
        ///     <para>
        ///         Creates <see cref="AndSpecification{T}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Join property <c>Specifications</c> by logical AND.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="left">Base first <c>Specification</c>.</param>
        /// <param name="right">Base second <c>Specification</c>.</param>
        /// <returns>New complex <c>Specification</c> for candidate property.</returns>
        /// <exception cref="ArgumentNullException">
        ///     Thrown when <paramref name="selector" />, <paramref name="left" /> or
        ///     <paramref name="right" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> And<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector,
            [NotNull] ISpecification<TProperty> left, [NotNull] ISpecification<TProperty> right)
        {
            IComplexSpecification<TProperty> specification = new AndSpecification<TProperty>(left, right);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="AndSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Join property <c>Specifications</c> by logical AND. Second <c>Specifications</c> is negated.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="left">Base first <c>Specification</c>.</param>
        /// <param name="right">Base second <c>Specification</c>.</param>
        /// <returns>New complex <c>Specification</c> for candidate property.</returns>
        /// <exception cref="ArgumentNullException">
        ///     Thrown when <paramref name="selector" />, <paramref name="left" /> or
        ///     <paramref name="right" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> AndNot<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector,
            [NotNull] ISpecification<TProperty> left, [NotNull] ISpecification<TProperty> right)
        {
            IComplexSpecification<TProperty> specification = new AndSpecification<TProperty>(left, right.Not());
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="OrSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Join property <c>Specifications</c> by logical OR.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="left">Base first <c>Specification</c>.</param>
        /// <param name="right">Base second <c>Specification</c>.</param>
        /// <returns>New complex <c>Specification</c> for candidate property.</returns>
        /// <exception cref="ArgumentNullException">
        ///     Thrown when <paramref name="selector" />, <paramref name="left" /> or
        ///     <paramref name="right" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Or<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector,
            [NotNull] ISpecification<TProperty> left, [NotNull] ISpecification<TProperty> right)
        {
            IComplexSpecification<TProperty> specification = new OrSpecification<TProperty>(left, right);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="OrSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Join property <c>Specifications</c> by logical OR. Second <c>Specifications</c> is negated.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="left">Base first <c>Specification</c>.</param>
        /// <param name="right">Base second <c>Specification</c>.</param>
        /// <returns>New complex <c>Specification</c> for candidate property.</returns>
        /// <exception cref="ArgumentNullException">
        ///     Thrown when <paramref name="selector" />, <paramref name="left" /> or
        ///     <paramref name="right" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> OrNot<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector,
            [NotNull] ISpecification<TProperty> left, [NotNull] ISpecification<TProperty> right)
        {
            IComplexSpecification<TProperty> specification = new OrSpecification<TProperty>(left, right.Not());
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ExpressionSpecification{T}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if external <c>Linq</c> <c>Expression</c> is satisfied by candidate property.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="expression">External <c>Expression</c>.</param>
        /// <returns>New complex <c>Specification</c> for candidate property.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Expression<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            [NotNull] Expression<Func<TProperty, bool>> expression)
        {
            IComplexSpecification<TProperty> specification = new ExpressionSpecification<TProperty>(expression);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="NullSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is null.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>New complex <c>Specification</c> for candidate property.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Null<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector)
        {
            IComplexSpecification<TProperty> specification = new NullSpecification<TProperty>();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="NullSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not null.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>New complex <c>Specification</c> for candidate property.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotNull<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector)
        {
            var specification = new NullSpecification<TProperty>().Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="EmptySpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is empty.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>New complex <c>Specification</c> for candidate property.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Empty<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector)
        {
            IComplexSpecification<TProperty> specification = new EmptySpecification<TProperty>(LinqToEntities);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="EmptySpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not empty.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>New complex <c>Specification</c> for candidate property.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotEmpty<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector)
        {
            var specification = new EmptySpecification<TProperty>(LinqToEntities).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="EqualSpecification{TType}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is equal to expected object.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="expected">Expected object.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>New complex <c>Specification</c> for candidate property.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Equal<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector,
            [CanBeNull] TProperty expected, [CanBeNull] IEqualityComparer<TProperty> comparer = null)
        {
            IComplexSpecification<TProperty> specification = new EqualSpecification<TProperty>(expected, comparer);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="EqualSpecification{TType}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate object is not equal to expected object.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notExpected">Not expected object.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>New complex <c>Specification</c> for candidate property.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotEqual<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector,
            [CanBeNull] TProperty notExpected, [CanBeNull] IEqualityComparer<TProperty> comparer = null)
        {
            var specification = new EqualSpecification<TProperty>(notExpected, comparer).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LengthSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is equal to specific value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="length">Expected candidate property length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Length<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector,
            int length)
            where TProperty : IEnumerable
        {
            IComplexSpecification<TProperty> specification = new LengthSpecification<TProperty>(length, LinqToEntities);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LengthSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is not equal to specific value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="length">Not expected candidate property length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLength<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            int length)
            where TProperty : IEnumerable
        {
            var specification = new LengthSpecification<TProperty>(length, LinqToEntities).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="MinLengthSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is greater than or equal to Min value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="minLength">Minimum candidate property length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> MinLength<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            int minLength)
            where TProperty : IEnumerable
        {
            IComplexSpecification<TProperty> specification =
                new MinLengthSpecification<TProperty>(minLength, LinqToEntities);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="MinLengthSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is not greater than or equal to (is less than) Min value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="minLength">Not minimum candidate property length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotMinLength<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            int minLength)
            where TProperty : IEnumerable
        {
            var specification = new MinLengthSpecification<TProperty>(minLength, LinqToEntities).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="MaxLengthSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is lower than or equal to Max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="maxLength">Maximum candidate property length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> MaxLength<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            int maxLength)
            where TProperty : IEnumerable
        {
            IComplexSpecification<TProperty> specification =
                new MaxLengthSpecification<TProperty>(maxLength, LinqToEntities);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="MaxLengthSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is not lower than or equal to (is greater than) Max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="maxLength">Not maximum candidate property length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotMaxLength<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            int maxLength)
            where TProperty : IEnumerable
        {
            var specification = new MaxLengthSpecification<TProperty>(maxLength, LinqToEntities).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LengthBetweenSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is between Min and Max values.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="minLength">Minimum candidate property length.</param>
        /// <param name="maxLength">Maximum candidate property length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">
        ///     Thrown when <paramref name="maxLength" /> is lower than
        ///     <paramref name="minLength" />.
        /// </exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> LengthBetween<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            int minLength, int maxLength)
            where TProperty : IEnumerable
        {
            IComplexSpecification<TProperty> specification =
                new LengthBetweenSpecification<TProperty>(minLength, maxLength, LinqToEntities);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LengthBetweenSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if length of candidate property is not between Min and Max values.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify (collection or string).</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="minLength">Not minimum candidate property length.</param>
        /// <param name="maxLength">Not maximum candidate property length.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">
        ///     Thrown when <paramref name="maxLength" /> is lower than
        ///     <paramref name="minLength" />.
        /// </exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLengthBetween<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            int minLength, int maxLength)
            where TProperty : IEnumerable
        {
            var specification = new LengthBetweenSpecification<TProperty>(minLength, maxLength, LinqToEntities).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LessThanSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is lower than expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="lessThan">Candidate property should be less than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> LessThan<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector,
            [CanBeNull] TProperty lessThan, [CanBeNull] IComparer<TProperty> comparer = null)
        {
            IComplexSpecification<TProperty> specification = new LessThanSpecification<TProperty>(lessThan, comparer);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LessThanSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not lower than (greater than or equal to) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notLessThan">Candidate property should not be less than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLessThan<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            [CanBeNull] TProperty notLessThan, [CanBeNull] IComparer<TProperty> comparer = null)
        {
            var specification = new LessThanSpecification<TProperty>(notLessThan, comparer).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LessThanOrEqualSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is lower than or equal to expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="lessThan">Candidate property should be less than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> LessThanOrEqual<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            [CanBeNull] TProperty lessThan, [CanBeNull] IComparer<TProperty> comparer = null)
        {
            IComplexSpecification<TProperty> specification =
                new LessThanOrEqualSpecification<TProperty>(lessThan, comparer);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="LessThanOrEqualSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not lower than or equal to (greater than) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notLessThan">Candidate property should not be less than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotLessThanOrEqual<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            [CanBeNull] TProperty notLessThan, [CanBeNull] IComparer<TProperty> comparer = null)
        {
            var specification = new LessThanOrEqualSpecification<TProperty>(notLessThan, comparer).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="GreaterThanSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is greater than expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="greaterThan">Candidate property should be greater than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> GreaterThan<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            [CanBeNull] TProperty greaterThan, [CanBeNull] IComparer<TProperty> comparer = null)
        {
            IComplexSpecification<TProperty> specification =
                new GreaterThanSpecification<TProperty>(greaterThan, comparer);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="GreaterThanSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not greater than (lower than or equal to) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notGreaterThan">Candidate property should not be greater than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotGreaterThan<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            [CanBeNull] TProperty notGreaterThan, [CanBeNull] IComparer<TProperty> comparer = null)
        {
            var specification = new GreaterThanSpecification<TProperty>(notGreaterThan, comparer).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="GreaterThanOrEqualSpecification{TProperty}" /> candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is greater than or equal to expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="greaterThan">Candidate property should be greater than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> GreaterThanOrEqual<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            [CanBeNull] TProperty greaterThan, [CanBeNull] IComparer<TProperty> comparer = null)
        {
            IComplexSpecification<TProperty>
                specification = new GreaterThanOrEqualSpecification<TProperty>(greaterThan, comparer);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="GreaterThanOrEqualSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not greater than or equal to (lower than) expected value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notGreaterThan">Candidate property should not be greater than or equal to value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotGreaterThanOrEqual<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty notGreaterThan,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            var specification = new GreaterThanOrEqualSpecification<TProperty>(notGreaterThan, comparer).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="MatchSpecification" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string candidate property match a given Regex pattern.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="pattern">Regex pattern.</param>
        /// <param name="options">Regex matching options.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="pattern" /> is null or empty.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Match<T>([NotNull] Expression<Func<T, string>> selector,
            [NotNull] string pattern,
            RegexOptions options = RegexOptions.None)
        {
            IComplexSpecification<string> specification = new MatchSpecification(pattern, options);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="MatchSpecification" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string candidate property not match a given Regex pattern.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="pattern">Regex pattern.</param>
        /// <param name="options">Regex matching options.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="pattern" /> is null or empty.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotMatch<T>([NotNull] Expression<Func<T, string>> selector,
            [NotNull] string pattern,
            RegexOptions options = RegexOptions.None)
        {
            var specification = new MatchSpecification(pattern, options).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="EmailSpecification" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string is valid email address.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Email<T>([NotNull] Expression<Func<T, string>> selector)
        {
            IComplexSpecification<string> specification = new EmailSpecification();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="EmailSpecification" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string is not valid email address.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotEmail<T>([NotNull] Expression<Func<T, string>> selector)
        {
            var specification = new EmailSpecification().Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ExclusiveBetweenSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is between (exclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="from">Min candidate value.</param>
        /// <param name="to">Max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="from" /> is greater than <paramref name="to" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> ExclusiveBetween<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            [CanBeNull] TProperty from, [CanBeNull] TProperty to,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            IComplexSpecification<TProperty> specification =
                new ExclusiveBetweenSpecification<TProperty>(from, to, comparer);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ExclusiveBetweenSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not between (exclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notFrom">Not min candidate value.</param>
        /// <param name="notTo">Not max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="notFrom" /> is greater than <paramref name="notTo" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotExclusiveBetween<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty notFrom,
            [CanBeNull] TProperty notTo,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            var specification = new ExclusiveBetweenSpecification<TProperty>(notFrom, notTo, comparer).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="InclusiveBetweenSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is between (inclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="from">Min candidate value.</param>
        /// <param name="to">Max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="from" /> is greater than <paramref name="to" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> InclusiveBetween<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            [CanBeNull] TProperty from, [CanBeNull] TProperty to,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            IComplexSpecification<TProperty> specification =
                new InclusiveBetweenSpecification<TProperty>(from, to, comparer);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="InclusiveBetweenSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not between (inclusive) min and max value.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of compared objects.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notFrom">Not min candidate value.</param>
        /// <param name="notTo">Not max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="TProperty" /> has no valid comparison methods.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="notFrom" /> is greater than <paramref name="notTo" />.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotInclusiveBetween<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector, [CanBeNull] TProperty notFrom,
            [CanBeNull] TProperty notTo,
            [CanBeNull] IComparer<TProperty> comparer = null)
        {
            var specification = new InclusiveBetweenSpecification<TProperty>(notFrom, notTo, comparer).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="CreditCardSpecification" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string is valid credit card number.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> CreditCard<T>([NotNull] Expression<Func<T, string>> selector)
        {
            IComplexSpecification<string> specification = new CreditCardSpecification();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="CreditCardSpecification" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string is not valid credit card number.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotCreditCard<T>([NotNull] Expression<Func<T, string>> selector)
        {
            var specification = new CreditCardSpecification().Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="AllSpecification{TProperty, TPropertyType}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if <see cref="ISpecification{TPropertyType}" /> is satisfied by ALL elements in candidate property
        ///         collection.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TPropertyType">Type of collection element to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="allSpecification">Specification for candidate property one element.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> All<T, TPropertyType>(
            [NotNull] Expression<Func<T, IEnumerable<TPropertyType>>> selector,
            [NotNull] ISpecification<TPropertyType> allSpecification)
        {
            IComplexSpecification<IEnumerable<TPropertyType>> specification =
                new AllSpecification<IEnumerable<TPropertyType>, TPropertyType>(allSpecification, LinqToEntities);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="AnySpecification{TProperty, TPropertyType}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if <see cref="ISpecification{TPropertyType}" /> is satisfied by ANY element in candidate property
        ///         collection.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TPropertyType">Type of collection element to verify.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="anySpecification">Specification for candidate property one element.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Any<T, TPropertyType>(
            [NotNull] Expression<Func<T, IEnumerable<TPropertyType>>> selector,
            [NotNull] ISpecification<TPropertyType> anySpecification)
        {
            IComplexSpecification<IEnumerable<TPropertyType>> specification =
                new AnySpecification<IEnumerable<TPropertyType>, TPropertyType>(anySpecification, LinqToEntities);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="TrueSpecification" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is True.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> True<T>([NotNull] Expression<Func<T, bool>> selector)
        {
            IComplexSpecification<bool> specification = new TrueSpecification();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="FalseSpecification" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is False.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> False<T>([NotNull] Expression<Func<T, bool>> selector)
        {
            IComplexSpecification<bool> specification = new FalseSpecification();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="IsTypeSpecification{TProperty}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is compatible with a given type.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verification.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="expected">Expected type of candidate property.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="expected" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> IsType<T, TProperty>([NotNull] Expression<Func<T, TProperty>> selector,
            [NotNull] Type expected)
        {
            IComplexSpecification<TProperty> specification = new IsTypeSpecification<TProperty>(expected);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="IsTypeSpecification{TProperty}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property is not compatible with a given type.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verification.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notExpected">Not expected type of candidate property.</param>
        /// <returns>New complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="notExpected" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> IsNotType<T, TProperty>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            [NotNull] Type notExpected)
        {
            var specification = new IsTypeSpecification<TProperty>(notExpected).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ContainsSpecification{TProperty, TPropertyType}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property contains expected element.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TPropertyType">Type of expected element in collection.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="expected">Expected element in collection.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Contains<T, TPropertyType>(
            [NotNull] Expression<Func<T, IEnumerable<TPropertyType>>> selector,
            [CanBeNull] TPropertyType expected,
            [CanBeNull] IEqualityComparer<TPropertyType> comparer = null)
        {
            IComplexSpecification<IEnumerable<TPropertyType>> specification =
                new ContainsSpecification<IEnumerable<TPropertyType>, TPropertyType>(expected, comparer,
                    LinqToEntities);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ContainsSpecification{TProperty, TPropertyType}" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if candidate property not contains expected element.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TPropertyType">Type of expected element in collection.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notExpected">Not expected element in collection.</param>
        /// <param name="comparer">Equality comparer.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotContains<T, TPropertyType>(
            [NotNull] Expression<Func<T, IEnumerable<TPropertyType>>> selector,
            [CanBeNull] TPropertyType notExpected,
            [CanBeNull] IEqualityComparer<TPropertyType> comparer = null)
        {
            var specification =
                new ContainsSpecification<IEnumerable<TPropertyType>, TPropertyType>(notExpected, comparer,
                    LinqToEntities).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ContainsSpecification" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string contains another string (case sensitive).
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="expected">Expected substring.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Contains<T>([NotNull] Expression<Func<T, string>> selector,
            [NotNull] string expected)
        {
            IComplexSpecification<string> specification = new ContainsSpecification(expected);
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="ContainsSpecification" /> negation for candidate property:
        ///     </para>
        ///     <para>
        ///         Checks if string not contains another string (case sensitive).
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="notExpected">Not expected substring.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> NotContains<T>([NotNull] Expression<Func<T, string>> selector,
            [NotNull] string notExpected)
        {
            var specification = new ContainsSpecification(notExpected).Not();
            return ForProperty(selector, specification);
        }

        /// <summary>
        ///     <para>
        ///         Creates <see cref="CastSpecification{TProperty, TCast}" /> for candidate property:
        ///     </para>
        ///     <para>
        ///         Converts <c>Specification</c> (candidate property to verification)
        ///         from <typeparamref name="TProperty" /> to <typeparamref name="TCast" />.
        ///     </para>
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
        /// <typeparam name="TCast">Type of candidate to verify after cast.</typeparam>
        /// <param name="selector">Candidate property selector.</param>
        /// <param name="propertySpecification">Specification to convert.</param>
        /// <returns>Composed complex <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="selector" /> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="propertySpecification" /> is null.</exception>
        /// <exception cref="InvalidOperationException">
        ///     Thrown when there is no conversion between
        ///     <typeparamref name="TProperty" /> and <typeparamref name="TCast" />.
        /// </exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Cast<T, TProperty, TCast>(
            [NotNull] Expression<Func<T, TProperty>> selector,
            ISpecification<TCast> propertySpecification)
        {
            IComplexSpecification<TProperty> specification =
                new CastSpecification<TProperty, TCast>(propertySpecification);
            return ForProperty(selector, specification);
        }
    }
}