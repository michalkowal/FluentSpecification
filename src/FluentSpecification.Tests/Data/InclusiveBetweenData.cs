using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class InclusiveBetweenData : SpecificationData
    {
        public InclusiveBetweenData()
        {
            var comparer = new FakeTypeComparer();
            var intComparer = new FakeIntComparer();
            ComparableFakeType cmp = new ComparableFakeType {First = 15},
                cmpFrom = new ComparableFakeType {First = 1},
                cmpTo = new ComparableFakeType {First = 30},
                cmpFrom2 = new ComparableFakeType {First = 10},
                cmpTo2 = new ComparableFakeType {First = 15};
            ComparableInterFakeType cmpInter1 = new ComparableInterFakeType(),
                cmpInter2 = new ComparableInterFakeType(),
                cmpInter3 = new ComparableInterFakeType {Third = true};
            FakeType cmpFakeType = new FakeType {First = 15},
                cmpFromFakeType = new FakeType {First = 1},
                cmpToFakeType = new FakeType {First = 30},
                cmpFromFakeType2 = new FakeType {First = 10},
                cmpToFakeType2 = new FakeType {First = 15};

            AddValid(2, 2, 3, null)
                .Result("InclusiveBetweenSpecification<Int32>")
                .NegationResult("NotInclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<int>), "Value is between [2] and [3]")
                    .Candidate(2)
                    .AddParameter("From", 2)
                    .AddParameter("To", 3));
            AddValid(-2, -3, -2, null)
                .Result("InclusiveBetweenSpecification<Int32>")
                .NegationResult("NotInclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<int>), "Value is between [-3] and [-2]")
                    .Candidate(-2)
                    .AddParameter("From", -3)
                    .AddParameter("To", -2));
            AddValid(1, 0, 5, null)
                .Result("InclusiveBetweenSpecification<Int32>")
                .NegationResult("NotInclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<int>), "Value is between [0] and [5]")
                    .Candidate(1)
                    .AddParameter("From", 0)
                    .AddParameter("To", 5));
            AddValid(-1, -5, 1, null)
                .Result("InclusiveBetweenSpecification<Int32>")
                .NegationResult("NotInclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<int>), "Value is between [-5] and [1]")
                    .Candidate(-1)
                    .AddParameter("From", -5)
                    .AddParameter("To", 1));
            AddValid(-9, -24, -1, intComparer)
                .Result("InclusiveBetweenSpecification<Int32>")
                .NegationResult("NotInclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<int>), "Value is between [-24] and [-1]")
                    .Candidate(-9)
                    .AddParameter("From", -24)
                    .AddParameter("To", -1));
            AddValid(3.5, 3.5, 3.5, null)
                .Result("InclusiveBetweenSpecification<Double>")
                .NegationResult("NotInclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<double>),
                        "Value is between [3.5] and [3.5]")
                    .Candidate(3.5)
                    .AddParameter("From", 3.5)
                    .AddParameter("To", 3.5));
            AddValid(-3.5, -3.5, -3.5, null)
                .Result("InclusiveBetweenSpecification<Double>")
                .NegationResult("NotInclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<double>),
                        "Value is between [-3.5] and [-3.5]")
                    .Candidate(-3.5)
                    .AddParameter("From", -3.5)
                    .AddParameter("To", -3.5));
            AddValid(5.74, 5.73, 5.75, null)
                .Result("InclusiveBetweenSpecification<Double>")
                .NegationResult("NotInclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<double>),
                        "Value is between [5.73] and [5.75]")
                    .Candidate(5.74)
                    .AddParameter("From", 5.73)
                    .AddParameter("To", 5.75));
            AddValid(-2.5, -3.0, 0.0, null)
                .Result("InclusiveBetweenSpecification<Double>")
                .NegationResult("NotInclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<double>), "Value is between [-3] and [0]")
                    .Candidate(-2.5)
                    .AddParameter("From", -3.0)
                    .AddParameter("To", 0.0));
            AddValid(-5.75, -5.76, -5.74, null)
                .Result("InclusiveBetweenSpecification<Double>")
                .NegationResult("NotInclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<double>),
                        "Value is between [-5.76] and [-5.74]")
                    .Candidate(-5.75)
                    .AddParameter("From", -5.76)
                    .AddParameter("To", -5.74));
            AddValid(false, false, true, null)
                .Result("InclusiveBetweenSpecification<Boolean>")
                .NegationResult("NotInclusiveBetweenSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<bool>),
                        "Value is between [False] and [True]")
                    .Candidate(false)
                    .AddParameter("From", false)
                    .AddParameter("To", true));
            AddValid("123", "123", "124", null)
                .Result("InclusiveBetweenSpecification<String>")
                .NegationResult("NotInclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<string>),
                        "Value is between [123] and [124]")
                    .Candidate("123")
                    .AddParameter("From", "123")
                    .AddParameter("To", "124"));
            AddValid("123", "122", "124", null)
                .Result("InclusiveBetweenSpecification<String>")
                .NegationResult("NotInclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<string>),
                        "Value is between [122] and [124]")
                    .Candidate("123")
                    .AddParameter("From", "122")
                    .AddParameter("To", "124"));
            AddValid("123", "12", "1234", null)
                .Result("InclusiveBetweenSpecification<String>")
                .NegationResult("NotInclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<string>),
                        "Value is between [12] and [1234]")
                    .Candidate("123")
                    .AddParameter("From", "12")
                    .AddParameter("To", "1234"));
            AddValid("test", null, "test1", null)
                .Result("InclusiveBetweenSpecification<String>")
                .NegationResult("NotInclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<string>),
                        "Value is between [null] and [test1]")
                    .Candidate("test")
                    .AddParameter("From", null)
                    .AddParameter("To", "test1"));
            AddValid("null", null, "test", null)
                .Result("InclusiveBetweenSpecification<String>")
                .NegationResult("NotInclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<string>),
                        "Value is between [null] and [test]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", "test"));
            AddValid("null", null, null, null)
                .Result("InclusiveBetweenSpecification<String>")
                .NegationResult("NotInclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<string>),
                        "Value is between [null] and [null]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", null));
            AddValid(DateTime.Parse("2019-07-11"), DateTime.Parse("2019-07-01"), DateTime.Parse("2019-07-11"), null)
                .Result("InclusiveBetweenSpecification<DateTime>")
                .NegationResult("NotInclusiveBetweenSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<DateTime>),
                        $"Value is between \\[{DateTimeRegexPattern}\\] and \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-11"))
                    .AddParameter("From", DateTime.Parse("2019-07-01"))
                    .AddParameter("To", DateTime.Parse("2019-07-11")));
            AddValid(DateTime.Parse("2018-01-15"), DateTime.Parse("2017-05-16"), DateTime.Parse("2019-07-11"), null)
                .Result("InclusiveBetweenSpecification<DateTime>")
                .NegationResult("NotInclusiveBetweenSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<DateTime>),
                        $"Value is between \\[{DateTimeRegexPattern}\\] and \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2018-01-15"))
                    .AddParameter("From", DateTime.Parse("2017-05-16"))
                    .AddParameter("To", DateTime.Parse("2019-07-11")));
            AddValid(DateTime.Parse("2018-01-15"), DateTime.Parse("2017-05-16"), DateTime.Parse("2019-07-11"), null)
                .Result("InclusiveBetweenSpecification<DateTime>")
                .NegationResult("NotInclusiveBetweenSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<DateTime>),
                        $"Value is between \\[{DateTimeRegexPattern}\\] and \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2018-01-15"))
                    .AddParameter("From", DateTime.Parse("2017-05-16"))
                    .AddParameter("To", DateTime.Parse("2019-07-11")));
            AddValid(DateTime.Parse("2019-07-05"), DateTime.Parse("2019-07-01"), DateTime.Parse("2019-07-11"), null)
                .Result("InclusiveBetweenSpecification<DateTime>")
                .NegationResult("NotInclusiveBetweenSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<DateTime>),
                        $"Value is between \\[{DateTimeRegexPattern}\\] and \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-07-05"))
                    .AddParameter("From", DateTime.Parse("2019-07-01"))
                    .AddParameter("To", DateTime.Parse("2019-07-11")));
            AddValid(cmp, cmpFrom, cmpTo, null)
                .Result("InclusiveBetweenSpecification<ComparableFakeType>")
                .NegationResult("NotInclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is between [Fake(1)] and [Fake(30)]")
                    .Candidate(cmp)
                    .AddParameter("From", cmpFrom)
                    .AddParameter("To", cmpTo));
            AddValid(cmp, cmpFrom2, cmpTo2, null)
                .Result("InclusiveBetweenSpecification<ComparableFakeType>")
                .NegationResult("NotInclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is between [Fake(10)] and [Fake(15)]")
                    .Candidate(cmp)
                    .AddParameter("From", cmpFrom2)
                    .AddParameter("To", cmpTo2));
            AddValid(cmp, null, cmpTo2, null)
                .Result("InclusiveBetweenSpecification<ComparableFakeType>")
                .NegationResult("NotInclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is between [null] and [Fake(15)]")
                    .Candidate(cmp)
                    .AddParameter("From", null)
                    .AddParameter("To", cmpTo2));
            AddValid(new ComparableFakeType {Second = "null"}, null, cmpTo2, null)
                .Result("InclusiveBetweenSpecification<ComparableFakeType>")
                .NegationResult("NotInclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is between [null] and [Fake(15)]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", cmpTo2));
            AddValid(new ComparableFakeType {Second = "null"}, null, null, null)
                .Result("InclusiveBetweenSpecification<ComparableFakeType>")
                .NegationResult("NotInclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is between [null] and [null]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", null));
            AddValid(cmpInter1, cmpInter2, cmpInter3, null)
                .Result("InclusiveBetweenSpecification<ComparableInterFakeType>")
                .NegationResult("NotInclusiveBetweenSpecification<ComparableInterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<ComparableInterFakeType>),
                        "Value is between [FluentSpecification.Tests.Mocks.ComparableInterFakeType] and [FluentSpecification.Tests.Mocks.ComparableInterFakeType]")
                    .Candidate(cmpInter1)
                    .AddParameter("From", cmpInter2)
                    .AddParameter("To", cmpInter3));
            AddValid(cmpFakeType, cmpFromFakeType, cmpToFakeType, comparer)
                .Result("InclusiveBetweenSpecification<FakeType>")
                .NegationResult("NotInclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<FakeType>),
                        "Value is between [Fake(1)] and [Fake(30)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("From", cmpFromFakeType)
                    .AddParameter("To", cmpToFakeType));
            AddValid(cmpFakeType, cmpFromFakeType2, cmpToFakeType2, comparer)
                .Result("InclusiveBetweenSpecification<FakeType>")
                .NegationResult("NotInclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<FakeType>),
                        "Value is between [Fake(10)] and [Fake(15)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("From", cmpFromFakeType2)
                    .AddParameter("To", cmpToFakeType2));
            AddValid(cmpFakeType, null, cmpToFakeType, comparer)
                .Result("InclusiveBetweenSpecification<FakeType>")
                .NegationResult("NotInclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<FakeType>),
                        "Value is between [null] and [Fake(30)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("From", null)
                    .AddParameter("To", cmpToFakeType));
            AddValid(new FakeType {Second = "null"}, null, cmpToFakeType, comparer)
                .Result("InclusiveBetweenSpecification<FakeType>")
                .NegationResult("NotInclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<FakeType>),
                        "Value is between [null] and [Fake(30)]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", cmpToFakeType));
            AddValid(new FakeType {Second = "null"}, null, null, comparer)
                .Result("InclusiveBetweenSpecification<FakeType>")
                .NegationResult("NotInclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<FakeType>),
                        "Value is between [null] and [null]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", null));

            ComparableFakeType notCmp1 = new ComparableFakeType {First = 1},
                notCmp2 = new ComparableFakeType {First = 3},
                notCmp3 = new ComparableFakeType {First = 23},
                notCmp4 = new ComparableFakeType {First = 30};
            FakeType notCmpFakeType1 = new FakeType {First = 1},
                notCmpFakeType2 = new FakeType {First = 3},
                notCmpFakeType3 = new FakeType {First = 23},
                notCmpFakeType4 = new FakeType {First = 30};

            AddInvalid(1, -3, -1, null)
                .NegationResult("NotInclusiveBetweenSpecification<Int32>")
                .Result("InclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<int>),
                        "Value is not between [-3] and [-1]")
                    .Candidate(1)
                    .AddParameter("From", -3)
                    .AddParameter("To", -1));
            AddInvalid(5, 1, 3, null)
                .NegationResult("NotInclusiveBetweenSpecification<Int32>")
                .Result("InclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<int>), "Value is not between [1] and [3]")
                    .Candidate(5)
                    .AddParameter("From", 1)
                    .AddParameter("To", 3));
            AddInvalid(-1, -10, -5, intComparer)
                .NegationResult("NotInclusiveBetweenSpecification<Int32>")
                .Result("InclusiveBetweenSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<int>),
                        "Value is not between [-10] and [-5]")
                    .Candidate(-1)
                    .AddParameter("From", -10)
                    .AddParameter("To", -5));
            AddInvalid(5.74, 2.74, 3.74, null)
                .NegationResult("NotInclusiveBetweenSpecification<Double>")
                .Result("InclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<double>),
                        "Value is not between [2.74] and [3.74]")
                    .Candidate(5.74)
                    .AddParameter("From", 2.74)
                    .AddParameter("To", 3.74));
            AddInvalid(-3.74, -7.74, -5.74, null)
                .NegationResult("NotInclusiveBetweenSpecification<Double>")
                .Result("InclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<double>),
                        "Value is not between [-7.74] and [-5.74]")
                    .Candidate(-3.74)
                    .AddParameter("From", -7.74)
                    .AddParameter("To", -5.74));
            AddInvalid(5.74, -3.74, 5.73, null)
                .NegationResult("NotInclusiveBetweenSpecification<Double>")
                .Result("InclusiveBetweenSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<double>),
                        "Value is not between [-3.74] and [5.73]")
                    .Candidate(5.74)
                    .AddParameter("From", -3.74)
                    .AddParameter("To", 5.73));
            AddInvalid("123", "121", "122", null)
                .NegationResult("NotInclusiveBetweenSpecification<String>")
                .Result("InclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<string>),
                        "Value is not between [121] and [122]")
                    .Candidate("123")
                    .AddParameter("From", "121")
                    .AddParameter("To", "122"));
            AddInvalid("1234", "122", "1233", null)
                .NegationResult("NotInclusiveBetweenSpecification<String>")
                .Result("InclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<string>),
                        "Value is not between [122] and [1233]")
                    .Candidate("1234")
                    .AddParameter("From", "122")
                    .AddParameter("To", "1233"));
            AddInvalid(DateTime.Parse("2019-11-15"), DateTime.Parse("2019-07-11"), DateTime.Parse("2019-11-10"), null)
                .NegationResult("NotInclusiveBetweenSpecification<DateTime>")
                .Result("InclusiveBetweenSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<DateTime>),
                        $"Value is not between \\[{DateTimeRegexPattern}\\] and \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-11-15"))
                    .AddParameter("From", DateTime.Parse("2019-07-11"))
                    .AddParameter("To", DateTime.Parse("2019-11-10")));
            AddInvalid(DateTime.Parse("2019-11-15"), DateTime.Parse("2019-12-11"), DateTime.Parse("2019-12-15"), null)
                .NegationResult("NotInclusiveBetweenSpecification<DateTime>")
                .Result("InclusiveBetweenSpecification<DateTime>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<DateTime>),
                        $"Value is not between \\[{DateTimeRegexPattern}\\] and \\[{DateTimeRegexPattern}\\]")
                    .Candidate(DateTime.Parse("2019-11-15"))
                    .AddParameter("From", DateTime.Parse("2019-12-11"))
                    .AddParameter("To", DateTime.Parse("2019-12-15")));
            AddInvalid(cmp, notCmp1, notCmp2, null)
                .NegationResult("NotInclusiveBetweenSpecification<ComparableFakeType>")
                .Result("InclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is not between [Fake(1)] and [Fake(3)]")
                    .Candidate(cmp)
                    .AddParameter("From", notCmp1)
                    .AddParameter("To", notCmp2));
            AddInvalid(cmp, notCmp3, notCmp4, null)
                .NegationResult("NotInclusiveBetweenSpecification<ComparableFakeType>")
                .Result("InclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is not between [Fake(23)] and [Fake(30)]")
                    .Candidate(cmp)
                    .AddParameter("From", notCmp3)
                    .AddParameter("To", notCmp4));
            AddInvalid("null", "test", "test", null)
                .NegationResult("NotInclusiveBetweenSpecification<String>")
                .Result("InclusiveBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<string>),
                        "Value is not between [test] and [test]")
                    .Candidate(null)
                    .AddParameter("From", "test")
                    .AddParameter("To", "test"));
            AddInvalid(new ComparableFakeType {Second = "null"}, notCmp1, notCmp2, null)
                .NegationResult("NotInclusiveBetweenSpecification<ComparableFakeType>")
                .Result("InclusiveBetweenSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<ComparableFakeType>),
                        "Value is not between [Fake(1)] and [Fake(3)]")
                    .Candidate(null)
                    .AddParameter("From", notCmp1)
                    .AddParameter("To", notCmp2));
            AddInvalid(cmpFakeType, notCmpFakeType1, notCmpFakeType2, comparer)
                .NegationResult("NotInclusiveBetweenSpecification<FakeType>")
                .Result("InclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<FakeType>),
                        "Value is not between [Fake(1)] and [Fake(3)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("From", notCmpFakeType1)
                    .AddParameter("To", notCmpFakeType2));
            AddInvalid(cmpFakeType, notCmpFakeType3, notCmpFakeType4, comparer)
                .NegationResult("NotInclusiveBetweenSpecification<FakeType>")
                .Result("InclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<FakeType>),
                        "Value is not between [Fake(23)] and [Fake(30)]")
                    .Candidate(cmpFakeType)
                    .AddParameter("From", notCmpFakeType3)
                    .AddParameter("To", notCmpFakeType4));
            AddInvalid(new FakeType {Second = "null"}, notCmpFakeType1, notCmpFakeType2, comparer)
                .NegationResult("NotInclusiveBetweenSpecification<FakeType>")
                .Result("InclusiveBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<FakeType>),
                        "Value is not between [Fake(1)] and [Fake(3)]")
                    .Candidate(null)
                    .AddParameter("From", notCmpFakeType1)
                    .AddParameter("To", notCmpFakeType2));
        }
    }
}