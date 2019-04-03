using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using FluentSpecification.Core;
using FluentSpecification.Integration.Tests.Data;

namespace FluentSpecification.Integration.Tests.Logic
{
    internal sealed class CodeStartsWithSpecification :
        ComplexSpecification<Event>
    {
        private readonly string _code;
        private readonly MethodInfo _startsWith;

        public CodeStartsWithSpecification(string code)
        {
            _code = code;

            _startsWith = typeof(string).GetMethod(nameof(string.StartsWith), new[] {typeof(string)});
        }

        protected override string CreateFailedMessage(Event candidate)
        {
            return $"Item code [{candidate?.Code}] is not starts by [{_code}]";
        }

        protected override string CreateNegationFailedMessage(Event candidate)
        {
            return $"Item code [{candidate?.Code}] starts by [{_code}]";
        }

        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"Code", _code}
            };
        }

        protected override Expression BuildExpressionBody(Expression arg)
        {
            return Expression.Call(Expression.Property(arg, nameof(Event.Code)), _startsWith,
                Expression.Constant(_code, typeof(string)));
        }
    }
}