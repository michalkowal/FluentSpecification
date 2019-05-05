using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Core;
using FluentSpecification.Integration.Tests.Data;

namespace FluentSpecification.Integration.Tests.Logic
{
    internal sealed class ActiveItemsSpecification
        : ComplexSpecification<Event>
    {
        protected override string CreateFailedMessage(Event candidate)
        {
            return $"Item is archival: [{candidate?.Id}]";
        }

        protected override string CreateNegationFailedMessage(Event candidate)
        {
            return $"Item is not archival: [{candidate?.Id}]";
        }

        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return null;
        }

        protected override Expression BuildExpressionBody(Expression arg)
        {
            return Expression.Not(Expression.Property(arg, nameof(Event.IsArchival)));
        }
    }
}