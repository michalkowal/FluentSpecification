﻿using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;

[assembly: InternalsVisibleTo("FluentSpecification.Core.Tests")]

namespace FluentSpecification.Core
{
    /// <summary>
    ///     Extensions for <see cref="ISpecification{T}" />.
    /// </summary>
    [PublicAPI]
    public static class Specification
    {
        /// <summary>
        ///     Converts <c>Specification</c> to <see cref="Func{T,TResult}" /> predicate.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>
        ///     Function for candidate verification.
        /// </returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static Func<T, bool> AsPredicate<T>([NotNull] this ISpecification<T> self)
        {
            return self.IsSatisfiedBy;
        }

        /// <summary>
        ///     Converts <c>Specification</c> to <c>Linq</c> <see cref="Expression{T}" />.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>
        ///     <c>Linq</c> expression for candidate verification.
        /// </returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static Expression<Func<T, bool>> AsExpression<T>([NotNull] this ISpecification<T> self)
        {
            return self.AsComplexSpecification().GetExpression();
        }

        /// <summary>
        ///     Converts <c>Specification</c> to complex <c>Specification</c>.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>
        ///     <para>
        ///         Returns <paramref name="self" /> when <paramref name="self" /> already implement
        ///         <see cref="IComplexSpecification{T}" /> interface.
        ///     </para>
        ///     <para>Adapter object, when <c>Specification</c> is not "complex".</para>
        /// </returns>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> AsComplexSpecification<T>([NotNull] this ISpecification<T> self)
        {
            self = self ?? throw new NullReferenceException();
            var complexSpecification = self is IComplexSpecification<T> specification
                ? specification
                : new SpecificationAdapter<T>(self);

            return complexSpecification;
        }

        /// <summary>
        ///     Get short name of <c>Specification</c> type - without namespaces etc.
        /// </summary>
        /// <param name="specification">Get name of.</param>
        /// <returns>Short name of <paramref name="specification" />.</returns>
        /// <seealso cref="GetShortName" />
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="specification" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static string GetShortName([NotNull] this ISpecification specification)
        {
            specification = specification ?? throw new ArgumentNullException(nameof(specification));

            var specType = specification.GetType();

            var shortName = specType.GetShortName();

            return shortName;
        }

        [PublicAPI]
        public static SpecificationTrace GetTrace([NotNull] this ISpecification specification, bool result)
        {
            if (specification is ITraceableSpecification traceableSpecification)
                return traceableSpecification.GetTrace(result);

            var trace = specification.GetShortName();
            if (!result)
                trace += "+Failed";

            var shortTrace = trace.Replace("Specification", string.Empty);

            return new SpecificationTrace(trace, shortTrace);
        }

        /// <summary>
        ///     Creates logical AND <c>Specification</c>.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="other">Other specification.</param>
        /// <returns>And <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="other" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> And<T>([NotNull] this ISpecification<T> self,
            [NotNull] ISpecification<T> other)
        {
            return new AndSpecification<T>(self, other);
        }

