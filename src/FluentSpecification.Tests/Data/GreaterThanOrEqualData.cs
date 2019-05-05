using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class GreaterThanOrEqualData : SpecificationData
    {
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

            AddValid(2, 2, null)
                .Result("GreaterThanOrEqualSpecification<Int32>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<int>),
                        "Object is greater than or equal to [2]")
                    .Candidate(2)
                    .AddParameter("GreaterThan", 2));
            AddValid(-2, -2, null)
                .Result("GreaterThanOrEqualSpecification<Int32>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<int>),
                        "Object is greater than or equal to [-2]")
                    .Candidate(-2)
                    .AddParameter("GreaterThan", -2));
            AddValid(5, 1, null)
                .Result("GreaterThanOrEqualSpecification<Int32>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<int>),
                        "Object is greater than or equal to [1]")
                    .Candidate(5)
                    .AddParameter("GreaterThan", 1));
            AddValid(1, -1, null)
                .Result("GreaterThanOrEqualSpecification<Int32>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<int>),
                        "Object is greater than or equal to [-1]")
                    .Candidate(1)
                    .AddParameter("GreaterThan", -1));
            AddValid(-1, -9, intComparer)
                .Result("GreaterThanOrEqualSpecification<Int32>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<int>),
                        "Object is greater than or equal to [-9]")
                    .Candidate(-1)
                    .AddParameter("GreaterThan", -9));
            AddValid(3.5, 3.5, null)
                .Result("GreaterThanOrEqualSpecification<Double>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<double>),
                        "Object is greater than or equal to [3.5]")
                    .Candidate(3.5)
                    .AddParameter("GreaterThan", 3.5));
            AddValid(-3.5, -3.5, null)
                .Result("GreaterThanOrEqualSpecification<Double>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<double>),
                        "Object is greater than or equal to [-3.5]")
                    .Candidate(-3.5)
                    .AddParameter("GreaterThan", -3.5));
            AddValid(5.75, 5.74, null)
                .Result("GreaterThanOrEqualSpecification<Double>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<double>),
                        "Object is greater than or equal to [5.74]")
                    .Candidate(5.75)
                    .AddParameter("GreaterThan", 5.74));
            AddValid(0.0, -2.5, null)
                .Result("GreaterThanOrEqualSpecification<Double>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<double>),
                        "Object is greater than or equal to [-2.5]")
                    .Candidate(0.0)
                    .AddParameter("GreaterThan", -2.5));
            AddValid(-5.74, -5.75, null)
                .Result("GreaterThanOrEqualSpecification<Double>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<double>),
                        "Object is greater than or equal to [-5.75]")
                    .Candidate(-5.74)
                    .AddParameter("GreaterThan", -5.75));
            AddValid(false, false, null)
                .Result("GreaterThanOrEqualSpecification<Boolean>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<bool>),
                        "Object is greater than or equal to [False]")
                    .Candidate(false)
                    .AddParameter("GreaterThan", false));
            AddValid(true, false, null)
                .Result("GreaterThanOrEqualSpecification<Boolean>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<bool>),
                        "Object is greater than or equal to [False]")
                    .Candidate(true)
                    .AddParameter("GreaterThan", false));
            AddValid("124", "123", null)
                .Result("GreaterThanOrEqualSpecification<String>")
                .NegationResult("NotGreaterThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<string>),
                        "Object is greater than or equal to [123]")
                    .Candidate("124")
                    .AddParameter("GreaterThan", "123"));
            AddValid("1234", "123", null)
                .Result("GreaterThanOrEqualSpecification<String>")
                .NegationResult("NotGreaterThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<string>),
                        "Object is greater than or equal to [123]")
                    .Candidate("1234")
                    .AddParameter("GreaterThan", "123"));
            AddValid("123", "123", null)
                .Result("GreaterThanOrEqualSpecification<String>")
                .NegationResult("NotGreaterThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<string>),
                        "Object is greater than or equal to [123]")
                    .Candidate("123")
                    .AddParameter("GreaterThan", "123"));
            AddValid("test1", null, null)
                .Result("GreaterThanOrEqualSpecification<String>")
                .NegationResult("NotGreaterThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<string>),
                        "Object is greater than or equal to [null]")
                    .Candidate("test1")
                    .AddParameter("GreaterThan", null));
            AddValid("null", null, null)
                .Result("GreaterThanOrEqualSpecification<String>")
                .NegationResult("NotGreaterThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<string>),
                        "Object is greater than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", null));
            AddValid(DateTime.Parse("2019-07-11"), DateTime.Parse("2018-01-15"), null)
                .Result("GreaterThanOrEqualSpecification<DateTime>")
                .NegationResult("NotGreaterThanOrEqualSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<DateTime>),
                        $"Object is greater than or equal to \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-11"))
                    .AddParameter("GreaterThan", DateTime.Parse("2018-01-15")));
            AddValid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-01"), null)
                .Result("GreaterThanOrEqualSpecification<DateTime>")
                .NegationResult("NotGreaterThanOrEqualSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<DateTime>),
                        $"Object is greater than or equal to \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-11"))
                    .AddParameter("GreaterThan", DateTime.Parse("2019-07-01")));
            AddValid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-11"), null)
                .Result("GreaterThanOrEqualSpecification<DateTime>")
                .NegationResult("NotGreaterThanOrEqualSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<DateTime>),
                        $"Object is greater than or equal to \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-11"))
                    .AddParameter("GreaterThan", DateTime.Parse("2019-07-11")));
            AddValid(cmp, cmp2, null)
                .Result("GreaterThanOrEqualSpecification<ComparableFakeType>")
                .NegationResult("NotGreaterThanOrEqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                        "Object is greater than or equal to [Fake(116)]")
                    .Candidate(cmp)
                    .AddParameter("GreaterThan", cmp2));
            AddValid(cmp3, cmp4, null)
                .Result("GreaterThanOrEqualSpecification<ComparableFakeType>")
                .NegationResult("NotGreaterThanOrEqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                        "Object is greater than or equal to [Fake(11)]")
                    .Candidate(cmp3)
                    .AddParameter("GreaterThan", cmp4));
            AddValid(new ComparableFakeType {Second = "null"}, null, null)
                .Result("GreaterThanOrEqualSpecification<ComparableFakeType>")
                .NegationResult("NotGreaterThanOrEqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                        "Object is greater than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", null));
            AddValid(cmpInter1, cmpInter3, null)
                .Result("GreaterThanOrEqualSpecification<ComparableInterFakeType>")
                .NegationResult("NotGreaterThanOrEqualSpecification<ComparableInterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<ComparableInterFakeType>),
                        "Object is greater than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]")
                    .Candidate(cmpInter1)
                    .AddParameter("GreaterThan", cmpInter3));
            AddValid(cmpInter1, cmpInter2, null)
                .Result("GreaterThanOrEqualSpecification<ComparableInterFakeType>")
                .NegationResult("NotGreaterThanOrEqualSpecification<ComparableInterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<ComparableInterFakeType>),
                        "Object is greater than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]")
                    .Candidate(cmpInter1)
                    .AddParameter("GreaterThan", cmpInter2));
            AddValid(cmpFakeType, cmpFakeType2, comparer)
                .Result("GreaterThanOrEqualSpecification<FakeType>")
                .NegationResult("NotGreaterThanOrEqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<FakeType>),
                        "Object is greater than or equal to [Fake(116)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("GreaterThan", cmpFakeType2));
            AddValid(cmpFakeType3, cmpFakeType4, comparer)
                .Result("GreaterThanOrEqualSpecification<FakeType>")
                .NegationResult("NotGreaterThanOrEqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<FakeType>),
                        "Object is greater than or equal to [Fake(11)]")
                    .Candidate(cmpFakeType3)
                    .AddParameter("GreaterThan", cmpFakeType4));
            AddValid(new FakeType {Second = "null"}, null, comparer)
                .Result("GreaterThanOrEqualSpecification<FakeType>")
                .NegationResult("NotGreaterThanOrEqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<FakeType>),
                        "Object is greater than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", null));

            var notCmp1 = new ComparableFakeType {First = 10};
            var notCmpFakeType1 = new FakeType {First = 10};

            AddInvalid(-1, 1, null)
                .NegationResult("NotGreaterThanOrEqualSpecification<Int32>")
                .Result("GreaterThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<int>), "Object is lower than [1]")
                    .Candidate(-1)
                    .AddParameter("GreaterThan", 1));
            AddInvalid(3, 5, null)
                .NegationResult("NotGreaterThanOrEqualSpecification<Int32>")
                .Result("GreaterThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<int>), "Object is lower than [5]")
                    .Candidate(3)
                    .AddParameter("GreaterThan", 5));
            AddInvalid(-10, -1, intComparer)
                .NegationResult("NotGreaterThanOrEqualSpecification<Int32>")
                .Result("GreaterThanOrEqualSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<int>), "Object is lower than [-1]")
                    .Candidate(-10)
                    .AddParameter("GreaterThan", -1));
            AddInvalid(3.74, 5.74, null)
                .NegationResult("NotGreaterThanOrEqualSpecification<Double>")
                .Result("GreaterThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<double>), "Object is lower than [5.74]")
                    .Candidate(3.74)
                    .AddParameter("GreaterThan", 5.74));
            AddInvalid(-5.74, -3.74, null)
                .NegationResult("NotGreaterThanOrEqualSpecification<Double>")
                .Result("GreaterThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<double>),
                        "Object is lower than [-3.74]")
                    .Candidate(-5.74)
                    .AddParameter("GreaterThan", -3.74));
            AddInvalid(-3.74, 5.74, null)
                .NegationResult("NotGreaterThanOrEqualSpecification<Double>")
                .Result("GreaterThanOrEqualSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<double>), "Object is lower than [5.74]")
                    .Candidate(-3.74)
                    .AddParameter("GreaterThan", 5.74));
            AddInvalid(false, true, null)
                .NegationResult("NotGreaterThanOrEqualSpecification<Boolean>")
                .Result("GreaterThanOrEqualSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<bool>), "Object is lower than [True]")
                    .Candidate(false)
                    .AddParameter("GreaterThan", true));
            AddInvalid("122", "123", null)
                .NegationResult("NotGreaterThanOrEqualSpecification<String>")
                .Result("GreaterThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<string>), "Object is lower than [123]")
                    .Candidate("122")
                    .AddParameter("GreaterThan", "123"));
            AddInvalid("123", "1234", null)
                .NegationResult("NotGreaterThanOrEqualSpecification<String>")
                .Result("GreaterThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<string>), "Object is lower than [1234]")
                    .Candidate("123")
                    .AddParameter("GreaterThan", "1234"));
            AddInvalid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-11-15"), null)
                .NegationResult("NotGreaterThanOrEqualSpecification<DateTime>")
                .Result("GreaterThanOrEqualSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<DateTime>),
                        $"Object is lower than \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-11"))
                    .AddParameter("GreaterThan", DateTime.Parse("2019-11-15")));
            AddInvalid(notCmp1, cmp3, null)
                .NegationResult("NotGreaterThanOrEqualSpecification<ComparableFakeType>")
                .Result("GreaterThanOrEqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                        "Object is lower than [Fake(11)]")
                    .Candidate(notCmp1)
                    .AddParameter("GreaterThan", cmp3));
            AddInvalid("null", "test", null)
                .NegationResult("NotGreaterThanOrEqualSpecification<String>")
                .Result("GreaterThanOrEqualSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<string>), "Object is lower than [test]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", "test"));
            AddInvalid(new ComparableFakeType {Second = "null"}, new ComparableFakeType(), null)
                .NegationResult("NotGreaterThanOrEqualSpecification<ComparableFakeType>")
                .Result("GreaterThanOrEqualSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                        "Object is lower than [Fake(0)]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", new ComparableFakeType()));
            AddInvalid(notCmpFakeType1, cmpFakeType3, comparer)
                .NegationResult("NotGreaterThanOrEqualSpecification<FakeType>")
                .Result("GreaterThanOrEqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<FakeType>),
                        "Object is lower than [Fake(11)]")
                    .Candidate(notCmpFakeType1)
                    .AddParameter("GreaterThan", cmpFakeType3));
            AddInvalid(new FakeType {Second = "null"}, new FakeType(), comparer)
                .NegationResult("NotGreaterThanOrEqualSpecification<FakeType>")
                .Result("GreaterThanOrEqualSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<FakeType>),
                        "Object is lower than [Fake(0)]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", new FakeType()));
        }
    }
}