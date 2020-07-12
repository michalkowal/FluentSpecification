using System.Collections;
using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.LengthBetweenSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class LengthBetweenData : SpecificationData
    {
        private void Valid<T>(T candidate, int minLength, int maxLength)
            where T : IEnumerable
        {
            AddValidWithResults<T, LengthBetweenValidResults, LengthBetweenNegationInvalidResults>(
                candidate, new LengthBetweenFactory<T>(minLength, maxLength));
        }

        private void Invalid<T>(T candidate, int minLength, int maxLength)
            where T : IEnumerable
        {
            AddInvalidWithResults<T, LengthBetweenInvalidResults, LengthBetweenNegationValidResults>(
                candidate, new LengthBetweenFactory<T>(minLength, maxLength));
        }

        public LengthBetweenData()
        {
            int[] emptyArr = new int[0], arr = {1, 2, 3};
            var list = new List<int> {1, 2, 3};
            var dict = new Dictionary<int, bool> {{1, false}, {2, true}};
            var ft = new FakeType {Fourth = new[] {1, 2, 3}};
            var ift = new InterFakeType();

            Valid("", 0, 0);
            Valid("test", 1, 4);
            Valid(emptyArr, 0, 0);
            Valid(arr, 2, 3);
            Valid(list, -1, 10);
            Valid(dict, 0, 5);
            Valid(ft, 0, 3);
            Valid(ift, 1, 1);

            Invalid("", 1, 10);
            Invalid("test", 10, 20);
            Invalid(emptyArr, 1, 2);
            Invalid(arr, -5, -1);
            Invalid(list, 0, 1);
            Invalid(dict, 0, 1);
            Invalid(ft, 4, 6);
            Invalid(ift, 4, 6);
            Invalid((string)null, 0, 1);
            Invalid((FakeType)null, 0, 0);
        }
    }
}