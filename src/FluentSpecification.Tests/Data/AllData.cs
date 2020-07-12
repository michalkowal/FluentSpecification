using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.AllSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class AllData : SpecificationData
    {
        private void Valid<T, TType>(T candidate, Expression<Func<TType, bool>> expression)
            where T : IEnumerable<TType>
        {
            AddValidWithResult<T, AllValidResults>(
                candidate, new AllFactory<T, TType>(expression));
        }

        private void Invalid<T, TType>(T candidate, Expression<Func<TType, bool>> expression)
            where T : IEnumerable<TType>
        {
            AddInvalidWithResult<T, AllInvalidResults>(
                candidate, new AllFactory<T, TType>(expression));
        }

        public AllData()
        {
            int[] arr = {1, 5, 200, 6, 100};
            var list = new List<string> {"First", "Second"};
            var dict = new Dictionary<string, bool> {{"First", true}, {"Second", false}};
            var ft = new FakeType {Fourth = arr};
            var empty = new FakeType();

            Valid(arr, True<int>());
            Valid(list, True<string>());
            Valid(dict, True<KeyValuePair<string, bool>>());
            Valid(ft, True<int>());
            Valid(empty, True<int>());

            Invalid((FakeType)null, True<int>());
            Invalid(arr, False<int>());
            Invalid(list, False<string>());
            Invalid(dict, False<KeyValuePair<string, bool>>());
            Invalid(ft, False<int>());
            Invalid(arr, FewInt());
            Invalid(list, FewString());
            Invalid(dict, FewPair());
            Invalid(ft, FewInt());
        }

        private Expression<Func<T, bool>> True<T>()
        {
            return candidate => true;
        }

        private Expression<Func<T, bool>> False<T>()
        {
            return candidate => false;
        }

        private Expression<Func<int, bool>> FewInt()
        {
            return i => i < 100;
        }

        private Expression<Func<string, bool>> FewString()
        {
            return s => s == "First";
        }

        private Expression<Func<KeyValuePair<string, bool>, bool>> FewPair()
        {
            return kv => kv.Value;
        }
    }
}