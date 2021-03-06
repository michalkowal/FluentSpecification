﻿using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Core;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if candidate is True.
    /// </summary>
    [PublicAPI]
    public sealed class TrueSpecification
        : ComplexSpecification<bool>
    {
        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(bool candidate)
        {
            return "Value is False";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateNegationFailedMessage(bool candidate)
        {
            return "Value is True";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return null;
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