using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if string is valid email address.
    /// </summary>
    [PublicAPI]
    public sealed class EmailSpecification :
        ComplexSpecification<string>,
        IFailableSpecification<string>,
        IFailableNegatableSpecification<string>
    {
        private const string Pattern =
            @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

        private readonly MatchSpecification _matchSpecification;

        /// <summary>
        ///     Basic constructor.
        /// </summary>
        [PublicAPI]
        public EmailSpecification()
        {
            _matchSpecification = new MatchSpecification(Pattern);
        }

        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedMessage(string candidate)
        {
            return "String is invalid email";
        }

        /// <inheritdoc />
        [PublicAPI]
        public string GetFailedNegationMessage(string candidate)
        {
            return "String is valid email";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            var matchExpression = _matchSpecification.GetExpression();
            var expression =
                ExpressionParameterRebinder.ReplaceParameters(new Dictionary<ParameterExpression, Expression>
                    {
                        {matchExpression.Parameters.First(), arg}
                    },
                    matchExpression.Body);
            return expression;
        }
    }
}