using System;
using System.Collections.Generic;
using FluentSpecification.Common.Abstractions;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if candidate object is between (exclusive) min and max value.
    /// </summary>
    /// <remarks>
    ///     <c>Specification</c> for comparison use:
    ///     <list type="number">
    ///         <item>
    ///             <term>Comparer</term><description><see cref="IEqualityComparer{T}" /> - if available.</description>
    ///         </item>
    ///         <item>
    ///             <term>LessThan operator</term><description>if defined for <typeparamref name="T" />.</description>
    ///         </item>
    ///         <item>
    ///             <term>CompareTo() method</term>
    ///             <description>if <typeparamref name="T" /> implements <see cref="IComparable{T}" />.</description>
    ///         </item>
    ///         <item>
    ///             <term>CompareTo(Object) method</term>
    ///             <description>if <typeparamref name="T" /> implements <see cref="IComparable" />.</description>
    ///         </item>
    ///     </list>
    ///     <para>Note that null is always the lowest value.</para>
    /// </remarks>
    /// <typeparam name="T">Type of compared objects.</typeparam>
    [PublicAPI]
    public sealed class ExclusiveBetweenSpecification<T> :
        BaseBetweenSpecification<T>
    {
        /// <summary>
        ///     Creates <c>Specification</c> for candidate value comparison.
        /// </summary>
        /// <param name="from">Min candidate value.</param>
        /// <param name="to">Max candidate value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="from" /> is greater than <paramref name="to" />.</exception>
        [PublicAPI]
        public ExclusiveBetweenSpecification([CanBeNull] T from, [CanBeNull] T to,
            [CanBeNull] IComparer<T> comparer = null) :
            base(from, to, false, comparer)
        {
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(T candidate)
        {
            return $"Value is not between [{(object) From ?? "null"}] and [{(object) To ?? "null"}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateNegationFailedMessage(T candidate)
        {
            return $"Value is between [{(object) From ?? "null"}] and [{(object) To ?? "null"}]";
        }
    }
}