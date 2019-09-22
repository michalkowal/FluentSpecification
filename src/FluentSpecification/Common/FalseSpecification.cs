using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if candidate is False.
    /// </summary>
    [PublicAPI]
    public sealed class FalseSpecification : 
        ComplexSpecification<bool>,
        IFailableSpecification<bool>,
        IFailableNegatableSpecification<bool>
    {
        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedMessage(bool candidate)
        {
            return "Value is True";
        }

        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedNegationMessage(bool candidate)
        {
            return "Value is False";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            var expression = Expression.Not(arg);
            return expression;
        }
    }
}