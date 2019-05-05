using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class ExclusiveBetweenData : SpecificationData
    {
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

            AddValid(1, 0, 5, null)
                .Result("ExclusiveBetweenSpecification<Int32>")
                .NegationResult("NotExclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<int>), "Value is between [0] and [5]")
                    .Candidate(1)
                    .AddParameter("From", 0)
                    .AddParameter("To", 5));
            AddValid(-1, -5, 1, null)
                .Result("ExclusiveBetweenSpecification<Int32>")
                .NegationResult("NotExclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<int>), "Value is between [-5] and [1]")
                    .Candidate(-1)
                    .AddParameter("From", -5)
                    .AddParameter("To", 1));
            AddValid(-9, -24, -1, intComparer)
                .Result("ExclusiveBetweenSpecification<Int32>")
                .NegationResult("NotExclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<int>), "Value is between [-24] and [-1]")
                    .Candidate(-9)
                    .AddParameter("From", -24)
                    .AddParameter("To", -1));
            AddValid(5.74, 5.73, 5.75, null)
                .Result("ExclusiveBetweenSpecification<Double>")
                .NegationResult("NotExclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<double>),
                        "Value is between [5.73] and [5.75]")
                    .Candidate(5.74)
                    .AddParameter("From", 5.73)
                    .AddParameter("To", 5.75));
            AddValid(-2.5, -3.0, 0.0, null)
                .Result("ExclusiveBetweenSpecification<Double>")
                .NegationResult("NotExclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<double>), "Value is between [-3] and [0]")
                    .Candidate(-2.5)
                    .AddParameter("From", -3.0)
                    .AddParameter("To", 0.0));
            AddValid(-5.75, -5.76, -5.74, null)
                .Result("ExclusiveBetweenSpecification<Double>")
                .NegationResult("NotExclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<double>),
                        "Value is between [-5.76] and [-5.74]")
                    .Candidate(-5.75)
                    .AddParameter("From", -5.76)
                    .AddParameter("To", -5.74));
            AddValid("123", "122", "124", null)
                .Result("ExclusiveBetweenSpecification<String>")
                .NegationResult("NotExclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<string>),
                        "Value is between [122] and [124]")
                    .Candidate("123")
                    .AddParameter("From", "122")
                    .AddParameter("To", "124"));
            AddValid("123", "12", "1234", null)
                .Result("ExclusiveBetweenSpecification<String>")
                .NegationResult("NotExclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<string>),
                        "Value is between [12] and [1234]")
                    .Candidate("123")
                    .AddParameter("From", "12")
                    .AddParameter("To", "1234"));
            AddValid("test", null, "test1", null)
                .Result("ExclusiveBetweenSpecification<String>")
                .NegationResult("NotExclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<string>),
                        "Value is between [null] and [test1]")
                    .Candidate("test")
                    .AddParameter("From", null)
                    .AddParameter("To", "test1"));
            AddValid(DateTime.Parse("2018-01-15"), DateTime.Parse("2017-05-16"), DateTime.Parse("2019-07-11"), null)
                .Result("ExclusiveBetweenSpecification<DateTime>")
                .NegationResult("NotExclusiveBetweenSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<DateTime>),
                        $"Value is between \\[{DateTimeRegexPattern}\\] and \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2018-01-15"))
                    .AddParameter("From", DateTime.Parse("2017-05-16"))
                    .AddParameter("To", DateTime.Parse("2019-07-11")));
            AddValid(DateTime.Parse("2019-07-05"), DateTime.Parse("2019-07-01"), DateTime.Parse("2019-07-11"), null)
                .Result("ExclusiveBetweenSpecification<DateTime>")
                .NegationResult("NotExclusiveBetweenSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<DateTime>),
                        $"Value is between \\[{DateTimeRegexPattern}\\] and \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-05"))
                    .AddParameter("From", DateTime.Parse("2019-07-01"))
                    .AddParameter("To", DateTime.Parse("2019-07-11")));
            AddValid(cmp, cmpFrom, cmpTo, null)
                .Result("ExclusiveBetweenSpecification<ComparableFakeType>")
                .NegationResult("NotExclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is between [Fake(1)] and [Fake(30)]")
                    .Candidate(cmp)
                    .AddParameter("From", cmpFrom)
                    .AddParameter("To", cmpTo));
            AddValid(cmp, null, cmpTo, null)
                .Result("ExclusiveBetweenSpecification<ComparableFakeType>")
                .NegationResult("NotExclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is between [null] and [Fake(30)]")
                    .Candidate(cmp)
                    .AddParameter("From", null)
                    .AddParameter("To", cmpTo));
            AddValid(cmpFakeType, cmpFromFakeType, cmpToFakeType, comparer)
                .Result("ExclusiveBetweenSpecification<FakeType>")
                .NegationResult("NotExclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<FakeType>),
                        "Value is between [Fake(1)] and [Fake(30)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("From", cmpFromFakeType)
                    .AddParameter("To", cmpToFakeType));
            AddValid(cmpFakeType, null, cmpToFakeType, comparer)
                .Result("ExclusiveBetweenSpecification<FakeType>")
                .NegationResult("NotExclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<FakeType>),
                        "Value is between [null] and [Fake(30)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("From", null)
                    .AddParameter("To", cmpToFakeType));

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

            AddInvalid(2, 2, 3, null)
                .NegationResult("NotExclusiveBetweenSpecification<Int32>")
                .Result("ExclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<int>), "Value is not between [2] and [3]")
                    .Candidate(2)
                    .AddParameter("From", 2)
                    .AddParameter("To", 3));
            AddInvalid(-2, -3, -2, null)
                .NegationResult("NotExclusiveBetweenSpecification<Int32>")
                .Result("ExclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<int>),
                        "Value is not between [-3] and [-2]")
                    .Candidate(-2)
                    .AddParameter("From", -3)
                    .AddParameter("To", -2));
            AddInvalid(1, -3, -1, null)
                .NegationResult("NotExclusiveBetweenSpecification<Int32>")
                .Result("ExclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<int>),
                        "Value is not between [-3] and [-1]")
                    .Candidate(1)
                    .AddParameter("From", -3)
                    .AddParameter("To", -1));
            AddInvalid(5, 1, 3, null)
                .NegationResult("NotExclusiveBetweenSpecification<Int32>")
                .Result("ExclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<int>), "Value is not between [1] and [3]")
                    .Candidate(5)
                    .AddParameter("From", 1)
                    .AddParameter("To", 3));
            AddInvalid(-1, -10, -5, intComparer)
                .NegationResult("NotExclusiveBetweenSpecification<Int32>")
                .Result("ExclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<int>),
                        "Value is not between [-10] and [-5]")
                    .Candidate(-1)
                    .AddParameter("From", -10)
                    .AddParameter("To", -5));
            AddInvalid(3.5, 3.5, 3.5, null)
                .NegationResult("NotExclusiveBetweenSpecification<Double>")
                .Result("ExclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<double>),
                        "Value is not between [3.5] and [3.5]")
                    .Candidate(3.5)
                    .AddParameter("From", 3.5)
                    .AddParameter("To", 3.5));
            AddInvalid(-3.5, -3.5, -3.5, null)
                .NegationResult("NotExclusiveBetweenSpecification<Double>")
                .Result("ExclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<double>),
                        "Value is not between [-3.5] and [-3.5]")
                    .Candidate(-3.5)
                    .AddParameter("From", -3.5)
                    .AddParameter("To", -3.5));
            AddInvalid(5.74, 2.74, 3.74, null)
                .NegationResult("NotExclusiveBetweenSpecification<Double>")
                .Result("ExclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<double>),
                        "Value is not between [2.74] and [3.74]")
                    .Candidate(5.74)
                    .AddParameter("From", 2.74)
                    .AddParameter("To", 3.74));
            AddInvalid(-3.74, -7.74, -5.74, null)
                .NegationResult("NotExclusiveBetweenSpecification<Double>")
                .Result("ExclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<double>),
                        "Value is not between [-7.74] and [-5.74]")
                    .Candidate(-3.74)
                    .AddParameter("From", -7.74)
                    .AddParameter("To", -5.74));
            AddInvalid(5.74, -3.74, 5.73, null)
                .NegationResult("NotExclusiveBetweenSpecification<Double>")
                .Result("ExclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<double>),
                        "Value is not between [-3.74] and [5.73]")
                    .Candidate(5.74)
                    .AddParameter("From", -3.74)
                    .AddParameter("To", 5.73));
            AddInvalid(false, false, true, null)
                .NegationResult("NotExclusiveBetweenSpecification<Boolean>")
                .Result("ExclusiveBetweenSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<bool>),
                        "Value is not between [False] and [True]")
                    .Candidate(false)
                    .AddParameter("From", false)
                    .AddParameter("To", true));
            AddInvalid("123", "121", "122", null)
                .NegationResult("NotExclusiveBetweenSpecification<String>")
                .Result("ExclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<string>),
                        "Value is not between [121] and [122]")
                    .Candidate("123")
                    .AddParameter("From", "121")
                    .AddParameter("To", "122"));
            AddInvalid("1234", "122", "1233", null)
                .NegationResult("NotExclusiveBetweenSpecification<String>")
                .Result("ExclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<string>),
                        "Value is not between [122] and [1233]")
                    .Candidate("1234")
                    .AddParameter("From", "122")
                    .AddParameter("To", "1233"));
            AddInvalid("123", "123", "124", null)
                .NegationResult("NotExclusiveBetweenSpecification<String>")
                .Result("ExclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<string>),
                        "Value is not between [123] and [124]")
                    .Candidate("123")
                    .AddParameter("From", "123")
                    .AddParameter("To", "124"));
            AddInvalid("null", "test", "test1", null)
                .NegationResult("NotExclusiveBetweenSpecification<String>")
                .Result("ExclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<string>),
                        "Value is not between [test] and [test1]")
                    .Candidate(null)
                    .AddParameter("From", "test")
                    .AddParameter("To", "test1"));
            AddInvalid("null", null, "test", null)
                .NegationResult("NotExclusiveBetweenSpecification<String>")
                .Result("ExclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<string>),
                        "Value is not between [null] and [test]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", "test"));
            AddInvalid("null", null, null, null)
                .NegationResult("NotExclusiveBetweenSpecification<String>")
                .Result("ExclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<string>),
                        "Value is not between [null] and [null]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", null));
            AddInvalid(DateTime.Parse("2019-11-15"), DateTime.Parse("2019-07-11"), DateTime.Parse("2019-11-15"), null)
                .NegationResult("NotExclusiveBetweenSpecification<DateTime>")
                .Result("ExclusiveBetweenSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<DateTime>),
                        $"Value is not between \\[{DateTimeRegexPattern}\\] and \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-11-15"))
                    .AddParameter("From", DateTime.Parse("2019-07-11"))
                    .AddParameter("To", DateTime.Parse("2019-11-15")));
            AddInvalid(DateTime.Parse("2019-11-15"), DateTime.Parse("2019-12-11"), DateTime.Parse("2019-12-15"), null)
                .NegationResult("NotExclusiveBetweenSpecification<DateTime>")
                .Result("ExclusiveBetweenSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<DateTime>),
                        $"Value is not between \\[{DateTimeRegexPattern}\\] and \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-11-15"))
                    .AddParameter("From", DateTime.Parse("2019-12-11"))
                    .AddParameter("To", DateTime.Parse("2019-12-15")));
            AddInvalid(cmp, notCmp1, notCmp2, null)
                .NegationResult("NotExclusiveBetweenSpecification<ComparableFakeType>")
                .Result("ExclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is not between [Fake(10)] and [Fake(15)]")
                    .Candidate(cmp)
                    .AddParameter("From", notCmp1)
                    .AddParameter("To", notCmp2));
            AddInvalid(cmp, notCmp3, notCmp4, null)
                .NegationResult("NotExclusiveBetweenSpecification<ComparableFakeType>")
                .Result("ExclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is not between [Fake(1)] and [Fake(3)]")
                    .Candidate(cmp)
                    .AddParameter("From", notCmp3)
                    .AddParameter("To", notCmp4));
            AddInvalid(cmp, notCmp5, notCmp6, null)
                .NegationResult("NotExclusiveBetweenSpecification<ComparableFakeType>")
                .Result("ExclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is not between [Fake(23)] and [Fake(30)]")
                    .Candidate(cmp)
                    .AddParameter("From", notCmp5)
                    .AddParameter("To", notCmp6));
            AddInvalid(cmpInter1, cmpInter2, cmpInter3, null)
                .NegationResult("NotExclusiveBetweenSpecification<ComparableInterFakeType>")
                .Result("ExclusiveBetweenSpecification<ComparableInterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<ComparableInterFakeType>),
                        "Value is not between [FluentSpecification.Tests.Mocks.ComparableInterFakeType] and [FluentSpecification.Tests.Mocks.ComparableInterFakeType]")
                    .Candidate(cmpInter1)
                    .AddParameter("From", cmpInter2)
                    .AddParameter("To", cmpInter3));
            AddInvalid(new ComparableFakeType {Second = "null"}, notCmp1, notCmp2, null)
                .NegationResult("NotExclusiveBetweenSpecification<ComparableFakeType>")
                .Result("ExclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is not between [Fake(10)] and [Fake(15)]")
                    .Candidate(null)
                    .AddParameter("From", notCmp1)
                    .AddParameter("To", notCmp2));
            AddInvalid(new ComparableFakeType {Second = "null"}, null, notCmp2, null)
                .NegationResult("NotExclusiveBetweenSpecification<ComparableFakeType>")
                .Result("ExclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is not between [null] and [Fake(15)]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", notCmp2));
            AddInvalid(new ComparableFakeType {Second = "null"}, null, null, null)
                .NegationResult("NotExclusiveBetweenSpecification<ComparableFakeType>")
                .Result("ExclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is not between [null] and [null]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", null));
            AddInvalid(cmpFakeType, notCmpFakeType1, notCmpFakeType2, comparer)
                .NegationResult("NotExclusiveBetweenSpecification<FakeType>")
                .Result("ExclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<FakeType>),
                        "Value is not between [Fake(10)] and [Fake(15)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("From", notCmpFakeType1)
                    .AddParameter("To", notCmpFakeType2));
            AddInvalid(cmpFakeType, notCmpFakeType3, notCmpFakeType4, comparer)
                .NegationResult("NotExclusiveBetweenSpecification<FakeType>")
                .Result("ExclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<FakeType>),
                        "Value is not between [Fake(1)] and [Fake(3)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("From", notCmpFakeType3)
                    .AddParameter("To", notCmpFakeType4));
            AddInvalid(cmpFakeType, notCmpFakeType5, notCmpFakeType6, comparer)
                .NegationResult("NotExclusiveBetweenSpecification<FakeType>")
                .Result("ExclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<FakeType>),
                        "Value is not between [Fake(23)] and [Fake(30)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("From", notCmpFakeType5)
                    .AddParameter("To", notCmpFakeType6));
            AddInvalid(new FakeType {Second = "null"}, notCmpFakeType1, notCmpFakeType2, comparer)
                .NegationResult("NotExclusiveBetweenSpecification<FakeType>")
                .Result("ExclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<FakeType>),
                        "Value is not between [Fake(10)] and [Fake(15)]")
                    .Candidate(null)
                    .AddParameter("From", notCmpFakeType1)
                    .AddParameter("To", notCmpFakeType2));
            AddInvalid(new FakeType {Second = "null"}, null, notCmpFakeType2, comparer)
                .NegationResult("NotExclusiveBetweenSpecification<FakeType>")
                .Result("ExclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<FakeType>),
                        "Value is not between [null] and [Fake(15)]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", notCmpFakeType2));
            AddInvalid(new FakeType {Second = "null"}, null, null, comparer)
                .NegationResult("NotExclusiveBetweenSpecification<FakeType>")
                .Result("ExclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<FakeType>),
                        "Value is not between [null] and [null]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", null));
        }
    }
}