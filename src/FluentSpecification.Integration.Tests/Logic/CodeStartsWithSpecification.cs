using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core;
using FluentSpecification.Integration.Tests.Data;

namespace FluentSpecification.Integration.Tests.Logic
{
    internal sealed class CodeStartsWithSpecification :
        ComplexSpecification<Event>,
        IFailableSpecification<Event>,
        IFailableNegatableSpecification<Event>,
        IParameterizedSpecification
    {
        private readonly string _code;
        private readonly MethodInfo _startsWith;

        public CodeStartsWithSpecification(string code)
        {
            _code = code;

            _startsWith = typeof(string).GetMethod(nameof(string.StartsWith), new[] {typeof(string)});
        }

        public string GetFailedMessage(Event candidate)
        {
            return $"Item code [{candidate?.Code}] is not starts by [{_code}]";
        }

        public string GetFailedNegationMessage(Event candidate)
        {
            return $"Item code [{candidate?.Code}] starts by [{_code}]";
        }

        public IReadOnlyDictionary<string, object> GetParameters()
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