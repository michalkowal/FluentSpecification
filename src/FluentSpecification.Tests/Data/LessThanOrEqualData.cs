using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class LessThanOrEqualData : SpecificationData
    {
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

            AddValid(2, 2, null)
                .Result("LessThanOrEqualSpecification<Int32>")
                .NegationResult("NotLessThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<int>),
                        "Object is lower than or equal to [2]")
                    .Candidate(2)
                    .AddParameter("LessThan", 2));
            AddValid(-2, -2, null)
                .Result("LessThanOrEqualSpecification<Int32>")
                .NegationResult("NotLessThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<int>),
                        "Object is lower than or equal to [-2]")
                    .Candidate(-2)
                    .AddParameter("LessThan", -2));
            AddValid(1, 5, null)
                .Result("LessThanOrEqualSpecification<Int32>")
                .NegationResult("NotLessThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<int>),
                        "Object is lower than or equal to [5]")
                    .Candidate(1)
                    .AddParameter("LessThan", 5));
            AddValid(-1, 1, null)
                .Result("LessThanOrEqualSpecification<Int32>")
                .NegationResult("NotLessThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<int>),
                        "Object is lower than or equal to [1]")
                    .Candidate(-1)
                    .AddParameter("LessThan", 1));
            AddValid(-9, -1, intComparer)
                .Result("LessThanOrEqualSpecification<Int32>")
                .NegationResult("NotLessThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<int>),
                        "Object is lower than or equal to [-1]")
                    .Candidate(-9)
                    .AddParameter("LessThan", -1));
            AddValid(3.5, 3.5, null)
                .Result("LessThanOrEqualSpecification<Double>")
                .NegationResult("NotLessThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<double>),
                        "Object is lower than or equal to [3.5]")
                    .Candidate(3.5)
                    .AddParameter("LessThan", 3.5));
            AddValid(-3.5, -3.5, null)
                .Result("LessThanOrEqualSpecification<Double>")
                .NegationResult("NotLessThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<double>),
                        "Object is lower than or equal to [-3.5]")
                    .Candidate(-3.5)
                    .AddParameter("LessThan", -3.5));
            AddValid(5.74, 5.75, null)
                .Result("LessThanOrEqualSpecification<Double>")
                .NegationResult("NotLessThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<double>),
                        "Object is lower than or equal to [5.75]")
                    .Candidate(5.74)
                    .AddParameter("LessThan", 5.75));
            AddValid(-2.5, 0.0, null)
                .Result("LessThanOrEqualSpecification<Double>")
                .NegationResult("NotLessThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<double>),
                        "Object is lower than or equal to [0]")
                    .Candidate(-2.5)
                    .AddParameter("LessThan", 0.0));
            AddValid(-5.75, -5.74, null)
                .Result("LessThanOrEqualSpecification<Double>")
                .NegationResult("NotLessThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<double>),
                        "Object is lower than or equal to [-5.74]")
                    .Candidate(-5.75)
                    .AddParameter("LessThan", -5.74));
            AddValid(false, false, null)
                .Result("LessThanOrEqualSpecification<Boolean>")
                .NegationResult("NotLessThanOrEqualSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<bool>),
                        "Object is lower than or equal to [False]")
                    .Candidate(false)
                    .AddParameter("LessThan", false));
            AddValid(false, true, null)
                .Result("LessThanOrEqualSpecification<Boolean>")
                .NegationResult("NotLessThanOrEqualSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<bool>),
                        "Object is lower than or equal to [True]")
                    .Candidate(false)
                    .AddParameter("LessThan", true));
            AddValid("123", "124", null)
                .Result("LessThanOrEqualSpecification<String>")
                .NegationResult("NotLessThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<string>),
                        "Object is lower than or equal to [124]")
                    .Candidate("123")
                    .AddParameter("LessThan", "124"));
            AddValid("123", "1234", null)
                .Result("LessThanOrEqualSpecification<String>")
                .NegationResult("NotLessThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<string>),
                        "Object is lower than or equal to [1234]")
                    .Candidate("123")
                    .AddParameter("LessThan", "1234"));
            AddValid("123", "123", null)
                .Result("LessThanOrEqualSpecification<String>")
                .NegationResult("NotLessThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<string>),
                        "Object is lower than or equal to [123]")
                    .Candidate("123")
                    .AddParameter("LessThan", "123"));
            AddValid("null", "test", null)
                .Result("LessThanOrEqualSpecification<String>")
                .NegationResult("NotLessThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<string>),
                        "Object is lower than or equal to [test]")
                    .Candidate(null)
                    .AddParameter("LessThan", "test"));
            AddValid("null", null, null)
                .Result("LessThanOrEqualSpecification<String>")
                .NegationResult("NotLessThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<string>),
                        "Object is lower than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("LessThan", null));
            AddValid(DateTime.Parse("2018-01-15"), DateTime.Parse("2019-07-11"), null)
                .Result("LessThanOrEqualSpecification<DateTime>")
                .NegationResult("NotLessThanOrEqualSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<DateTime>),
                        $"Object is lower than or equal to \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2018-01-15"))
                    .AddParameter("LessThan", DateTime.Parse("2019-07-11")));
            AddValid(DateTime.Parse("2019-07-01"), DateTime.Parse("2019-07-11"), null)
                .Result("LessThanOrEqualSpecification<DateTime>")
                .NegationResult("NotLessThanOrEqualSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<DateTime>),
                        $"Object is lower than or equal to \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-01"))
                    .AddParameter("LessThan", DateTime.Parse("2019-07-11")));
            AddValid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-11"), null)
                .Result("LessThanOrEqualSpecification<DateTime>")
                .NegationResult("NotLessThanOrEqualSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<DateTime>),
                        $"Object is lower than or equal to \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-11"))
                    .AddParameter("LessThan", DateTime.Parse("2019-07-11")));
            AddValid(cmp, cmp2, null)
                .Result("LessThanOrEqualSpecification<ComparableFakeType>")
                .NegationResult("NotLessThanOrEqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<ComparableFakeType>),
                        "Object is lower than or equal to [Fake(154)]")
                    .Candidate(cmp)
                    .AddParameter("LessThan", cmp2));
            AddValid(cmp3, cmp4, null)
                .Result("LessThanOrEqualSpecification<ComparableFakeType>")
                .NegationResult("NotLessThanOrEqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<ComparableFakeType>),
                        "Object is lower than or equal to [Fake(10)]")
                    .Candidate(cmp3)
                    .AddParameter("LessThan", cmp4));
            AddValid(cmpInter1, cmpInter3, null)
                .Result("LessThanOrEqualSpecification<ComparableInterFakeType>")
                .NegationResult("NotLessThanOrEqualSpecification<ComparableInterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<ComparableInterFakeType>),
                        "Object is lower than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]")
                    .Candidate(cmpInter1)
                    .AddParameter("LessThan", cmpInter3));
            AddValid(cmpInter1, cmpInter2, null)
                .Result("LessThanOrEqualSpecification<ComparableInterFakeType>")
                .NegationResult("NotLessThanOrEqualSpecification<ComparableInterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<ComparableInterFakeType>),
                        "Object is lower than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]")
                    .Candidate(cmpInter1)
                    .AddParameter("LessThan", cmpInter2));
            AddValid(new ComparableFakeType {Second = "null"}, new ComparableFakeType(), null)
                .Result("LessThanOrEqualSpecification<ComparableFakeType>")
                .NegationResult("NotLessThanOrEqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<ComparableFakeType>),
                        "Object is lower than or equal to [Fake(0)]")
                    .Candidate(null)
                    .AddParameter("LessThan", new ComparableFakeType()));
            AddValid(new ComparableFakeType {Second = "null"}, null, null)
                .Result("LessThanOrEqualSpecification<ComparableFakeType>")
                .NegationResult("NotLessThanOrEqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<ComparableFakeType>),
                        "Object is lower than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("LessThan", null));
            AddValid(cmpFakeType, cmpFakeType2, comparer)
                .Result("LessThanOrEqualSpecification<FakeType>")
                .NegationResult("NotLessThanOrEqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<FakeType>),
                        "Object is lower than or equal to [Fake(154)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("LessThan", cmpFakeType2));
            AddValid(cmpFakeType3, cmpFakeType4, comparer)
                .Result("LessThanOrEqualSpecification<FakeType>")
                .NegationResult("NotLessThanOrEqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<FakeType>),
                        "Object is lower than or equal to [Fake(10)]")
                    .Candidate(cmpFakeType3)
                    .AddParameter("LessThan", cmpFakeType4));
            AddValid(new FakeType {Second = "null"}, new FakeType(), comparer)
                .Result("LessThanOrEqualSpecification<FakeType>")
                .NegationResult("NotLessThanOrEqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<FakeType>),
                        "Object is lower than or equal to [Fake(0)]")
                    .Candidate(null)
                    .AddParameter("LessThan", new FakeType()));
            AddValid(new FakeType {Second = "null"}, null, comparer)
                .Result("LessThanOrEqualSpecification<FakeType>")
                .NegationResult("NotLessThanOrEqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<FakeType>),
                        "Object is lower than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("LessThan", null));

            var notCmp1 = new ComparableFakeType {First = 11};
            var notCmpFakeType1 = new FakeType {First = 11};

            AddInvalid(1, -1, null)
                .NegationResult("NotLessThanOrEqualSpecification<Int32>")
                .Result("LessThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<int>), "Object is greater than [-1]")
                    .Candidate(1)
                    .AddParameter("LessThan", -1));
            AddInvalid(5, 3, null)
                .NegationResult("NotLessThanOrEqualSpecification<Int32>")
                .Result("LessThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<int>), "Object is greater than [3]")
                    .Candidate(5)
                    .AddParameter("LessThan", 3));
            AddInvalid(-1, -10, intComparer)
                .NegationResult("NotLessThanOrEqualSpecification<Int32>")
                .Result("LessThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<int>), "Object is greater than [-10]")
                    .Candidate(-1)
                    .AddParameter("LessThan", -10));
            AddInvalid(5.74, 3.74, null)
                .NegationResult("NotLessThanOrEqualSpecification<Double>")
                .Result("LessThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<double>), "Object is greater than [3.74]")
                    .Candidate(5.74)
                    .AddParameter("LessThan", 3.74));
            AddInvalid(-3.74, -5.74, null)
                .NegationResult("NotLessThanOrEqualSpecification<Double>")
                .Result("LessThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<double>), "Object is greater than [-5.74]")
                    .Candidate(-3.74)
                    .AddParameter("LessThan", -5.74));
            AddInvalid(5.74, -3.74, null)
                .NegationResult("NotLessThanOrEqualSpecification<Double>")
                .Result("LessThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<double>), "Object is greater than [-3.74]")
                    .Candidate(5.74)
                    .AddParameter("LessThan", -3.74));
            AddInvalid(true, false, null)
                .NegationResult("NotLessThanOrEqualSpecification<Boolean>")
                .Result("LessThanOrEqualSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<bool>), "Object is greater than [False]")
                    .Candidate(true)
                    .AddParameter("LessThan", false));
            AddInvalid("123", "122", null)
                .NegationResult("NotLessThanOrEqualSpecification<String>")
                .Result("LessThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<string>), "Object is greater than [122]")
                    .Candidate("123")
                    .AddParameter("LessThan", "122"));
            AddInvalid("1234", "123", null)
                .NegationResult("NotLessThanOrEqualSpecification<String>")
                .Result("LessThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<string>), "Object is greater than [123]")
                    .Candidate("1234")
                    .AddParameter("LessThan", "123"));
            AddInvalid("test1", null, null)
                .NegationResult("NotLessThanOrEqualSpecification<String>")
                .Result("LessThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<string>), "Object is greater than [null]")
                    .Candidate("test1")
                    .AddParameter("LessThan", null));
            AddInvalid(DateTime.Parse("2019-11-15"), DateTime.Parse("2019-07-11"), null)
                .NegationResult("NotLessThanOrEqualSpecification<DateTime>")
                .Result("LessThanOrEqualSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<DateTime>),
                        $"Object is greater than \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-11-15"))
                    .AddParameter("LessThan", DateTime.Parse("2019-07-11")));
            AddInvalid(notCmp1, cmp3, null)
                .NegationResult("NotLessThanOrEqualSpecification<ComparableFakeType>")
                .Result("LessThanOrEqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<ComparableFakeType>),
                        "Object is greater than [Fake(10)]")
                    .Candidate(notCmp1)
                    .AddParameter("LessThan", cmp3));
            AddInvalid(notCmpFakeType1, cmpFakeType3, comparer)
                .NegationResult("NotLessThanOrEqualSpecification<FakeType>")
                .Result("LessThanOrEqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<FakeType>),
                        "Object is greater than [Fake(10)]")
                    .Candidate(notCmpFakeType1)
                    .AddParameter("LessThan", cmpFakeType3));
        }
    }
}