using System;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class InclusiveBetweenConstructorData : SpecificationData
    {
        private void Invalid<T>(T from, T to)
        {
            AddInvalid(default, new InclusiveBetweenFactory<T>(from, to, null));
        }

        public InclusiveBetweenConstructorData()
        {
            Invalid(5, 1);
            Invalid(-3, -4);
            Invalid(5, -1);
            Invalid(5.1, 5.0);
            Invalid("123", "122");
            Invalid("123", null);
            Invalid(true, false);
            Invalid(DateTime.Parse("2019-01-01"), DateTime.Parse("2018-12-31"));
            Invalid(new ComparableFakeType {First = 1}, new ComparableFakeType());
            Invalid(new ComparableInterFakeType {Third = true}, new ComparableInterFakeType());
        }
    }
}