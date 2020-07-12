using System.Collections;
using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.MaxLengthSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class MaxLengthData : SpecificationData
    {
        private void Valid<T>(T candidate, int maxLength)
            where T : IEnumerable
        {
            AddValidWithResults<T, MaxLengthValidResults, MaxLengthNegationInvalidResults>(
                candidate, new MaxLengthFactory<T>(maxLength));
        }

        private void Invalid<T>(T candidate, int maxLength)
            where T : IEnumerable
        {
            AddInvalidWithResults<T, MaxLengthInvalidResults, MaxLengthNegationValidResults>(
                candidate, new MaxLengthFactory<T>(maxLength));
        }

        public MaxLengthData()
        {
            int[] emptyArr = new int[0], arr = {1, 2, 3};
            var list = new List<int> {1, 2, 3};
            var dict = new Dictionary<int, bool> {{1, false}, {2, true}};
            var ft = new FakeType {Fourth = new[] {1, 2, 3}};
            var ift = new InterFakeType();

            Valid("", 0);
            Valid("test", 25);
            Valid(emptyArr, 1);
            Valid(arr, 5);
            Valid(list, 3);
            Valid(dict, 20);
            Valid(ft, 3);
            Valid(ift, 1);

            Invalid("", -1);
            Invalid("test", 2);
            Invalid(emptyArr, -1);
            Invalid(arr, 0);
            Invalid(list, 2);
            Invalid(dict, 1);
            Invalid(ft, 0);
            Invalid(ift, 0);
            Invalid((string)null, 1);
            Invalid((FakeType)null, 0);
        }
    }
}