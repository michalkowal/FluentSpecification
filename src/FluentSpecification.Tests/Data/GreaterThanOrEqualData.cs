using System;
using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.GreaterThanOrEqualSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class GreaterThanOrEqualData : SpecificationData
    {
        private void Valid<T>(T candidate, T greaterThan,
            IComparer<T> comparer = null)
        {
            AddValidWithResults<T, GreaterThanOrEqualValidResults, GreaterThanOrEqualNegationInvalidResults>(
                candidate, new GreaterThanOrEqualFactory<T>(greaterThan, comparer));
        }

        private void Invalid<T>(T candidate, T greaterThan,
            IComparer<T> comparer = null)
        {
            AddInvalidWithResults<T, GreaterThanOrEqualInvalidResults, GreaterThanOrEqualNegationValidResults>(
                candidate, new GreaterThanOrEqualFactory<T>(greaterThan, comparer));
        }

        public GreaterThanOrEqualData()
        {
            var comparer = new FakeTypeComparer();
            var intComparer = new FakeIntComparer();
            ComparableFakeType cmp = new ComparableFakeType {First = 154},
                cmp2 = new ComparableFakeType {First = 116},
                cmp3 = new ComparableFakeType {First = 11},
                cmp4 = new ComparableFakeType {First = 11};
            ComparableInterFakeType cmpInter1 = new ComparableInterFakeType {Third = true},
                cmpInter2 = new ComparableInterFakeType(),
                cmpInter3 = new ComparableInterFakeType();
            FakeType cmpFakeType = new FakeType {First = 154},
                cmpFakeType2 = new FakeType {First = 116},
                cmpFakeType3 = new FakeType {First = 11},
                cmpFakeType4 = new FakeType {First = 11};

            Valid(2, 2);
            Valid(-2, -2);
            Valid(5, 1);
            Valid(1, -1);
            Valid(-1, -9, intComparer);
            Valid(3.5, 3.5);
            Valid(-3.5, -3.5);
            Valid(5.75, 5.74);
            Valid(0.0, -2.5);
            Valid(-5.74, -5.75);
            Valid(false, false);
            Valid(true, false);
            Valid("124", "123");
            Valid("1234", "123");
            Valid("123", "123");
            Valid("test1", null);
            Valid((string)null, null);
            Valid(DateTime.Parse("2019-07-11"), DateTime.Parse("2018-01-15"));
            Valid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-01"));
            Valid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-11"));
            Valid(cmp, cmp2);
            Valid(cmp3, cmp4);
            Valid((ComparableFakeType)null, null);
            Valid(cmpInter1, cmpInter3);
            Valid(cmpInter1, cmpInter2);
            Valid(cmpFakeType, cmpFakeType2, comparer);
            Valid(cmpFakeType3, cmpFakeType4, comparer);
            Valid(null, null, comparer);
            Valid((int?)0, null);
            Valid((int?)null, null);

            var notCmp1 = new ComparableFakeType {First = 10};
            var notCmpFakeType1 = new FakeType {First = 10};

            Invalid(-1, 1);
            Invalid(3, 5);
            Invalid(-10, -1, intComparer);
            Invalid(3.74, 5.74);
            Invalid(-5.74, -3.74);
            Invalid(-3.74, 5.74);
            Invalid(false, true);
            Invalid("122", "123");
            Invalid("123", "1234");
            Invalid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-11-15"));
            Invalid(notCmp1, cmp3);
            Invalid(null, "test");
            Invalid(null, new ComparableFakeType());
            Invalid(notCmpFakeType1, cmpFakeType3, comparer);
            Invalid(null, new FakeType(), comparer);
            Invalid((int?)null, 0);
        }
    }
}