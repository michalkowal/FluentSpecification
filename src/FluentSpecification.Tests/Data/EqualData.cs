using System.Collections.Generic;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.EqualSpecificationResults;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class EqualData : SpecificationData
    {
        private void Valid<T>(T candidate, T expected,
            IEqualityComparer<T> comparer = null)
        {
            AddValidWithResults<T, EqualValidResults, EqualNegationInvalidResults>(
                candidate, new EqualFactory<T>(expected, comparer));
        }

        private void Invalid<T>(T candidate, T expected,
            IEqualityComparer<T> comparer = null)
        {
            AddInvalidWithResults<T, EqualInvalidResults, EqualNegationValidResults>(
                candidate, new EqualFactory<T>(expected, comparer));
        }

        public EqualData()
        {
            var comparer = new FakeTypeComparer();
            var intComparer = new FakeIntComparer();
            var obj1 = new object();
            var obj2 = obj1;
            EquatableFakeType eq1 = new EquatableFakeType {First = 15}, eq2 = new EquatableFakeType {First = 15};
            ComparableFakeType cmp1 = new ComparableFakeType {First = 15}, cmp2 = new ComparableFakeType {First = 15};
            ComparableInterFakeType cmpInter1 = new ComparableInterFakeType(),
                cmpInter2 = new ComparableInterFakeType();
            FakeType ft1 = new FakeType {First = 15}, ft2 = new FakeType {First = 15};

            Valid(obj1, obj2);
            Valid("test", "test");
            Valid(1, 1);
            Valid(1, 1, intComparer);
            Valid(5.74, 5.74);
            Valid(false, false);
            Valid(eq1, eq2);
            Valid(cmp1, cmp2);
            Valid(cmpInter1, cmpInter2);
            Valid(ft1, ft2, comparer);
            Valid((object)null, null);
            Valid((string)null, null);
            Valid((EquatableFakeType) null, null);
            Valid((ComparableFakeType) null, null);
            Valid(null, null, comparer);
            Valid((int?) null, null);

            var obj3 = new object();
            var neq = new EquatableFakeType {First = 11};
            var notCmp = new ComparableFakeType {First = 11};
            var notCmpInter = new ComparableInterFakeType {Third = true};
            FakeType f1 = new FakeType(), f2 = new FakeType();

            Invalid(obj1, obj3);
            Invalid("test", "another test");
            Invalid("test", null);
            Invalid(null, "test");
            Invalid(1, -1);
            Invalid(1, -1, intComparer);
            Invalid(5.74, 3.74);
            Invalid(false, true);
            Invalid(obj1, null);
            Invalid(null, obj1);
            Invalid(eq1, neq);
            Invalid(eq1, null);
            Invalid(null, eq1);
            Invalid(cmp1, notCmp);
            Invalid(cmp1, null);
            Invalid(null, cmp1);
            Invalid(cmpInter1, notCmpInter);
            Invalid(f1, f2);
            Invalid(f1, null, comparer);
            Invalid(null, f1, comparer);
            Invalid((int?) 0, null);
            Invalid((int?) null, 0);
        }
    }
}