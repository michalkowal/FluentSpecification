using System;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Composite
{
    /// <summary>
    ///     Base implementation of <see cref="IComplexSpecification{T}" /> for composite <c>Specifications</c>
    ///     like And, Or.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public abstract partial class CompositeSpecification<T> :
        IComplexSpecification<T>
    {
        private readonly Expression<Func<T, bool>> _expression;
        private readonly bool _grouping;
        private readonly IComplexSpecification<T> _left;
        private readonly IComplexSpecification<T> _right;

        /// <summary>
        ///     Creates base composite object with correct <c>Linq</c> <c>Expression</c>.
        /// </summary>
        /// <param name="left">Base first <c>Expression</c>.</param>
        /// <param name="right">Base second <c>Expression</c>.</param>
        /// <param name="mergeExpression">Merge function.</param>
        /// <exception cref="ArgumentNullException">
        ///     Thrown when <paramref name="left" />, <paramref name="right" />
        ///     or <paramref name="mergeExpression" /> is null.
        /// </exception>
        [PublicAPI]
        protected CompositeSpecification([NotNull] ISpecification<T> left, [NotNull] ISpecification<T> right,
            [NotNull] Func<Expression, Expression, Expression> mergeExpression)
        {
            left = left ?? throw new ArgumentNullException(nameof(left));
            right = right ?? throw new ArgumentNullException(nameof(right));
            mergeExpression = mergeExpression ?? throw new ArgumentNullException(nameof(mergeExpression));

            _left = left.AsComplexSpecification();
            _right = right.AsComplexSpecification();
            _expression = ExpressionComposer.Compose(_left.GetExpression(), _right.GetExpression(), mergeExpression);
            _grouping = right is CompositeSpecification<T>;
        }

        /// <summary>
        ///     Merge results from <c>Specifications</c> passed in constructor.
        /// </summary>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <returns>
        ///     Overall result as composition of two <c>Specifications</c>.
        /// </returns>
        [PublicAPI]
        public bool IsSatisfiedBy(T candidate)
        {
            var leftSpecResult = _left.IsSatisfiedBy(candidate);
            var rightSpecResult = _right.IsSatisfiedBy(candidate);
            return Merge(leftSpecResult, rightSpecResult);
        }

        /// <summary>
        ///     Gets typed lambda <c>Linq</c> Expression with candidate object verification.
        ///     Expression is composed by two separate <c>Linq</c> Expressions, from <c>Specifications</c> passed in constructor.
        /// </summary>
        /// <returns>Strongly typed, composed lambda <c>Linq</c> Expression.</returns>
        [PublicAPI]
        public Expression<Func<T, bool>> GetExpression()
        {
            return _expression;
        }

        /// <inheritdoc />
        [PublicAPI]
        Expression ILinqSpecification.GetExpression()
        {
            return GetExpression();
        }

        /// <summary>
        ///     Gets overall merge result
        /// </summary>
        /// <param name="left">"Left" <c>Specification</c> result.</param>
        /// <param name="right">"Right" <c>Specification</c> result.</param>
        /// <returns>Overall <c>Specification</c> result.</returns>
        [PublicAPI]
        protected abstract bool Merge(bool left, bool right);

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression{Func}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static implicit operator Expression<Func<T, bool>>([NotNull] CompositeSpecification<T> self)
        {
            return self.GetExpression();
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Func{T, Boolean}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static implicit operator Func<T, bool>([NotNull] CompositeSpecification<T> self)
        {
            return self.IsSatisfiedBy;
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static explicit operator Expression([NotNull] CompositeSpecification<T> self)
        {
            return ((ILinqSpecification) self).GetExpression();
        }
    }
}