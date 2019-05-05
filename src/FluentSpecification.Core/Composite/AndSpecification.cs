using System;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Composite
{
    /// <summary>
    ///     Join <c>Specifications</c> as logical AND.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public sealed class AndSpecification<T> : CompositeSpecification<T>
    {
        /// <summary>
        ///     Creates composite object.
        /// </summary>
        /// <param name="left">Base first <c>Expression</c>.</param>
        /// <param name="right">Base second <c>Expression</c>.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="left" /> or <paramref name="right" /> is null.</exception>
        [PublicAPI]
        public AndSpecification([NotNull] ISpecification<T> left, [NotNull] ISpecification<T> right)
            : base(left, right, Expression.AndAlso)
        {
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string TraceMessageConnector { get; } = "And";

        /// <inheritdoc />
        [PublicAPI]
        protected override bool Merge(bool left, bool right)
        {
            return left && right;
        }
    }
}