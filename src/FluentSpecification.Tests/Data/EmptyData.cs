using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.EmptySpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class EmptyData : SpecificationData
    {
        private void Valid<T>(T candidate)
        {
            AddValidWithResults<T, EmptyValidResults, EmptyNegationInvalidResults>(
                candidate, new EmptyFactory<T>());
        }

        private void Invalid<T>(T candidate)
        {
            AddInvalidWithResults<T, EmptyInvalidResults, EmptyNegationValidResults>(
                candidate, new EmptyFactory<T>());
        }

        public EmptyData()
        {
            var emptyArr = new int[0];
            var emptyList = new List<string>();
            var emptyDict = new Dictionary<string, bool>();
            var emptyFake = new FakeType();

            Valid((object) null);
            Valid((string) null);
            Valid((FakeType) null);
            Valid("");
            Valid(0);
            Valid(0.0);
            Valid(false);
            Valid(emptyArr);
            Valid(emptyList);
            Valid(emptyDict);
            Valid(emptyFake);
            Valid((int?) null);

            var obj = new object();
            var arr = new[] {-1};
            var list = new List<string> {"123"};
            var dict = new Dictionary<string, bool> {{"1", false}};
            var fake = new FakeType {Fourth = new[] {1, 2, 3}};

            Invalid(obj);
            Invalid(" ");
            Invalid("\t");
            Invalid("\n");
            Invalid("\r");
            Invalid("test");
            Invalid(1);
            Invalid(0.1);
            Invalid(true);
            Invalid(arr);
            Invalid(list);
            Invalid(dict);
            Invalid(fake);
            Invalid((int?) 0);
        }
    }
}