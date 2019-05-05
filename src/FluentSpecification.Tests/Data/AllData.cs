using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class AllData : SpecificationData
    {
        public AllData()
        {
            int[] arr = {1, 5, 200, 6, 100};
            var list = new List<string> {"First", "Second"};
            var dict = new Dictionary<string, bool> {{"First", true}, {"Second", false}};
            var ft = new FakeType {Fourth = arr};
            var empty = new FakeType();
            var nullFt = new FakeType {Second = "null"};

            AddValid(arr, True<int>())
                .Result(6,
                    "AllSpecification<Int32[],Int32>([0](MockComplexSpecification[Int32]) And [1](MockComplexSpecification[Int32]) And [2](MockComplexSpecification[Int32]) And [3](MockComplexSpecification[Int32]) And [4](MockComplexSpecification[Int32]))");
            AddValid(list, True<string>())
                .Result(3,
                    "AllSpecification<List<String>,String>([0](MockComplexSpecification[String]) And [1](MockComplexSpecification[String]))");
            AddValid(dict, True<KeyValuePair<string, bool>>())
                .Result(3,
                    "AllSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>([0](MockComplexSpecification[KeyValuePair<String,Boolean>]) And [1](MockComplexSpecification[KeyValuePair<String,Boolean>]))");
            AddValid(ft, True<int>())
                .Result(6,
                    "AllSpecification<FakeType,Int32>([0](MockComplexSpecification[Int32]) And [1](MockComplexSpecification[Int32]) And [2](MockComplexSpecification[Int32]) And [3](MockComplexSpecification[Int32]) And [4](MockComplexSpecification[Int32]))");
            AddValid(empty, True<int>())
                .Result(1, "AllSpecification<FakeType,Int32>()");

            AddInvalid(nullFt, True<int>())
                .Result(1, "AllSpecification<FakeType,Int32>()+Failed", c => c
                    .FailedSpecification(typeof(AllSpecification<FakeType, int>), "Collection is null")
                    .Candidate(null)
                    .AddParameter("SpecificationForAll", null));
            AddInvalid(arr, False<int>())
                .Result(6,
                    "AllSpecification<Int32[],Int32>([0](FailedMockComplexSpecification[Int32]) And [1](FailedMockComplexSpecification[Int32]) And [2](FailedMockComplexSpecification[Int32]) And [3](FailedMockComplexSpecification[Int32]) And [4](FailedMockComplexSpecification[Int32]))+Failed",
                    c =>
                    {
                        c.FailedSpecification(typeof(AllSpecification<int[], int>),
                                "One or more elements are not specified")
                            .Candidate(arr)
                            .AddParameter("SpecificationForAll", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[0] MockComplexSpecification is not satisfied")
                            .Candidate(1)
                            .AddParameter("Expression", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[1] MockComplexSpecification is not satisfied")
                            .Candidate(5)
                            .AddParameter("Expression", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[2] MockComplexSpecification is not satisfied")
                            .Candidate(200)
                            .AddParameter("Expression", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[3] MockComplexSpecification is not satisfied")
                            .Candidate(6)
                            .AddParameter("Expression", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[4] MockComplexSpecification is not satisfied")
                            .Candidate(100)
                            .AddParameter("Expression", null);
                    });
            AddInvalid(list, False<string>())
                .Result(3,
                    "AllSpecification<List<String>,String>([0](FailedMockComplexSpecification[String]) And [1](FailedMockComplexSpecification[String]))+Failed",
                    c =>
                    {
                        c.FailedSpecification(typeof(AllSpecification<List<string>, string>),
                                "One or more elements are not specified")
                            .Candidate(list)
                            .AddParameter("SpecificationForAll", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<string>),
                                "[0] MockComplexSpecification is not satisfied")
                            .Candidate("First")
                            .AddParameter("Expression", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<string>),
                                "[1] MockComplexSpecification is not satisfied")
                            .Candidate("Second")
                            .AddParameter("Expression", null);
                    });
            AddInvalid(dict, False<KeyValuePair<string, bool>>())
                .Result(3,
                    "AllSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>([0](FailedMockComplexSpecification[KeyValuePair<String,Boolean>]) And [1](FailedMockComplexSpecification[KeyValuePair<String,Boolean>]))+Failed",
                    c =>
                    {
                        c.FailedSpecification(
                                typeof(AllSpecification<Dictionary<string, bool>, KeyValuePair<string, bool>>),
                                "One or more elements are not specified")
                            .Candidate(dict)
                            .AddParameter("SpecificationForAll", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<KeyValuePair<string, bool>>),
                                "[0] MockComplexSpecification is not satisfied")
                            .Candidate(new KeyValuePair<string, bool>("First", true))
                            .AddParameter("Expression", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<KeyValuePair<string, bool>>),
                                "[1] MockComplexSpecification is not satisfied")
                            .Candidate(new KeyValuePair<string, bool>("Second", false))
                            .AddParameter("Expression", null);
                    });
            AddInvalid(ft, False<int>())
                .Result(6,
                    "AllSpecification<FakeType,Int32>([0](FailedMockComplexSpecification[Int32]) And [1](FailedMockComplexSpecification[Int32]) And [2](FailedMockComplexSpecification[Int32]) And [3](FailedMockComplexSpecification[Int32]) And [4](FailedMockComplexSpecification[Int32]))+Failed",
                    c =>
                    {
                        c.FailedSpecification(typeof(AllSpecification<FakeType, int>),
                                "One or more elements are not specified")
                            .Candidate(arr)
                            .AddParameter("SpecificationForAll", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[0] MockComplexSpecification is not satisfied")
                            .Candidate(1)
                            .AddParameter("Expression", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[1] MockComplexSpecification is not satisfied")
                            .Candidate(5)
                            .AddParameter("Expression", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[2] MockComplexSpecification is not satisfied")
                            .Candidate(200)
                            .AddParameter("Expression", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[3] MockComplexSpecification is not satisfied")
                            .Candidate(6)
                            .AddParameter("Expression", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[4] MockComplexSpecification is not satisfied")
                            .Candidate(100)
                            .AddParameter("Expression", null);
                    });
            AddInvalid(arr, FewInt())
                .Result(6,
                    "AllSpecification<Int32[],Int32>([0](MockComplexSpecification[Int32]) And [1](MockComplexSpecification[Int32]) And [2](FailedMockComplexSpecification[Int32]) And [3](MockComplexSpecification[Int32]) And [4](FailedMockComplexSpecification[Int32]))+Failed",
                    c =>
                    {
                        c.FailedSpecification(typeof(AllSpecification<int[], int>),
                                "One or more elements are not specified")
                            .Candidate(arr)
                            .AddParameter("SpecificationForAll", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[2] MockComplexSpecification is not satisfied")
                            .Candidate(200)
                            .AddParameter("Expression", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[4] MockComplexSpecification is not satisfied")
                            .Candidate(100)
                            .AddParameter("Expression", null);
                    });
            AddInvalid(list, FewString())
                .Result(3,
                    "AllSpecification<List<String>,String>([0](MockComplexSpecification[String]) And [1](FailedMockComplexSpecification[String]))+Failed",
                    c =>
                    {
                        c.FailedSpecification(typeof(AllSpecification<List<string>, string>),
                                "One or more elements are not specified")
                            .Candidate(list)
                            .AddParameter("SpecificationForAll", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<string>),
                                "[1] MockComplexSpecification is not satisfied")
                            .Candidate("Second")
                            .AddParameter("Expression", null);
                    });
            AddInvalid(dict, FewPair())
                .Result(3,
                    "AllSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>([0](MockComplexSpecification[KeyValuePair<String,Boolean>]) And [1](FailedMockComplexSpecification[KeyValuePair<String,Boolean>]))+Failed",
                    c =>
                    {
                        c.FailedSpecification(
                                typeof(AllSpecification<Dictionary<string, bool>, KeyValuePair<string, bool>>),
                                "One or more elements are not specified")
                            .Candidate(dict)
                            .AddParameter("SpecificationForAll", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<KeyValuePair<string, bool>>),
                                "[1] MockComplexSpecification is not satisfied")
                            .Candidate(new KeyValuePair<string, bool>("Second", false))
                            .AddParameter("Expression", null);
                    });
            AddInvalid(ft, FewInt())
                .Result(6,
                    "AllSpecification<FakeType,Int32>([0](MockComplexSpecification[Int32]) And [1](MockComplexSpecification[Int32]) And [2](FailedMockComplexSpecification[Int32]) And [3](MockComplexSpecification[Int32]) And [4](FailedMockComplexSpecification[Int32]))+Failed",
                    c =>
                    {
                        c.FailedSpecification(typeof(AllSpecification<FakeType, int>),
                                "One or more elements are not specified")
                            .Candidate(ft)
                            .AddParameter("SpecificationForAll", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[2] MockComplexSpecification is not satisfied")
                            .Candidate(200)
                            .AddParameter("Expression", null);
                        c.FailedSpecification(typeof(MockComplexSpecification<int>),
                                "[4] MockComplexSpecification is not satisfied")
                            .Candidate(100)
                            .AddParameter("Expression", null);
                    });
        }

        private Expression<Func<T, bool>> True<T>()
        {
            return candidate => true;
        }

        private Expression<Func<T, bool>> False<T>()
        {
            return candidate => false;
        }

        private Expression<Func<int, bool>> FewInt()
        {
            return i => i < 100;
        }

        private Expression<Func<string, bool>> FewString()
        {
            return s => s == "First";
        }

        private Expression<Func<KeyValuePair<string, bool>, bool>> FewPair()
        {
            return kv => kv.Value;
        }
    }
}