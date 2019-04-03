using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using FluentSpecification.Core;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if string contains another string (case sensitive).
    /// </summary>
    public sealed class ContainsSpecification :
        ComplexSpecification<string>
    {
        private readonly MethodInfo _containsMethodInfo;
        private readonly string _expected;

        /// <summary>
        ///     Basic constructor.
        /// </summary>
        /// <param name="expected">Expected substring.</param>
        public ContainsSpecification([NotNull] string expected)
        {
            if (string.IsNullOrEmpty(expected))
                throw new ArgumentNullException(nameof(expected));

            _expected = expected;
            _containsMethodInfo = typeof(string).GetMethod(nameof(string.Contains), new[] {typeof(string)});
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(string candidate)
        {
            return $"String not contains [{_expected}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateNegationFailedMessage(string candidate)
        {
            return $"String contains [{_expected}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"Expected", _expected}
            };
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            var checkNullExpression = Expression.NotEqual(arg, Expression.Constant(null, typeof(string)));
            var callExpression = Expression.Call(arg, _containsMethodInfo, Expression.Constant(_expected));

            var expression = Expression.AndAlso(checkNullExpression, callExpression);
            return expression;
        }
    }
}