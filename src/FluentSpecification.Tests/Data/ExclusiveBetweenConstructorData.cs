using System;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class ExclusiveBetweenConstructorData : SpecificationData
    {
        public ExclusiveBetweenConstructorData()
        {
            AddInvalid(5, 1);
            AddInvalid(-3, -4);
            AddInvalid(5, -1);
            AddInvalid(5.1, 5.0);
            AddInvalid("123", "122");
            AddInvalid("123", null);
            AddInvalid(true, false);
            AddInvalid(DateTime.Parse("2019-01-01"), DateTime.Parse("2018-12-31"));
            AddInvalid(new ComparableFakeType {First = 1}, new ComparableFakeType());
            AddInvalid(new ComparableInterFakeType {Third = true}, new ComparableInterFakeType());
        }
    }
}