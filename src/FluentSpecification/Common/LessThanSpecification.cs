using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Common.Abstractions;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if candidate object is lower than expected value.
    /// </summary>
    /// <remarks>
    ///     <c>Specification</c> for comparison use:
    ///     <list type="number">
    ///         <item>
    ///             <term>Comparer</term><description><see cref="IComparer{T}" /> - if available.</description>
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
    public sealed class LessThanSpecification<T> :
        BaseLessCompareSpecification<T>
    {
        /// <summary>
        ///     Creates <c>Specification</c> for candidate value comparison.
        /// </summary>
        /// <param name="lessThan">Candidate should be less than value.</param>
        /// <param name="comparer">Comparer.</param>
        /// <exception cref="ArgumentException">Thrown when <typeparamref name="T" /> has no valid comparison methods.</exception>
        [PublicAPI]
        public LessThanSpecification([CanBeNull] T lessThan, [CanBeNull] IComparer<T> comparer = null) :
            base(lessThan, Expression.LessThan, comparer)
        {
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(T candidate)
        {
            return $"Object is greater than or equal to [{(object) Limit ?? "null"}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateNegationFailedMessage(T candidate)
        {
            return $"Object is lower than [{(object) Limit ?? "null"}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBodyWithoutLimit(Expression arg)
        {
            return Expression.Constant(false);
        }
    }
}