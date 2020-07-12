using System;
using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.LessThanOrEqualSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class LessThanOrEqualData : SpecificationData
    {
        private void Valid<T>(T candidate, T lessThan,
            IComparer<T> comparer = null)
        {
            AddValidWithResults<T, LessThanOrEqualValidResults, LessThanOrEqualNegationInvalidResults>(
                candidate, new LessThanOrEqualFactory<T>(lessThan, comparer));
        }

        private void Invalid<T>(T candidate, T lessThan,
            IComparer<T> comparer = null)
        {
            AddInvalidWithResults<T, LessThanOrEqualInvalidResults, LessThanOrEqualNegationValidResults>(
                candidate, new LessThanOrEqualFactory<T>(lessThan, comparer));
        }

        public LessThanOrEqualData()
        {
            var comparer = new FakeTypeComparer();
            var intComparer = new FakeIntComparer();
            ComparableFakeType cmp = new ComparableFakeType {First = 116},
                cmp2 = new ComparableFakeType {First = 154},
                cmp3 = new ComparableFakeType {First = 10},
                cmp4 = new ComparableFakeType {First = 10};
            ComparableInterFakeType cmpInter1 = new ComparableInterFakeType(),
                cmpInter2 = new ComparableInterFakeType(),
                cmpInter3 = new ComparableInterFakeType {Third = true};
            FakeType cmpFakeType = new FakeType {First = 116},
                cmpFakeType2 = new FakeType {First = 154},
                cmpFakeType3 = new FakeType {First = 10},
                cmpFakeType4 = new FakeType {First = 10};

            Valid(2, 2);
            Valid(-2, -2);
            Valid(1, 5);
            Valid(-1, 1);
            Valid(-9, -1, intComparer);
            Valid(3.5, 3.5);
            Valid(-3.5, -3.5);
            Valid(5.74, 5.75);
            Valid(-2.5, 0.0);
            Valid(-5.75, -5.74);
            Valid(false, false);
            Valid(false, true);
            Valid("123", "124");
            Valid("123", "1234");
            Valid("123", "123");
            Valid(null, "test");
            Valid((string)null, null);
            Valid(DateTime.Parse("2018-01-15"), DateTime.Parse("2019-07-11"));
            Valid(DateTime.Parse("2019-07-01"), DateTime.Parse("2019-07-11"));
            Valid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-11"));
            Valid(cmp, cmp2);
            Valid(cmp3, cmp4);
            Valid(cmpInter1, cmpInter3);
            Valid(cmpInter1, cmpInter2);
            Valid(null, new ComparableFakeType());
            Valid((ComparableFakeType)null, null);
            Valid(cmpFakeType, cmpFakeType2, comparer);
            Valid(cmpFakeType3, cmpFakeType4, comparer);
            Valid(null, new FakeType(), comparer);
            Valid(null, null, comparer);
            Valid((int?)null, 0);
            Valid((int?)null, null);

            var notCmp1 = new ComparableFakeType {First = 11};
            var notCmpFakeType1 = new FakeType {First = 11};

            Invalid(1, -1);
            Invalid(5, 3);
            Invalid(-1, -10, intComparer);
            Invalid(5.74, 3.74);
            Invalid(-3.74, -5.74);
            Invalid(5.74, -3.74);
            Invalid(true, false);
            Invalid("123", "122");
            Invalid("1234", "123");
            Invalid("test1", null);
            Invalid(DateTime.Parse("2019-11-15"), DateTime.Parse("2019-07-11"));
            Invalid(notCmp1, cmp3);
            Invalid(notCmpFakeType1, cmpFakeType3, comparer);
            Invalid((int?)0, null);
        }
    }
}