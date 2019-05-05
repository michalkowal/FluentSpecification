using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class GreaterThanData : SpecificationData
    {
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

            AddValid(5, 1, null)
                .Result("GreaterThanSpecification<Int32>")
                .NegationResult("NotGreaterThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<int>), "Object is greater than [1]")
                    .Candidate(5)
                    .AddParameter("GreaterThan", 1));
            AddValid(1, -1, null)
                .Result("GreaterThanSpecification<Int32>")
                .NegationResult("NotGreaterThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<int>), "Object is greater than [-1]")
                    .Candidate(1)
                    .AddParameter("GreaterThan", -1));
            AddValid(-1, -9, intComparer)
                .Result("GreaterThanSpecification<Int32>")
                .NegationResult("NotGreaterThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<int>), "Object is greater than [-9]")
                    .Candidate(-1)
                    .AddParameter("GreaterThan", -9));
            AddValid(5.75, 5.74, null)
                .Result("GreaterThanSpecification<Double>")
                .NegationResult("NotGreaterThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<double>), "Object is greater than [5.74]")
                    .Candidate(5.75)
                    .AddParameter("GreaterThan", 5.74));
            AddValid(0.0, -2.5, null)
                .Result("GreaterThanSpecification<Double>")
                .NegationResult("NotGreaterThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<double>), "Object is greater than [-2.5]")
                    .Candidate(0.0)
                    .AddParameter("GreaterThan", -2.5));
            AddValid(-5.74, -5.75, null)
                .Result("GreaterThanSpecification<Double>")
                .NegationResult("NotGreaterThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<double>), "Object is greater than [-5.75]")
                    .Candidate(-5.74)
                    .AddParameter("GreaterThan", -5.75));
            AddValid(true, false, null)
                .Result("GreaterThanSpecification<Boolean>")
                .NegationResult("NotGreaterThanSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<bool>), "Object is greater than [False]")
                    .Candidate(true)
                    .AddParameter("GreaterThan", false));
            AddValid("124", "123", null)
                .Result("GreaterThanSpecification<String>")
                .NegationResult("NotGreaterThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<string>), "Object is greater than [123]")
                    .Candidate("124")
                    .AddParameter("GreaterThan", "123"));
            AddValid("1234", "123", null)
                .Result("GreaterThanSpecification<String>")
                .NegationResult("NotGreaterThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<string>), "Object is greater than [123]")
                    .Candidate("1234")
                    .AddParameter("GreaterThan", "123"));
            AddValid("test1", null, null)
                .Result("GreaterThanSpecification<String>")
                .NegationResult("NotGreaterThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<string>), "Object is greater than [null]")
                    .Candidate("test1")
                    .AddParameter("GreaterThan", null));
            AddValid(DateTime.Parse("2019-07-11"), DateTime.Parse("2018-01-15"), null)
                .Result("GreaterThanSpecification<DateTime>")
                .NegationResult("NotGreaterThanSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<DateTime>),
                        $"Object is greater than \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-11"))
                    .AddParameter("GreaterThan", DateTime.Parse("2018-01-15")));
            AddValid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-01"), null)
                .Result("GreaterThanSpecification<DateTime>")
                .NegationResult("NotGreaterThanSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<DateTime>),
                        $"Object is greater than \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-11"))
                    .AddParameter("GreaterThan", DateTime.Parse("2019-07-01")));
            AddValid(cmp, cmp2, null)
                .Result("GreaterThanSpecification<ComparableFakeType>")
                .NegationResult("NotGreaterThanSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<ComparableFakeType>),
                        "Object is greater than [Fake(116)]")
                    .Candidate(cmp)
                    .AddParameter("GreaterThan", cmp2));
            AddValid(cmpInter1, cmpInter3, null)
                .Result("GreaterThanSpecification<ComparableInterFakeType>")
                .NegationResult("NotGreaterThanSpecification<ComparableInterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<ComparableInterFakeType>),
                        "Object is greater than [FluentSpecification.Tests.Mocks.ComparableInterFakeType]")
                    .Candidate(cmpInter1)
                    .AddParameter("GreaterThan", cmpInter3));
            AddValid(cmpFakeType, cmpFakeType2, comparer)
                .Result("GreaterThanSpecification<FakeType>")
                .NegationResult("NotGreaterThanSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<FakeType>),
                        "Object is greater than [Fake(116)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("GreaterThan", cmpFakeType2));

            ComparableFakeType notCmp1 = new ComparableFakeType {First = 10},
                notCmp2 = new ComparableFakeType {First = 10},
                notCmp3 = new ComparableFakeType {First = 11};
            FakeType notCmpFakeType1 = new FakeType {First = 10},
                notCmpFakeType2 = new FakeType {First = 10},
                notCmpFakeType3 = new FakeType {First = 11};

            AddInvalid(2, 2, null)
                .NegationResult("NotGreaterThanSpecification<Int32>")
                .Result("GreaterThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<int>), "Object is lower than or equal to [2]")
                    .Candidate(2)
                    .AddParameter("GreaterThan", 2));
            AddInvalid(-2, -2, null)
                .NegationResult("NotGreaterThanSpecification<Int32>")
                .Result("GreaterThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<int>), "Object is lower than or equal to [-2]")
                    .Candidate(-2)
                    .AddParameter("GreaterThan", -2));
            AddInvalid(-1, 1, null)
                .NegationResult("NotGreaterThanSpecification<Int32>")
                .Result("GreaterThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<int>), "Object is lower than or equal to [1]")
                    .Candidate(-1)
                    .AddParameter("GreaterThan", 1));
            AddInvalid(3, 5, null)
                .NegationResult("NotGreaterThanSpecification<Int32>")
                .Result("GreaterThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<int>), "Object is lower than or equal to [5]")
                    .Candidate(3)
                    .AddParameter("GreaterThan", 5));
            AddInvalid(-10, -1, intComparer)
                .NegationResult("NotGreaterThanSpecification<Int32>")
                .Result("GreaterThanSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<int>), "Object is lower than or equal to [-1]")
                    .Candidate(-10)
                    .AddParameter("GreaterThan", -1));
            AddInvalid(3.5, 3.5, null)
                .NegationResult("NotGreaterThanSpecification<Double>")
                .Result("GreaterThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<double>),
                        "Object is lower than or equal to [3.5]")
                    .Candidate(3.5)
                    .AddParameter("GreaterThan", 3.5));
            AddInvalid(-3.5, -3.5, null)
                .NegationResult("NotGreaterThanSpecification<Double>")
                .Result("GreaterThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<double>),
                        "Object is lower than or equal to [-3.5]")
                    .Candidate(-3.5)
                    .AddParameter("GreaterThan", -3.5));
            AddInvalid(3.74, 5.74, null)
                .NegationResult("NotGreaterThanSpecification<Double>")
                .Result("GreaterThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<double>),
                        "Object is lower than or equal to [5.74]")
                    .Candidate(3.74)
                    .AddParameter("GreaterThan", 5.74));
            AddInvalid(-5.74, -3.74, null)
                .NegationResult("NotGreaterThanSpecification<Double>")
                .Result("GreaterThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<double>),
                        "Object is lower than or equal to [-3.74]")
                    .Candidate(-5.74)
                    .AddParameter("GreaterThan", -3.74));
            AddInvalid(-3.74, 5.74, null)
                .NegationResult("NotGreaterThanSpecification<Double>")
                .Result("GreaterThanSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<double>),
                        "Object is lower than or equal to [5.74]")
                    .Candidate(-3.74)
                    .AddParameter("GreaterThan", 5.74));
            AddInvalid(false, true, null)
                .NegationResult("NotGreaterThanSpecification<Boolean>")
                .Result("GreaterThanSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<bool>),
                        "Object is lower than or equal to [True]")
                    .Candidate(false)
                    .AddParameter("GreaterThan", true));
            AddInvalid(false, false, null)
                .NegationResult("NotGreaterThanSpecification<Boolean>")
                .Result("GreaterThanSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<bool>),
                        "Object is lower than or equal to [False]")
                    .Candidate(false)
                    .AddParameter("GreaterThan", false));
            AddInvalid("122", "123", null)
                .NegationResult("NotGreaterThanSpecification<String>")
                .Result("GreaterThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<string>),
                        "Object is lower than or equal to [123]")
                    .Candidate("122")
                    .AddParameter("GreaterThan", "123"));
            AddInvalid("123", "1234", null)
                .NegationResult("NotGreaterThanSpecification<String>")
                .Result("GreaterThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<string>),
                        "Object is lower than or equal to [1234]")
                    .Candidate("123")
                    .AddParameter("GreaterThan", "1234"));
            AddInvalid("123", "123", null)
                .NegationResult("NotGreaterThanSpecification<String>")
                .Result("GreaterThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<string>),
                        "Object is lower than or equal to [123]")
                    .Candidate("123")
                    .AddParameter("GreaterThan", "123"));
            AddInvalid("null", null, null)
                .NegationResult("NotGreaterThanSpecification<String>")
                .Result("GreaterThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<string>),
                        "Object is lower than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", null));
            AddInvalid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-11-15"), null)
                .NegationResult("NotGreaterThanSpecification<DateTime>")
                .Result("GreaterThanSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<DateTime>),
                        $"Object is lower than or equal to \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-11"))
                    .AddParameter("GreaterThan", DateTime.Parse("2019-11-15")));
            AddInvalid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-11"), null)
                .NegationResult("NotGreaterThanSpecification<DateTime>")
                .Result("GreaterThanSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<DateTime>),
                        $"Object is lower than or equal to \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-11"))
                    .AddParameter("GreaterThan", DateTime.Parse("2019-07-11")));
            AddInvalid(notCmp1, notCmp2, null)
                .NegationResult("NotGreaterThanSpecification<ComparableFakeType>")
                .Result("GreaterThanSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<ComparableFakeType>),
                        "Object is lower than or equal to [Fake(10)]")
                    .Candidate(notCmp1)
                    .AddParameter("GreaterThan", notCmp2));
            AddInvalid(notCmp2, notCmp3, null)
                .NegationResult("NotGreaterThanSpecification<ComparableFakeType>")
                .Result("GreaterThanSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<ComparableFakeType>),
                        "Object is lower than or equal to [Fake(11)]")
                    .Candidate(notCmp2)
                    .AddParameter("GreaterThan", notCmp3));
            AddInvalid("null", "test", null)
                .NegationResult("NotGreaterThanSpecification<String>")
                .Result("GreaterThanSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<string>),
                        "Object is lower than or equal to [test]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", "test"));
            AddInvalid(new ComparableFakeType {Second = "null"}, new ComparableFakeType(), null)
                .NegationResult("NotGreaterThanSpecification<ComparableFakeType>")
                .Result("GreaterThanSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<ComparableFakeType>),
                        "Object is lower than or equal to [Fake(0)]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", new ComparableFakeType()));
            AddInvalid(new ComparableFakeType {Second = "null"}, null, null)
                .NegationResult("NotGreaterThanSpecification<ComparableFakeType>")
                .Result("GreaterThanSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<ComparableFakeType>),
                        "Object is lower than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", null));
            AddInvalid(cmpInter1, cmpInter2, null)
                .NegationResult("NotGreaterThanSpecification<ComparableInterFakeType>")
                .Result("GreaterThanSpecification<ComparableInterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<ComparableInterFakeType>),
                        "Object is lower than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]")
                    .Candidate(cmpInter1)
                    .AddParameter("GreaterThan", cmpInter2));
            AddInvalid(notCmpFakeType1, notCmpFakeType2, comparer)
                .NegationResult("NotGreaterThanSpecification<FakeType>")
                .Result("GreaterThanSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<FakeType>),
                        "Object is lower than or equal to [Fake(10)]")
                    .Candidate(notCmpFakeType1)
                    .AddParameter("GreaterThan", notCmpFakeType2));
            AddInvalid(notCmpFakeType2, notCmpFakeType3, comparer)
                .NegationResult("NotGreaterThanSpecification<FakeType>")
                .Result("GreaterThanSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<FakeType>),
                        "Object is lower than or equal to [Fake(11)]")
                    .Candidate(notCmpFakeType2)
                    .AddParameter("GreaterThan", notCmpFakeType3));
            AddInvalid(new FakeType {Second = "null"}, new FakeType(), comparer)
                .NegationResult("NotGreaterThanSpecification<FakeType>")
                .Result("GreaterThanSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<FakeType>),
                        "Object is lower than or equal to [Fake(0)]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", new FakeType()));
            AddInvalid(new FakeType {Second = "null"}, null, comparer)
                .NegationResult("NotGreaterThanSpecification<FakeType>")
                .Result("GreaterThanSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<FakeType>),
                        "Object is lower than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", null));
        }
    }
}