        /// <summary>
        ///     Creates logical OR <c>Specification</c>.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="other">Other specification.</param>
        /// <returns>Or <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="other" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Or<T>([NotNull] this ISpecification<T> self,
            [NotNull] ISpecification<T> other)
        {
            return new OrSpecification<T>(self, other);
        }

        /// <summary>
        ///     Creates logical NOT <c>Specification</c>.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>Not <c>Specification</c>.</returns>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Not<T>([NotNull] this ISpecification<T> self)
        {
            return new NotSpecification<T>(self);
        }

        /// <summary>
        ///     Creates logical AND <c>Specification</c> with negated <paramref name="other" />.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="other">Other specification.</param>
        /// <returns>And <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="other" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> AndNot<T>([NotNull] this ISpecification<T> self,
            [NotNull] ISpecification<T> other)
        {
            return new AndSpecification<T>(self, other.Not());
        }

        /// <summary>
        ///     Creates logical OR <c>Specification</c> with negated <paramref name="other" />.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <param name="other">Other specification.</param>
        /// <returns>Or <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> or <paramref name="other" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> OrNot<T>([NotNull] this ISpecification<T> self,
            [NotNull] ISpecification<T> other)
        {
            return new OrSpecification<T>(self, other.Not());
        }

        /// <summary>
        ///     Creates logical AND <c>Specification</c> with newly created <typeparamref name="TSpecification" />.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// ///
        /// <typeparam name="TSpecification">Type of new <c>Specification</c>.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>And <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> And<T, TSpecification>([NotNull] this ISpecification<T> self)
            where TSpecification : ISpecification<T>, new()
        {
            var other = new TSpecification();
            return new AndSpecification<T>(self, other);
        }

        /// <summary>
        ///     Creates logical OR <c>Specification</c> with newly created <typeparamref name="TSpecification" />.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// ///
        /// <typeparam name="TSpecification">Type of new <c>Specification</c>.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>Or <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> Or<T, TSpecification>([NotNull] this ISpecification<T> self)
            where TSpecification : ISpecification<T>, new()
        {
            var other = new TSpecification();
            return new OrSpecification<T>(self, other);
        }

        /// <summary>
        ///     Creates logical AND <c>Specification</c> with newly created and negated <typeparamref name="TSpecification" />.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// ///
        /// <typeparam name="TSpecification">Type of new <c>Specification</c>.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>And <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> AndNot<T, TSpecification>([NotNull] this ISpecification<T> self)
            where TSpecification : ISpecification<T>, new()
        {
            var other = new TSpecification();
            return new AndSpecification<T>(self, other.Not());
        }

        /// <summary>
        ///     Creates logical OR <c>Specification</c> with newly created and negated <typeparamref name="TSpecification" />.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// ///
        /// <typeparam name="TSpecification">Type of new <c>Specification</c>.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>Or <c>Specification</c>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static IComplexSpecification<T> OrNot<T, TSpecification>([NotNull] this ISpecification<T> self)
            where TSpecification : ISpecification<T>, new()
        {
            var other = new TSpecification();
            return new OrSpecification<T>(self, other.Not());
        }

        /// <summary>
        ///     Creates composite <c>Specification</c> proxy for final logical AND <c>Specification</c>.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>Composite <c>Specification</c> proxy object.</returns>
        [PublicAPI]
        [NotNull]
        public static ICompositeSpecification<T> And<T>([NotNull] this ISpecification<T> self)
        {
            return new AndFluentProxy<T>(self);
        }

        /// <summary>
        ///     Creates composite <c>Specification</c> proxy for final logical OR <c>Specification</c>.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>Composite <c>Specification</c> proxy object.</returns>
        [PublicAPI]
        [NotNull]
        public static ICompositeSpecification<T> Or<T>([NotNull] this ISpecification<T> self)
        {
            return new OrFluentProxy<T>(self);
        }

        /// <summary>
        ///     Creates composite <c>Specification</c> proxy for final logical AND <c>Specification</c>.
        ///     Second <c>Specification</c> is negated.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>Composite <c>Specification</c> proxy object.</returns>
        [PublicAPI]
        [NotNull]
        public static ICompositeSpecification<T> AndNot<T>([NotNull] this ISpecification<T> self)
        {
            return new AndNotFluentProxy<T>(self);
        }

        /// <summary>
        ///     Creates composite <c>Specification</c> proxy for final logical OR <c>Specification</c>.
        ///     Second <c>Specification</c> is negated.
        /// </summary>
        /// <typeparam name="T">Type of candidate.</typeparam>
        /// <param name="self">Self specification.</param>
        /// <returns>Composite <c>Specification</c> proxy object.</returns>
        [PublicAPI]
        [NotNull]
        public static ICompositeSpecification<T> OrNot<T>([NotNull] this ISpecification<T> self)
        {
            return new OrNotFluentProxy<T>(self);
        }
    }
}