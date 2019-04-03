using System;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Composite
{
    /// <summary>
    ///     Join <c>Specifications</c> as logical OR.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public sealed class OrSpecification<T> : CompositeSpecification<T>
    {
        /// <summary>
        ///     Creates composite object.
        /// </summary>
        /// <param name="left">Base first <c>Expression</c>.</param>
        /// <param name="right">Base second <c>Expression</c>.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="left" /> or <paramref name="right" /> is null.</exception>
        [PublicAPI]
        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
            : base(left, right, Expression.OrElse)
        {
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string TraceMessageConnector { get; } = "Or";

        /// <inheritdoc />
        [PublicAPI]
        protected override bool Merge(bool left, bool right)
        {
            return left || right;
        }
    }
}