using System.Collections;
using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.MinLengthSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class MinLengthData : SpecificationData
    {
        private void Valid<T>(T candidate, int minLength)
            where T : IEnumerable
        {
            AddValidWithResults<T, MinLengthValidResults, MinLengthNegationInvalidResults>(
                candidate, new MinLengthFactory<T>(minLength));
        }

        private void Invalid<T>(T candidate, int minLength)
            where T : IEnumerable
        {
            AddInvalidWithResults<T, MinLengthInvalidResults, MinLengthNegationValidResults>(
                candidate, new MinLengthFactory<T>(minLength));
        }

        public MinLengthData()
        {
            int[] emptyArr = new int[0], arr = {1, 2, 3};
            var list = new List<int> {1, 2, 3};
            var dict = new Dictionary<int, bool> {{1, false}, {2, true}};
            var ft = new FakeType {Fourth = new[] {1, 2, 3}};
            var ift = new InterFakeType();

            Valid("", 0);
            Valid("test", 4);
            Valid(emptyArr, 0);
            Valid(arr, 1);
            Valid(list, 3);
            Valid(dict, 2);
            Valid(ft, 2);
            Valid(ift, 0);

            Invalid("", 1);
            Invalid("test", 10);
            Invalid(emptyArr, 1);
            Invalid(arr, 20);
            Invalid(list, 4);
            Invalid(dict, 5);
            Invalid(ft, 5);
            Invalid(ift, 2);
            Invalid((string)null, 1);
            Invalid((FakeType)null, 0);
        }
    }
}