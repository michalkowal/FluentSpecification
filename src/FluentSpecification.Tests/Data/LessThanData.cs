using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class LessThanData : SpecificationData
    {
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

            AddValid(1, 5, null)
                .Result("LessThanSpecification<Int32>")
                .NegationResult("NotLessThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<int>), "Object is lower than [5]")
                    .Candidate(1)
                    .AddParameter("LessThan", 5));
            AddValid(-1, 1, null)
                .Result("LessThanSpecification<Int32>")
                .NegationResult("NotLessThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<int>), "Object is lower than [1]")
                    .Candidate(-1)
                    .AddParameter("LessThan", 1));
            AddValid(-9, -1, intComparer)
                .Result("LessThanSpecification<Int32>")
                .NegationResult("NotLessThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<int>), "Object is lower than [-1]")
                    .Candidate(-9)
                    .AddParameter("LessThan", -1));
            AddValid(5.74, 5.75, null)
                .Result("LessThanSpecification<Double>")
                .NegationResult("NotLessThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<double>), "Object is lower than [5.75]")
                    .Candidate(5.74)
                    .AddParameter("LessThan", 5.75));
            AddValid(-2.5, 0.0, null)
                .Result("LessThanSpecification<Double>")
                .NegationResult("NotLessThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<double>), "Object is lower than [0]")
                    .Candidate(-2.5)
                    .AddParameter("LessThan", 0.0));
            AddValid(-5.75, -5.74, null)
                .Result("LessThanSpecification<Double>")
                .NegationResult("NotLessThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<double>), "Object is lower than [-5.74]")
                    .Candidate(-5.75)
                    .AddParameter("LessThan", -5.74));
            AddValid(false, true, null)
                .Result("LessThanSpecification<Boolean>")
                .NegationResult("NotLessThanSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<bool>), "Object is lower than [True]")
                    .Candidate(false)
                    .AddParameter("LessThan", true));
            AddValid("123", "124", null)
                .Result("LessThanSpecification<String>")
                .NegationResult("NotLessThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<string>), "Object is lower than [124]")
                    .Candidate("123")
                    .AddParameter("LessThan", "124"));
            AddValid("123", "1234", null)
                .Result("LessThanSpecification<String>")
                .NegationResult("NotLessThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<string>), "Object is lower than [1234]")
                    .Candidate("123")
                    .AddParameter("LessThan", "1234"));
            AddValid("null", "test", null)
                .Result("LessThanSpecification<String>")
                .NegationResult("NotLessThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<string>), "Object is lower than [test]")
                    .Candidate(null)
                    .AddParameter("LessThan", "test"));
            AddValid(DateTime.Parse("2018-01-15"), DateTime.Parse("2019-07-11"), null)
                .Result("LessThanSpecification<DateTime>")
                .NegationResult("NotLessThanSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<DateTime>),
                        $"Object is lower than \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2018-01-15"))
                    .AddParameter("LessThan", DateTime.Parse("2019-07-11")));
            AddValid(DateTime.Parse("2019-07-01"), DateTime.Parse("2019-07-11"), null)
                .Result("LessThanSpecification<DateTime>")
                .NegationResult("NotLessThanSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<DateTime>),
                        $"Object is lower than \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-01"))
                    .AddParameter("LessThan", DateTime.Parse("2019-07-11")));
            AddValid(cmp, cmp2, null)
                .Result("LessThanSpecification<ComparableFakeType>")
                .NegationResult("NotLessThanSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<ComparableFakeType>),
                        "Object is lower than [Fake(154)]")
                    .Candidate(cmp)
                    .AddParameter("LessThan", cmp2));
            AddValid(new ComparableFakeType {Second = "null"}, new ComparableFakeType(), null)
                .Result("LessThanSpecification<ComparableFakeType>")
                .NegationResult("NotLessThanSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<ComparableFakeType>),
                        "Object is lower than [Fake(0)]")
                    .Candidate(null)
                    .AddParameter("LessThan", new ComparableFakeType()));
            AddValid(cmpInter1, cmpInter3, null)
                .Result("LessThanSpecification<ComparableInterFakeType>")
                .NegationResult("NotLessThanSpecification<ComparableInterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<ComparableInterFakeType>),
                        "Object is lower than [FluentSpecification.Tests.Mocks.ComparableInterFakeType]")
                    .Candidate(cmpInter1)
                    .AddParameter("LessThan", cmpInter3));
            AddValid(cmpFakeType, cmpFakeType2, comparer)
                .Result("LessThanSpecification<FakeType>")
                .NegationResult("NotLessThanSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<FakeType>),
                        "Object is lower than [Fake(154)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("LessThan", cmpFakeType2));
            AddValid(new FakeType {Second = "null"}, new FakeType(), comparer)
                .Result("LessThanSpecification<FakeType>")
                .NegationResult("NotLessThanSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<FakeType>), "Object is lower than [Fake(0)]")
                    .Candidate(null)
                    .AddParameter("LessThan", new FakeType()));

            ComparableFakeType notCmp1 = new ComparableFakeType {First = 11},
                notCmp2 = new ComparableFakeType {First = 10},
                notCmp3 = new ComparableFakeType {First = 10};
            FakeType notCmpFakeType1 = new FakeType {First = 11},
                notCmpFakeType2 = new FakeType {First = 10},
                notCmpFakeType3 = new FakeType {First = 10};

            AddInvalid(2, 2, null)
                .NegationResult("NotLessThanSpecification<Int32>")
                .Result("LessThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<int>), "Object is greater than or equal to [2]")
                    .Candidate(2)
                    .AddParameter("LessThan", 2));
            AddInvalid(-2, -2, null)
                .NegationResult("NotLessThanSpecification<Int32>")
                .Result("LessThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<int>), "Object is greater than or equal to [-2]")
                    .Candidate(-2)
                    .AddParameter("LessThan", -2));
            AddInvalid(1, -1, null)
                .NegationResult("NotLessThanSpecification<Int32>")
                .Result("LessThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<int>), "Object is greater than or equal to [-1]")
                    .Candidate(1)
                    .AddParameter("LessThan", -1));
            AddInvalid(5, 3, null)
                .NegationResult("NotLessThanSpecification<Int32>")
                .Result("LessThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<int>), "Object is greater than or equal to [3]")
                    .Candidate(5)
                    .AddParameter("LessThan", 3));
            AddInvalid(-1, -10, intComparer)
                .NegationResult("NotLessThanSpecification<Int32>")
                .Result("LessThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<int>), "Object is greater than or equal to [-10]")
                    .Candidate(-1)
                    .AddParameter("LessThan", -10));
            AddInvalid(3.5, 3.5, null)
                .NegationResult("NotLessThanSpecification<Double>")
                .Result("LessThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<double>),
                        "Object is greater than or equal to [3.5]")
                    .Candidate(3.5)
                    .AddParameter("LessThan", 3.5));
            AddInvalid(-3.5, -3.5, null)
                .NegationResult("NotLessThanSpecification<Double>")
                .Result("LessThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<double>),
                        "Object is greater than or equal to [-3.5]")
                    .Candidate(-3.5)
                    .AddParameter("LessThan", -3.5));
            AddInvalid(5.74, 3.74, null)
                .NegationResult("NotLessThanSpecification<Double>")
                .Result("LessThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<double>),
                        "Object is greater than or equal to [3.74]")
                    .Candidate(5.74)
                    .AddParameter("LessThan", 3.74));
            AddInvalid(-3.74, -5.74, null)
                .NegationResult("NotLessThanSpecification<Double>")
                .Result("LessThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<double>),
                        "Object is greater than or equal to [-5.74]")
                    .Candidate(-3.74)
                    .AddParameter("LessThan", -5.74));
            AddInvalid(5.74, -3.74, null)
                .NegationResult("NotLessThanSpecification<Double>")
                .Result("LessThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<double>),
                        "Object is greater than or equal to [-3.74]")
                    .Candidate(5.74)
                    .AddParameter("LessThan", -3.74));
            AddInvalid(true, false, null)
                .NegationResult("NotLessThanSpecification<Boolean>")
                .Result("LessThanSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<bool>),
                        "Object is greater than or equal to [False]")
                    .Candidate(true)
                    .AddParameter("LessThan", false));
            AddInvalid(false, false, null)
                .NegationResult("NotLessThanSpecification<Boolean>")
                .Result("LessThanSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<bool>),
                        "Object is greater than or equal to [False]")
                    .Candidate(false)
                    .AddParameter("LessThan", false));
            AddInvalid("123", "122", null)
                .NegationResult("NotLessThanSpecification<String>")
                .Result("LessThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<string>),
                        "Object is greater than or equal to [122]")
                    .Candidate("123")
                    .AddParameter("LessThan", "122"));
            AddInvalid("1234", "123", null)
                .NegationResult("NotLessThanSpecification<String>")
                .Result("LessThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<string>),
                        "Object is greater than or equal to [123]")
                    .Candidate("1234")
                    .AddParameter("LessThan", "123"));
            AddInvalid("123", "123", null)
                .NegationResult("NotLessThanSpecification<String>")
                .Result("LessThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<string>),
                        "Object is greater than or equal to [123]")
                    .Candidate("123")
                    .AddParameter("LessThan", "123"));
            AddInvalid("test1", null, null)
                .NegationResult("NotLessThanSpecification<String>")
                .Result("LessThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<string>),
                        "Object is greater than or equal to [null]")
                    .Candidate("test1")
                    .AddParameter("LessThan", null));
            AddInvalid("null", null, null)
                .NegationResult("NotLessThanSpecification<String>")
                .Result("LessThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<string>),
                        "Object is greater than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("LessThan", null));
            AddInvalid(DateTime.Parse("2019-11-15"), DateTime.Parse("2019-07-11"), null)
                .NegationResult("NotLessThanSpecification<DateTime>")
                .Result("LessThanSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<DateTime>),
                        $"Object is greater than or equal to \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-11-15"))
                    .AddParameter("LessThan", DateTime.Parse("2019-07-11")));
            AddInvalid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-11"), null)
                .NegationResult("NotLessThanSpecification<DateTime>")
                .Result("LessThanSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<DateTime>),
                        $"Object is greater than or equal to \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-11"))
                    .AddParameter("LessThan", DateTime.Parse("2019-07-11")));
            AddInvalid(notCmp1, notCmp2, null)
                .NegationResult("NotLessThanSpecification<ComparableFakeType>")
                .Result("LessThanSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<ComparableFakeType>),
                        "Object is greater than or equal to [Fake(10)]")
                    .Candidate(notCmp1)
                    .AddParameter("LessThan", notCmp2));
            AddInvalid(notCmp2, notCmp3, null)
                .NegationResult("NotLessThanSpecification<ComparableFakeType>")
                .Result("LessThanSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<ComparableFakeType>),
                        "Object is greater than or equal to [Fake(10)]")
                    .Candidate(notCmp2)
                    .AddParameter("LessThan", notCmp3));
            AddInvalid(new ComparableFakeType {Second = "null"}, null, null)
                .NegationResult("NotLessThanSpecification<ComparableFakeType>")
                .Result("LessThanSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<ComparableFakeType>),
                        "Object is greater than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("LessThan", null));
            AddInvalid(cmpInter1, cmpInter2, null)
                .NegationResult("NotLessThanSpecification<ComparableInterFakeType>")
                .Result("LessThanSpecification<ComparableInterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<ComparableInterFakeType>),
                        "Object is greater than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]")
                    .Candidate(cmpInter1)
                    .AddParameter("LessThan", cmpInter2));
            AddInvalid(notCmpFakeType1, notCmpFakeType2, comparer)
                .NegationResult("NotLessThanSpecification<FakeType>")
                .Result("LessThanSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<FakeType>),
                        "Object is greater than or equal to [Fake(10)]")
                    .Candidate(notCmpFakeType1)
                    .AddParameter("LessThan", notCmpFakeType2));
            AddInvalid(notCmpFakeType2, notCmpFakeType3, comparer)
                .NegationResult("NotLessThanSpecification<FakeType>")
                .Result("LessThanSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<FakeType>),
                        "Object is greater than or equal to [Fake(10)]")
                    .Candidate(notCmpFakeType2)
                    .AddParameter("LessThan", notCmpFakeType3));
            AddInvalid(new FakeType {Second = "null"}, null, comparer)
                .NegationResult("NotLessThanSpecification<FakeType>")
                .Result("LessThanSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<FakeType>),
                        "Object is greater than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("LessThan", null));
        }
    }
}