using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using FluentSpecification.Core;
using FluentSpecification.Integration.Tests.Data;

namespace FluentSpecification.Integration.Tests.Logic
{
    internal sealed class NameContainsSpecification :
        ComplexSpecification<Event>
    {
        private readonly MethodInfo _contains;
        private readonly string _filter;

        public NameContainsSpecification(string filter)
        {
            _filter = filter;
            _contains = typeof(string).GetMethod(nameof(string.Contains), new[] {typeof(string)});
        }

        protected override string CreateFailedMessage(Event candidate)
        {
            return $"Item [{candidate?.Name}] not contains: [{_filter}]";
        }

        protected override string CreateNegationFailedMessage(Event candidate)
        {
            return $"Item [{candidate?.Name}] contains: [{_filter}]";
        }

        protected override IReadOnlyDictionary<string, object> GetParameters()
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