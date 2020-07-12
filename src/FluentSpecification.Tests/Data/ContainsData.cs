using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.ContainsSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class ContainsData : SpecificationData
    {
        private void Valid<T, TType>(T candidate, TType expected,
            IEqualityComparer<TType> comparer = null)
            where T : IEnumerable<TType>
        {
            AddValidWithResults<T, ContainsValidResults, ContainsNegationInvalidResults>(
                candidate, new ContainsFactory<T, TType>(expected, comparer));
        }

        private void Invalid<T, TType>(T candidate, TType expected,
            IEqualityComparer<TType> comparer = null)
            where T : IEnumerable<TType>
        {
            AddInvalidWithResults<T, ContainsInvalidResults, ContainsNegationValidResults>(
                candidate, new ContainsFactory<T, TType>(expected, comparer));
        }

        public ContainsData()
        {
            var comparer = new FakeTypeComparer();
            var intComparer = new FakeIntComparer();
            int[] arr = {1, 5, 200, 6, 100};
            var list = new List<string> {"First", "Second"};
            var dict = new Dictionary<string, bool> {{"First", false}, {"Second", true}};
            var cmp = new EquatableFakeType {First = 10};
            var notCmp = new EquatableFakeType {First = 100};
            EquatableFakeType[] cmpArr = {new EquatableFakeType {First = 11}, new EquatableFakeType {First = 10}};
            var ft = new FakeType {First = 1, Fourth = arr};
            var empty = new FakeType {First = 1};
            FakeType[] ftArr = {ft, cmp, null};
            var cmp2 = new ComparableFakeType {First = 15};
            FakeType[] ftArr2 = {new FakeType(), cmp2, null};

            Valid(arr, 5);
            Valid(list, "Second");
            Valid(dict, new KeyValuePair<string, bool>("First", false));
            Valid(cmpArr, cmp);
            Valid(ft, 200, intComparer);
            Valid(ftArr, ft);
            Valid(ftArr, empty, comparer);
            Valid(ftArr, (FakeType)null);
            Valid(ftArr2, (FakeType)cmp2);

            Invalid(arr, 16);
            Invalid(list, "Third");
            Invalid(dict, new KeyValuePair<string, bool>("Third", false));
            Invalid(ft, 16, intComparer);
            Invalid(cmpArr, notCmp);
            Invalid(ftArr, empty);
            Invalid((FakeType) null, 1);
        }
    }
}