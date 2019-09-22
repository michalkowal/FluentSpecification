using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if candidate is True.
    /// </summary>
    [PublicAPI]
    public sealed class TrueSpecification : 
        ComplexSpecification<bool>,
        IFailableSpecification<bool>,
        IFailableNegatableSpecification<bool>
    {
        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedMessage(bool candidate)
        {
            return "Value is False";
        }

        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedNegationMessage(bool candidate)
        {
            return "Value is True";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            var expression = arg;
            return expression;
        }
    }
}