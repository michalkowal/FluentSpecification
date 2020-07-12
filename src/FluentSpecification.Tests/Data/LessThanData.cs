using System;
using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.LessThanSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class LessThanData : SpecificationData
    {
        private void Valid<T>(T candidate, T lessThan,
            IComparer<T> comparer = null)
        {
            AddValidWithResults<T, LessThanValidResults, LessThanNegationInvalidResults>(
                candidate, new LessThanFactory<T>(lessThan, comparer));
        }

        private void Invalid<T>(T candidate, T lessThan,
            IComparer<T> comparer = null)
        {
            AddInvalidWithResults<T, LessThanInvalidResults, LessThanNegationValidResults>(
                candidate, new LessThanFactory<T>(lessThan, comparer));
        }

        public LessThanData()
        {
            var comparer = new FakeTypeComparer();
            var intComparer = new FakeIntComparer();
            ComparableFakeType cmp = new ComparableFakeType {First = 116},
                cmp2 = new ComparableFakeType {First = 154};
            ComparableInterFakeType cmpInter1 = new ComparableInterFakeType(),
                cmpInter2 = new ComparableInterFakeType(),
                cmpInter3 = new ComparableInterFakeType {Third = true};
            FakeType cmpFakeType = new FakeType {First = 116},
                cmpFakeType2 = new FakeType {First = 154};

            Valid(1, 5);
            Valid(-1, 1);
            Valid(-9, -1, intComparer);
            Valid(5.74, 5.75);
            Valid(-2.5, 0.0);
            Valid(-5.75, -5.74);
            Valid(false, true);
            Valid("123", "124");
            Valid("123", "1234");
            Valid(null, "test");
            Valid(DateTime.Parse("2018-01-15"), DateTime.Parse("2019-07-11"));
            Valid(DateTime.Parse("2019-07-01"), DateTime.Parse("2019-07-11"));
            Valid(cmp, cmp2);
            Valid(null, new ComparableFakeType());
            Valid(cmpInter1, cmpInter3);
            Valid(cmpFakeType, cmpFakeType2, comparer);
            Valid(null, new FakeType(), comparer);
            Valid((int?)null, 0);

            ComparableFakeType notCmp1 = new ComparableFakeType {First = 11},
                notCmp2 = new ComparableFakeType {First = 10},
                notCmp3 = new ComparableFakeType {First = 10};
            FakeType notCmpFakeType1 = new FakeType {First = 11},
                notCmpFakeType2 = new FakeType {First = 10},
                notCmpFakeType3 = new FakeType {First = 10};

            Invalid(2, 2);
            Invalid(-2, -2);
            Invalid(1, -1);
            Invalid(5, 3);
            Invalid(-1, -10, intComparer);
            Invalid(3.5, 3.5);
            Invalid(-3.5, -3.5);
            Invalid(5.74, 3.74);
            Invalid(-3.74, -5.74);
            Invalid(5.74, -3.74);
            Invalid(true, false);
            Invalid(false, false);
            Invalid("123", "122");
            Invalid("1234", "123");
            Invalid("123", "123");
            Invalid("test1", null);
            Invalid((string)null, null);
            Invalid(DateTime.Parse("2019-11-15"), DateTime.Parse("2019-07-11"));
            Invalid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-11"));
            Invalid(notCmp1, notCmp2);
            Invalid(notCmp2, notCmp3);
            Invalid((ComparableFakeType)null, null);
            Invalid(cmpInter1, cmpInter2);
            Invalid(notCmpFakeType1, notCmpFakeType2, comparer);
            Invalid(notCmpFakeType2, notCmpFakeType3, comparer);
            Invalid(null, null, comparer);
            Invalid((int?)0, null);
            Invalid((int?)null, null);
        }
    }
}