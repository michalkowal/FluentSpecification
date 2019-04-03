using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class ContainsData : SpecificationData
    {
        public ContainsData()
        {
            var comparer = new FakeTypeComparer();
            var intComparer = new FakeIntComparer();
            int[] arr = {1, 5, 200, 6, 100};
            var list = new List<string> {"First", "Second"};
            var dict = new Dictionary<string, bool> {{"First", false}, {"Second", true}};
            var cmp = new EquatableFakeType {First = 10};
            var notCmp = new EquatableFakeType {First = 100};
            EquatableFakeType[] cmpArr = {new EquatableFakeType {First = 11}, new EquatableFakeType {First = 10}};
            var ft = new FakeType {First = 1, Fourth = arr};
            var empty = new FakeType {First = 1};
            FakeType[] ftArr = {ft, cmp, null};
            var nullFt = new FakeType {Second = "null"};

            AddValid(arr, 5, null)
                .Result("ContainsSpecification<Int32[],Int32>")
                .NegationResult("NotContainsSpecification<Int32[],Int32>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<int[], int>), "Collection contains [5]")
                    .Candidate(arr)
                    .AddParameter("Expected", 5));
            AddValid(list, "Second", null)
                .Result("ContainsSpecification<List<String>,String>")
                .NegationResult("NotContainsSpecification<List<String>,String>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<List<string>, string>),
                        "Collection contains [Second]")
                    .Candidate(list)
                    .AddParameter("Expected", "Second"));
            AddValid(dict, new KeyValuePair<string, bool>("First", false), null)
                .Result("ContainsSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>")
                .NegationResult(
                    "NotContainsSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>+Failed", c => c
                        .FailedSpecification(
                            typeof(ContainsSpecification<Dictionary<string, bool>, KeyValuePair<string, bool>>),
                            "Collection contains [[First, False]]")
                        .Candidate(dict)
                        .AddParameter("Expected", new KeyValuePair<string, bool>("First", false)));
            AddValid(cmpArr, cmp, null)
                .Result("ContainsSpecification<EquatableFakeType[],EquatableFakeType>")
                .NegationResult("NotContainsSpecification<EquatableFakeType[],EquatableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<EquatableFakeType[], EquatableFakeType>),
                        "Collection contains [Fake(10)]")
                    .Candidate(cmpArr)
                    .AddParameter("Expected", cmp));
            AddValid(ft, 200, intComparer)
                .Result("ContainsSpecification<FakeType,Int32>")
                .NegationResult("NotContainsSpecification<FakeType,Int32>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<FakeType, int>), "Collection contains [200]")
                    .Candidate(ft)
                    .AddParameter("Expected", 200));
            AddValid(ftArr, ft, null)
                .Result("ContainsSpecification<FakeType[],FakeType>")
                .NegationResult("NotContainsSpecification<FakeType[],FakeType>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<FakeType[], FakeType>),
                        "Collection contains [Fake(1)]")
                    .Candidate(ftArr)
                    .AddParameter("Expected", ft));
            AddValid(ftArr, empty, comparer)
                .Result("ContainsSpecification<FakeType[],FakeType>")
                .NegationResult("NotContainsSpecification<FakeType[],FakeType>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<FakeType[], FakeType>),
                        "Collection contains [Fake(1)]")
                    .Candidate(ftArr)
                    .AddParameter("Expected", empty));
            AddValid(ftArr, new FakeType {Second = "null"}, null)
                .Result("ContainsSpecification<FakeType[],FakeType>")
                .NegationResult("NotContainsSpecification<FakeType[],FakeType>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<FakeType[], FakeType>),
                        "Collection contains [null]")
                    .Candidate(ftArr)
                    .AddParameter("Expected", null));

            AddInvalid(arr, 16, null)
                .NegationResult("NotContainsSpecification<Int32[],Int32>")
                .Result("ContainsSpecification<Int32[],Int32>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<int[], int>), "Collection not contains [16]")
                    .Candidate(arr)
                    .AddParameter("Expected", 16));
            AddInvalid(list, "Third", null)
                .NegationResult("NotContainsSpecification<List<String>,String>")
                .Result("ContainsSpecification<List<String>,String>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<List<string>, string>),
                        "Collection not contains [Third]")
                    .Candidate(list)
                    .AddParameter("Expected", "Third"));
            AddInvalid(dict, new KeyValuePair<string, bool>("Third", false), null)
                .NegationResult("NotContainsSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>")
                .Result("ContainsSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>+Failed", c => c
                    .FailedSpecification(
                        typeof(ContainsSpecification<Dictionary<string, bool>, KeyValuePair<string, bool>>),
                        "Collection not contains [[Third, False]]")
                    .Candidate(dict)
                    .AddParameter("Expected", new KeyValuePair<string, bool>("Third", false)));
            AddInvalid(ft, 16, intComparer)
                .NegationResult("NotContainsSpecification<FakeType,Int32>")
                .Result("ContainsSpecification<FakeType,Int32>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<FakeType, int>), "Collection not contains [16]")
                    .Candidate(ft)
                    .AddParameter("Expected", 16));
            AddInvalid(cmpArr, notCmp, null)
                .NegationResult("NotContainsSpecification<EquatableFakeType[],EquatableFakeType>")
                .Result("ContainsSpecification<EquatableFakeType[],EquatableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<EquatableFakeType[], EquatableFakeType>),
                        "Collection not contains [Fake(100)]")
                    .Candidate(cmpArr)
                    .AddParameter("Expected", notCmp));
            AddInvalid(ftArr, empty, null)
                .NegationResult("NotContainsSpecification<FakeType[],FakeType>")
                .Result("ContainsSpecification<FakeType[],FakeType>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<FakeType[], FakeType>),
                        "Collection not contains [Fake(1)]")
                    .Candidate(ftArr)
                    .AddParameter("Expected", empty));
            AddInvalid(nullFt, 1, null)
                .NegationResult("NotContainsSpecification<FakeType,Int32>")
                .Result("ContainsSpecification<FakeType,Int32>+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification<FakeType, int>), "Collection not contains [1]")
                    .Candidate(null)
                    .AddParameter("Expected", 1));
        }
    }
}