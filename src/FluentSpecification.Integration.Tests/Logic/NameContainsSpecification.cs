using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core;
using FluentSpecification.Integration.Tests.Data;

namespace FluentSpecification.Integration.Tests.Logic
{
    internal sealed class NameContainsSpecification :
        ComplexSpecification<Event>,
        IFailableSpecification<Event>,
        IFailableNegatableSpecification<Event>,
        IParameterizedSpecification
    {
        private readonly MethodInfo _contains;
        private readonly string _filter;

        public NameContainsSpecification(string filter)
        {
            _filter = filter;
            _contains = typeof(string).GetMethod(nameof(string.Contains), new[] {typeof(string)});
        }

        public string GetFailedMessage(Event candidate)
        {
            return $"Item [{candidate?.Name}] not contains: [{_filter}]";
        }

        public string GetFailedNegationMessage(Event candidate)
        {
            return $"Item [{candidate?.Name}] contains: [{_filter}]";
        }

        public IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"Filter", _filter}
            };
        }

        protected override Expression BuildExpressionBody(Expression arg)
        {
            return Expression.Call(Expression.Property(arg, nameof(Event.Name)), _contains,
                Expression.Constant(_filter, typeof(string)));
        }
    }
}