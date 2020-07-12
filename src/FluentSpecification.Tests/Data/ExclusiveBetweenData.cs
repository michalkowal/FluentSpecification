using System;
using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.ExclusiveBetweenSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class ExclusiveBetweenData : SpecificationData
    {
        private void Valid<T>(T candidate, T from, T to,
            IComparer<T> comparer = null)
        {
            AddValidWithResults<T, ExclusiveBetweenValidResults, ExclusiveBetweenNegationInvalidResults>(
                candidate, new ExclusiveBetweenFactory<T>(from, to, comparer));
        }

        private void Invalid<T>(T candidate, T from, T to,
            IComparer<T> comparer = null)
        {
            AddInvalidWithResults<T, ExclusiveBetweenInvalidResults, ExclusiveBetweenNegationValidResults>(
                candidate, new ExclusiveBetweenFactory<T>(from, to, comparer));
        }

        public ExclusiveBetweenData()
        {
            var comparer = new FakeTypeComparer();
            var intComparer = new FakeIntComparer();
            ComparableFakeType cmp = new ComparableFakeType {First = 15},
                cmpFrom = new ComparableFakeType {First = 1},
                cmpTo = new ComparableFakeType {First = 30};
            FakeType cmpFakeType = new FakeType {First = 15},
                cmpFromFakeType = new FakeType {First = 1},
                cmpToFakeType = new FakeType {First = 30};

            Valid(1, 0, 5);
            Valid(-1, -5, 1);
            Valid(-9, -24, -1, intComparer);
            Valid(5.74, 5.73, 5.75);
            Valid(-2.5, -3.0, 0.0);
            Valid(-5.75, -5.76, -5.74);
            Valid("123", "122", "124");
            Valid("123", "12", "1234");
            Valid("test", null, "test1");
            Valid(DateTime.Parse("2018-01-15"), DateTime.Parse("2017-05-16"), DateTime.Parse("2019-07-11"));
            Valid(DateTime.Parse("2019-07-05"), DateTime.Parse("2019-07-01"), DateTime.Parse("2019-07-11"));
            Valid(cmp, cmpFrom, cmpTo);
            Valid(cmp, null, cmpTo);
            Valid(cmpFakeType, cmpFromFakeType, cmpToFakeType, comparer);
            Valid(cmpFakeType, null, cmpToFakeType, comparer);
            Valid((int?)0, null, 1);

            ComparableFakeType notCmp1 = new ComparableFakeType {First = 10},
                notCmp2 = new ComparableFakeType {First = 15},
                notCmp3 = new ComparableFakeType {First = 1},
                notCmp4 = new ComparableFakeType {First = 3},
                notCmp5 = new ComparableFakeType {First = 23},
                notCmp6 = new ComparableFakeType {First = 30};
            ComparableInterFakeType cmpInter1 = new ComparableInterFakeType(),
                cmpInter2 = new ComparableInterFakeType(),
                cmpInter3 = new ComparableInterFakeType {Third = true};
            FakeType notCmpFakeType1 = new FakeType {First = 10},
                notCmpFakeType2 = new FakeType {First = 15},
                notCmpFakeType3 = new FakeType {First = 1},
                notCmpFakeType4 = new FakeType {First = 3},
                notCmpFakeType5 = new FakeType {First = 23},
                notCmpFakeType6 = new FakeType {First = 30};

            Invalid(2, 2, 3);
            Invalid(-2, -3, -2);
            Invalid(1, -3, -1);
            Invalid(5, 1, 3);
            Invalid(-1, -10, -5, intComparer);
            Invalid(3.5, 3.5, 3.5);
            Invalid(-3.5, -3.5, -3.5);
            Invalid(5.74, 2.74, 3.74);
            Invalid(-3.74, -7.74, -5.74);
            Invalid(5.74, -3.74, 5.73);
            Invalid(false, false, true);
            Invalid("123", "121", "122");
            Invalid("1234", "122", "1233");
            Invalid("123", "123", "124");
            Invalid(null, "test", "test1");
            Invalid(null, null, "test");
            Invalid((string) null, null, null);
            Invalid(DateTime.Parse("2019-11-15"), DateTime.Parse("2019-07-11"), DateTime.Parse("2019-11-15"));
            Invalid(DateTime.Parse("2019-11-15"), DateTime.Parse("2019-12-11"), DateTime.Parse("2019-12-15"));
            Invalid(cmp, notCmp1, notCmp2);
            Invalid(cmp, notCmp3, notCmp4);
            Invalid(cmp, notCmp5, notCmp6);
            Invalid(cmpInter1, cmpInter2, cmpInter3);
            Invalid(null, notCmp1, notCmp2);
            Invalid(null, null, notCmp2);
            Invalid((ComparableFakeType) null, null, null);
            Invalid(cmpFakeType, notCmpFakeType1, notCmpFakeType2, comparer);
            Invalid(cmpFakeType, notCmpFakeType3, notCmpFakeType4, comparer);
            Invalid(cmpFakeType, notCmpFakeType5, notCmpFakeType6, comparer);
            Invalid(null, notCmpFakeType1, notCmpFakeType2, comparer);
            Invalid(null, null, notCmpFakeType2, comparer);
            Invalid(null, null, null, comparer);
            Invalid((int?) null, 0, 1);
            Invalid((int?) null, null, 1);
            Invalid((int?) null, null, null);
        }
    }
}