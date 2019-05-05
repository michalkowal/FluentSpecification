using System;
using System.Linq.Expressions;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class PropertySelectorData : SpecificationData
    {
        public PropertySelectorData()
        {
            AddInvalid((Expression<Func<FakeType, bool>>) (ft => true));
            AddInvalid((Expression<Func<FakeType, object>>) (ft => new object()));
            AddInvalid((Expression<Func<FakeType, string>>) (ft => ""));
            AddInvalid((Expression<Func<FakeType, string>>) (ft => null));
            AddInvalid((Expression<Func<FakeType, string>>) (ft => "Property"));
            AddInvalid((Expression<Func<FakeType, string>>) (ft => ft.Second + ""));
            AddInvalid((Expression<Func<FakeType, int>>) (ft => 1));
            AddInvalid((Expression<Func<FakeType, int>>) (ft => ft.First + 0));
            AddInvalid((Expression<Func<FakeType, bool>>) (ft => ft.Inter.Third && false));
        }
    }
}