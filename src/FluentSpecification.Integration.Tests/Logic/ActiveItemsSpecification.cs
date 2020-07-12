using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core;
using FluentSpecification.Integration.Tests.Data;

namespace FluentSpecification.Integration.Tests.Logic
{
    internal sealed class ActiveItemsSpecification : 
        ComplexSpecification<Event>,
        IFailableSpecification<Event>,
        IFailableNegatableSpecification<Event>
    {
        public string GetFailedMessage(Event candidate)
        {
            return $"Item is archival: [{candidate?.Id}]";
        }

        public string GetFailedNegationMessage(Event candidate)
        {
            return $"Item is not archival: [{candidate?.Id}]";
        }

        protected override Expression BuildExpressionBody(Expression arg)
        {
            return Expression.Not(Expression.Property(arg, nameof(Event.IsArchival)));
        }
    }
}