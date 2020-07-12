using System;
using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.GreaterThanSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class GreaterThanData : SpecificationData
    {
        private void Valid<T>(T candidate, T greaterThan,
            IComparer<T> comparer = null)
        {
            AddValidWithResults<T, GreaterThanValidResults, GreaterThanNegationInvalidResults>(
                candidate, new GreaterThanFactory<T>(greaterThan, comparer));
        }

        private void Invalid<T>(T candidate, T greaterThan,
            IComparer<T> comparer = null)
        {
            AddInvalidWithResults<T, GreaterThanInvalidResults, GreaterThanNegationValidResults>(
                candidate, new GreaterThanFactory<T>(greaterThan, comparer));
        }

        public GreaterThanData()
        {
            var comparer = new FakeTypeComparer();
            var intComparer = new FakeIntComparer();
            ComparableFakeType cmp = new ComparableFakeType {First = 154},
                cmp2 = new ComparableFakeType {First = 116};
            ComparableInterFakeType cmpInter1 = new ComparableInterFakeType {Third = true},
                cmpInter2 = new ComparableInterFakeType {Third = true},
                cmpInter3 = new ComparableInterFakeType();
            FakeType cmpFakeType = new FakeType {First = 154},
                cmpFakeType2 = new FakeType {First = 116};

            Valid(5, 1);
            Valid(1, -1);
            Valid(-1, -9, intComparer);
            Valid(5.75, 5.74);
            Valid(0.0, -2.5);
            Valid(-5.74, -5.75);
            Valid(true, false);
            Valid("124", "123");
            Valid("1234", "123");
            Valid("test1", null);
            Valid(DateTime.Parse("2019-07-11"), DateTime.Parse("2018-01-15"));
            Valid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-01"));
            Valid(cmp, cmp2);
            Valid(cmpInter1, cmpInter3);
            Valid(cmpFakeType, cmpFakeType2, comparer);
            Valid((int?)0, null);

            ComparableFakeType notCmp1 = new ComparableFakeType {First = 10},
                notCmp2 = new ComparableFakeType {First = 10},
                notCmp3 = new ComparableFakeType {First = 11};
            FakeType notCmpFakeType1 = new FakeType {First = 10},
                notCmpFakeType2 = new FakeType {First = 10},
                notCmpFakeType3 = new FakeType {First = 11};

            Invalid(2, 2);
            Invalid(-2, -2);
            Invalid(-1, 1);
            Invalid(3, 5);
            Invalid(-10, -1, intComparer);
            Invalid(3.5, 3.5);
            Invalid(-3.5, -3.5);
            Invalid(3.74, 5.74);
            Invalid(-5.74, -3.74);
            Invalid(-3.74, 5.74);
            Invalid(false, true);
            Invalid(false, false);
            Invalid("122", "123");
            Invalid("123", "1234");
            Invalid("123", "123");
            Invalid((string) null, null);
            Invalid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-11-15"));
            Invalid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-11"));
            Invalid(notCmp1, notCmp2);
            Invalid(notCmp2, notCmp3);
            Invalid(null, "test");
            Invalid(null, new ComparableFakeType());
            Invalid((ComparableFakeType) null, null);
            Invalid(cmpInter1, cmpInter2);
            Invalid(notCmpFakeType1, notCmpFakeType2, comparer);
            Invalid(notCmpFakeType2, notCmpFakeType3, comparer);
            Invalid(null, new FakeType(), comparer);
            Invalid(null, null, comparer);
            Invalid((int?)null, 0);
            Invalid((int?)null, null);
        }
    }
}