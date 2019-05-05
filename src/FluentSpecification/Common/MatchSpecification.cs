using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using FluentSpecification.Core;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if string candidate match a given Regex pattern.
    /// </summary>
    [PublicAPI]
    public sealed class MatchSpecification :
        ComplexSpecification<string>
    {
        private readonly MethodInfo _isMatchMethodInfo;
        private readonly RegexOptions _options;
        private readonly string _pattern;

        /// <summary>
        ///     Creates <c>Specification</c> for given pattern.
        /// </summary>
        /// <param name="regexPattern">Regex pattern.</param>
        /// <param name="options">Regex matching options.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="regexPattern" /> is null or empty.</exception>
        [PublicAPI]
        public MatchSpecification([NotNull] string regexPattern, RegexOptions options = RegexOptions.None)
        {
            if (string.IsNullOrEmpty(regexPattern))
                throw new ArgumentException("Incorrect Regex pattern", nameof(regexPattern));

            _pattern = regexPattern;
            _options = options;

            _isMatchMethodInfo = typeof(Regex).GetTypeInfo()
                .GetDeclaredMethods(nameof(Regex.IsMatch))
                .First(m => m.GetParameters().Length == 3 &&
                            m.GetParameters()[0].ParameterType == typeof(string) &&
                            m.GetParameters()[1].ParameterType == typeof(string) &&
                            m.GetParameters()[2].ParameterType == typeof(RegexOptions));
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(string candidate)
        {
            return $"String not match pattern [{_pattern}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateNegationFailedMessage(string candidate)
        {
            return $"String match pattern [{_pattern}]";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"Pattern", _pattern}
            };
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            var checkNullExpression = Expression.NotEqual(arg, Expression.Constant(null, typeof(string)));

            var isMatchExpression = Expression.Call(_isMatchMethodInfo, arg,
                Expression.Constant(_pattern), Expression.Constant(_options));

            var expression = Expression.AndAlso(checkNullExpression, isMatchExpression);

            return expression;
        }
    }
}