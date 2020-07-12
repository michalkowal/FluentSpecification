using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core;
using FluentSpecification.Integration.Tests.Data;

namespace FluentSpecification.Integration.Tests.Logic
{
    internal sealed class ItemBigIdSpecification : 
        ComplexSpecification<Event>,
        IFailableSpecification<Event>,
        IFailableNegatableSpecification<Event>
    {
        private const int BaseId = 100;

        public string GetFailedMessage(Event candidate)
        {
            return $"Item Id is lower than {BaseId}";
        }

        public string GetFailedNegationMessage(Event candidate)
        {
            return $"Item Id is greater than or equal to {BaseId}";
        }

        protected override Expression BuildExpressionBody(Expression arg)
        {
            return Expression.GreaterThanOrEqual(Expression.Property(arg, nameof(Event.Id)),
                Expression.Constant(BaseId));
        }
    }
}