using System;
using System.Linq.Expressions;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class PropertyExpressionData : SpecificationData
    {
        public PropertyExpressionData()
        {
            var candidate = new FakeType
            {
                First = 1,
                Second = "2",
                Inter = new InterFakeType()
            };
            var empty = new FakeType();
            var ftSecondSelector = (Expression<Func<FakeType, string>>) (ft => ft.Second);
            var ftThirdSelector = (Expression<Func<FakeType, bool>>) (ft => ft.Inter.Third);

            AddValid(candidate, ftSecondSelector);
            AddValid(candidate, ftThirdSelector);
            AddValid(empty, ftSecondSelector);

            AddInvalid(candidate, ftSecondSelector);
            AddInvalid(candidate, ftThirdSelector);
        }
    }
}