using System.Collections;
using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.LengthSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class LengthData : SpecificationData
    {
        private void Valid<T>(T candidate, int length)
            where T : IEnumerable
        {
            AddValidWithResults<T, LengthValidResults, LengthNegationInvalidResults>(
                candidate, new LengthFactory<T>(length));
        }

        private void Invalid<T>(T candidate, int length)
            where T : IEnumerable
        {
            AddInvalidWithResults<T, LengthInvalidResults, LengthNegationValidResults>(
                candidate, new LengthFactory<T>(length));
        }

        public LengthData()
        {
            int[] emptyArr = new int[0], arr = {1, 2, 3};
            var list = new List<int> {1, 2, 3};
            var dict = new Dictionary<int, bool> {{1, false}, {2, true}};
            var ft = new FakeType {Fourth = new[] {1, 2, 3}};
            var ift = new InterFakeType();

            Valid("", 0);
            Valid("test", 4);
            Valid(emptyArr, 0);
            Valid(arr, 3);
            Valid(list, 3);
            Valid(dict, 2);
            Valid(ft, 3);
            Valid(ift, 1);

            Invalid("", 1);
            Invalid("test", 10);
            Invalid(emptyArr, 1);
            Invalid(arr, 0);
            Invalid(list, 0);
            Invalid(dict, 5);
            Invalid(ft, 1);
            Invalid(ift, 3);
            Invalid((string)null, 1);
            Invalid((FakeType)null, 0);
        }
    }
}