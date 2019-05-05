using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Core;
using FluentSpecification.Integration.Tests.Data;

namespace FluentSpecification.Integration.Tests.Logic
{
    internal sealed class ItemBigIdSpecification
        : ComplexSpecification<Event>
    {
        private const int BaseId = 100;

        protected override string CreateFailedMessage(Event candidate)
        {
            return $"Item Id is lower than {BaseId}";
        }

        protected override string CreateNegationFailedMessage(Event candidate)
        {
            return $"Item Id is greater than or equal to {BaseId}";
        }

        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return null;
        }

        protected override Expression BuildExpressionBody(Expression arg)
        {
            return Expression.GreaterThanOrEqual(Expression.Property(arg, nameof(Event.Id)),
                Expression.Constant(BaseId));
        }
    }
}