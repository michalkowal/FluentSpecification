using System;
using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.IsTypeSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class IsTypeData : SpecificationData
    {
        private void Valid<T>(T candidate, Type expected)
        {
            AddValidWithResults<T, IsTypeValidResults, IsTypeNegationInvalidResults>(
                candidate, new IsTypeFactory<T>(expected));
        }

        private void Invalid<T>(T candidate, Type expected)
        {
            AddInvalidWithResults<T, IsTypeInvalidResults, IsTypeNegationValidResults>(
                candidate, new IsTypeFactory<T>(expected));
        }


        public IsTypeData()
        {
            var ft = new ComparableFakeType();

            Valid("", typeof(string));
            Valid(1, typeof(int));
            Valid(ft, typeof(FakeType));
            Valid(ft, typeof(IComparable<ComparableFakeType>));
            Valid(ft, typeof(IEnumerable<int>));

            Invalid("", typeof(int));
            Invalid(1, typeof(string));
            Invalid(ft, typeof(string));
            Invalid(ft, typeof(EquatableFakeType));
            Invalid(ft, typeof(IEquatable<ComparableFakeType>));
            Invalid(ft, typeof(IComparable<FakeType>));
        }
    }
}