using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if external <c>Linq</c> <c>Expression</c> is satisfied by candidate.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public sealed class ExpressionSpecification<T> :
        ValidationSpecification<T>,
        IComplexSpecification<T>
    {
        private readonly Expression<Func<T, bool>> _expression;

        /// <summary>
        ///     Creates <c>Specification</c> for given <c>Linq</c> <c>Expression</c>.
        /// </summary>
        /// <param name="expression">External <c>Expression</c>.</param>
        [PublicAPI]
        public ExpressionSpecification([NotNull] Expression<Func<T, bool>> expression)
        {
            _expression = expression ?? throw new ArgumentNullException(nameof(expression));
        }

        /// <inheritdoc />
        [PublicAPI]
        public override bool IsSatisfiedBy(T candidate)
        {
            return _expression.Compile().Invoke(candidate);
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        [PublicAPI]
        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"Expression", _expression}
            };
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(T candidate)
        {
            return $"Specification doesn't meet expression: [{_expression}]";
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression{Func}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        public static implicit operator Expression<Func<T, bool>>(ExpressionSpecification<T> self)
        {
            return self?.GetExpression();
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        public static explicit operator Expression(ExpressionSpecification<T> self)
        {
            return ((ILinqSpecification) self)?.GetExpression();
        }
    }
}