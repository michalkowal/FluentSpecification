using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class EqualData : SpecificationData
    {
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

            AddValid(obj1, obj2, null)
                .Result("EqualSpecification<Object>")
                .NegationResult("NotEqualSpecification<Object>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<object>), "Object is equal to [System.Object]")
                    .Candidate(obj1)
                    .AddParameter("Expected", obj2));
            AddValid("test", "test", null)
                .Result("EqualSpecification<String>")
                .NegationResult("NotEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<string>), "Object is equal to [test]")
                    .Candidate("test")
                    .AddParameter("Expected", "test"));
            AddValid(1, 1, null)
                .Result("EqualSpecification<Int32>")
                .NegationResult("NotEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<int>), "Object is equal to [1]")
                    .Candidate(1)
                    .AddParameter("Expected", 1));
            AddValid(1, 1, intComparer)
                .Result("EqualSpecification<Int32>")
                .NegationResult("NotEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<int>), "Object is equal to [1]")
                    .Candidate(1)
                    .AddParameter("Expected", 1));
            AddValid(5.74, 5.74, null)
                .Result("EqualSpecification<Double>")
                .NegationResult("NotEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<double>), "Object is equal to [5.74]")
                    .Candidate(5.74)
                    .AddParameter("Expected", 5.74));
            AddValid(false, false, null)
                .Result("EqualSpecification<Boolean>")
                .NegationResult("NotEqualSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<bool>), "Object is equal to [False]")
                    .Candidate(false)
                    .AddParameter("Expected", false));
            AddValid(eq1, eq2, null)
                .Result("EqualSpecification<EquatableFakeType>")
                .NegationResult("NotEqualSpecification<EquatableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<EquatableFakeType>), "Object is equal to [Fake(15)]")
                    .Candidate(eq1)
                    .AddParameter("Expected", eq2));
            AddValid(cmp1, cmp2, null)
                .Result("EqualSpecification<ComparableFakeType>")
                .NegationResult("NotEqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<ComparableFakeType>),
                        "Object is equal to [Fake(15)]")
                    .Candidate(cmp1)
                    .AddParameter("Expected", cmp2));
            AddValid(cmpInter1, cmpInter2, null)
                .Result("EqualSpecification<ComparableInterFakeType>")
                .NegationResult("NotEqualSpecification<ComparableInterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<ComparableInterFakeType>),
                        "Object is equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]")
                    .Candidate(cmpInter1)
                    .AddParameter("Expected", cmpInter2));
            AddValid(ft1, ft2, comparer)
                .Result("EqualSpecification<FakeType>")
                .NegationResult("NotEqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<FakeType>), "Object is equal to [Fake(15)]")
                    .Candidate(ft1)
                    .AddParameter("Expected", ft2));
            AddValid(null, null, null)
                .Result("EqualSpecification<Object>")
                .NegationResult("NotEqualSpecification<Object>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<object>), "Object is equal to [null]")
                    .Candidate(null)
                    .AddParameter("Expected", null));
            AddValid("null", null, null)
                .Result("EqualSpecification<String>")
                .NegationResult("NotEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<string>), "Object is equal to [null]")
                    .Candidate(null)
                    .AddParameter("Expected", null));
            AddValid(new EquatableFakeType {Second = "null"}, null, null)
                .Result("EqualSpecification<EquatableFakeType>")
                .NegationResult("NotEqualSpecification<EquatableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<EquatableFakeType>), "Object is equal to [null]")
                    .Candidate(null)
                    .AddParameter("Expected", null));
            AddValid(new ComparableFakeType {Second = "null"}, null, null)
                .Result("EqualSpecification<ComparableFakeType>")
                .NegationResult("NotEqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<ComparableFakeType>), "Object is equal to [null]")
                    .Candidate(null)
                    .AddParameter("Expected", null));
            AddValid(new FakeType {Second = "null"}, null, comparer)
                .Result("EqualSpecification<FakeType>")
                .NegationResult("NotEqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<FakeType>), "Object is equal to [null]")
                    .Candidate(null)
                    .AddParameter("Expected", null));

            var obj3 = new object();
            var neq = new EquatableFakeType {First = 11};
            var notCmp = new ComparableFakeType {First = 11};
            var notCmpInter = new ComparableInterFakeType {Third = true};
            FakeType f1 = new FakeType(), f2 = new FakeType();

            AddInvalid(obj1, obj3, null)
                .NegationResult("NotEqualSpecification<Object>")
                .Result("EqualSpecification<Object>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<object>), "Object is not equal to [System.Object]")
                    .Candidate(obj1)
                    .AddParameter("Expected", obj3));
            AddInvalid("test", "another test", null)
                .NegationResult("NotEqualSpecification<String>")
                .Result("EqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<string>), "Object is not equal to [another test]")
                    .Candidate("test")
                    .AddParameter("Expected", "another test"));
            AddInvalid("test", null, null)
                .NegationResult("NotEqualSpecification<String>")
                .Result("EqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<string>), "Object is not equal to [null]")
                    .Candidate("test")
                    .AddParameter("Expected", null));
            AddInvalid("null", "test", null)
                .NegationResult("NotEqualSpecification<String>")
                .Result("EqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<string>), "Object is not equal to [test]")
                    .Candidate(null)
                    .AddParameter("Expected", "test"));
            AddInvalid(1, -1, null)
                .NegationResult("NotEqualSpecification<Int32>")
                .Result("EqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<int>), "Object is not equal to [-1]")
                    .Candidate(1)
                    .AddParameter("Expected", -1));
            AddInvalid(1, -1, intComparer)
                .NegationResult("NotEqualSpecification<Int32>")
                .Result("EqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<int>), "Object is not equal to [-1]")
                    .Candidate(1)
                    .AddParameter("Expected", -1));
            AddInvalid(5.74, 3.74, null)
                .NegationResult("NotEqualSpecification<Double>")
                .Result("EqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<double>), "Object is not equal to [3.74]")
                    .Candidate(5.74)
                    .AddParameter("Expected", 3.74));
            AddInvalid(false, true, null)
                .NegationResult("NotEqualSpecification<Boolean>")
                .Result("EqualSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<bool>), "Object is not equal to [True]")
                    .Candidate(false)
                    .AddParameter("Expected", true));
            AddInvalid(obj1, null, null)
                .NegationResult("NotEqualSpecification<Object>")
                .Result("EqualSpecification<Object>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<object>), "Object is not equal to [null]")
                    .Candidate(obj1)
                    .AddParameter("Expected", null));
            AddInvalid(null, obj1, null)
                .NegationResult("NotEqualSpecification<Object>")
                .Result("EqualSpecification<Object>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<object>), "Object is not equal to [System.Object]")
                    .Candidate(null)
                    .AddParameter("Expected", obj1));
            AddInvalid(eq1, neq, null)
                .NegationResult("NotEqualSpecification<EquatableFakeType>")
                .Result("EqualSpecification<EquatableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<EquatableFakeType>),
                        "Object is not equal to [Fake(11)]")
                    .Candidate(eq1)
                    .AddParameter("Expected", neq));
            AddInvalid(eq1, null, null)
                .NegationResult("NotEqualSpecification<EquatableFakeType>")
                .Result("EqualSpecification<EquatableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<EquatableFakeType>), "Object is not equal to [null]")
                    .Candidate(eq1)
                    .AddParameter("Expected", null));
            AddInvalid(new EquatableFakeType {Second = "null"}, eq1, null)
                .NegationResult("NotEqualSpecification<EquatableFakeType>")
                .Result("EqualSpecification<EquatableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<EquatableFakeType>),
                        "Object is not equal to [Fake(15)]")
                    .Candidate(null)
                    .AddParameter("Expected", eq1));
            AddInvalid(cmp1, notCmp, null)
                .NegationResult("NotEqualSpecification<ComparableFakeType>")
                .Result("EqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<ComparableFakeType>),
                        "Object is not equal to [Fake(11)]")
                    .Candidate(cmp1)
                    .AddParameter("Expected", notCmp));
            AddInvalid(cmp1, null, null)
                .NegationResult("NotEqualSpecification<ComparableFakeType>")
                .Result("EqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<ComparableFakeType>),
                        "Object is not equal to [null]")
                    .Candidate(cmp1)
                    .AddParameter("Expected", null));
            AddInvalid(new ComparableFakeType {Second = "null"}, cmp1, null)
                .NegationResult("NotEqualSpecification<ComparableFakeType>")
                .Result("EqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<ComparableFakeType>),
                        "Object is not equal to [Fake(15)]")
                    .Candidate(null)
                    .AddParameter("Expected", cmp1));
            AddInvalid(cmpInter1, notCmpInter, null)
                .NegationResult("NotEqualSpecification<ComparableInterFakeType>")
                .Result("EqualSpecification<ComparableInterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<ComparableInterFakeType>),
                        "Object is not equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]")
                    .Candidate(cmpInter1)
                    .AddParameter("Expected", notCmpInter));
            AddInvalid(f1, f2, null)
                .NegationResult("NotEqualSpecification<FakeType>")
                .Result("EqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<FakeType>), "Object is not equal to [Fake(0)]")
                    .Candidate(f1)
                    .AddParameter("Expected", f2));
            AddInvalid(f1, null, comparer)
                .NegationResult("NotEqualSpecification<FakeType>")
                .Result("EqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<FakeType>), "Object is not equal to [null]")
                    .Candidate(f1)
                    .AddParameter("Expected", null));
            AddInvalid(new FakeType {Second = "null"}, f1, comparer)
                .NegationResult("NotEqualSpecification<FakeType>")
                .Result("EqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<FakeType>), "Object is not equal to [Fake(0)]")
                    .Candidate(null)
                    .AddParameter("Expected", f1));
        }
    }
}