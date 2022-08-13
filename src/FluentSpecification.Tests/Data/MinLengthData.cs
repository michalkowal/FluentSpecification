using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class MinLengthData : SpecificationData
    {
        public MinLengthData()
        {
            int[] emptyArr = Array.Empty<int>(), arr = {1, 2, 3};
            var list = new List<int> {1, 2, 3};
            var dict = new Dictionary<int, bool> {{1, false}, {2, true}};
            var ft = new FakeType {Fourth = new[] {1, 2, 3}};
            var ift = new InterFakeType();

            AddValid("", 0)
                .Result("MinLengthSpecification<String>")
                .NegationResult("NotMinLengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<string>), "Object length is greater than [0]")
                    .Candidate("")
                    .AddParameter("MinLength", 0));
            AddValid("test", 4)
                .Result("MinLengthSpecification<String>")
                .NegationResult("NotMinLengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<string>), "Object length is greater than [4]")
                    .Candidate("test")
                    .AddParameter("MinLength", 4));
            AddValid(emptyArr, 0)
                .Result("MinLengthSpecification<Int32[]>")
                .NegationResult("NotMinLengthSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<int[]>), "Object length is greater than [0]")
                    .Candidate(emptyArr)
                    .AddParameter("MinLength", 0));
            AddValid(arr, 1)
                .Result("MinLengthSpecification<Int32[]>")
                .NegationResult("NotMinLengthSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<int[]>), "Object length is greater than [1]")
                    .Candidate(arr)
                    .AddParameter("MinLength", 1));
            AddValid(list, 3)
                .Result("MinLengthSpecification<List<Int32>>")
                .NegationResult("NotMinLengthSpecification<List<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<List<int>>), "Object length is greater than [3]")
                    .Candidate(list)
                    .AddParameter("MinLength", 3));
            AddValid(dict, 2)
                .Result("MinLengthSpecification<Dictionary<Int32,Boolean>>")
                .NegationResult("NotMinLengthSpecification<Dictionary<Int32,Boolean>>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<Dictionary<int, bool>>),
                        "Object length is greater than [2]")
                    .Candidate(dict)
                    .AddParameter("MinLength", 2));
            AddValid(ft, 2)
                .Result("MinLengthSpecification<FakeType>")
                .NegationResult("NotMinLengthSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<FakeType>), "Object length is greater than [2]")
                    .Candidate(ft)
                    .AddParameter("MinLength", 2));
            AddValid(ift, 0)
                .Result("MinLengthSpecification<InterFakeType>")
                .NegationResult("NotMinLengthSpecification<InterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<InterFakeType>),
                        "Object length is greater than [0]")
                    .Candidate(ift)
                    .AddParameter("MinLength", 0));

            AddInvalid("", 1)
                .NegationResult("NotMinLengthSpecification<String>")
                .Result("MinLengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<string>), "Object length is lower than [1]")
                    .Candidate("")
                    .AddParameter("MinLength", 1));
            AddInvalid("test", 10)
                .NegationResult("NotMinLengthSpecification<String>")
                .Result("MinLengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<string>), "Object length is lower than [10]")
                    .Candidate("test")
                    .AddParameter("MinLength", 10));
            AddInvalid(emptyArr, 1)
                .NegationResult("NotMinLengthSpecification<Int32[]>")
                .Result("MinLengthSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<int[]>), "Object length is lower than [1]")
                    .Candidate(emptyArr)
                    .AddParameter("MinLength", 1));
            AddInvalid(arr, 20)
                .NegationResult("NotMinLengthSpecification<Int32[]>")
                .Result("MinLengthSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<int[]>), "Object length is lower than [20]")
                    .Candidate(arr)
                    .AddParameter("MinLength", 20));
            AddInvalid(list, 4)
                .NegationResult("NotMinLengthSpecification<List<Int32>>")
                .Result("MinLengthSpecification<List<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<List<int>>), "Object length is lower than [4]")
                    .Candidate(list)
                    .AddParameter("MinLength", 4));
            AddInvalid(dict, 5)
                .NegationResult("NotMinLengthSpecification<Dictionary<Int32,Boolean>>")
                .Result("MinLengthSpecification<Dictionary<Int32,Boolean>>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<Dictionary<int, bool>>),
                        "Object length is lower than [5]")
                    .Candidate(dict)
                    .AddParameter("MinLength", 5));
            AddInvalid(ft, 5)
                .NegationResult("NotMinLengthSpecification<FakeType>")
                .Result("MinLengthSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<FakeType>), "Object length is lower than [5]")
                    .Candidate(ft)
                    .AddParameter("MinLength", 5));
            AddInvalid(ift, 2)
                .NegationResult("NotMinLengthSpecification<InterFakeType>")
                .Result("MinLengthSpecification<InterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<InterFakeType>),
                        "Object length is lower than [2]")
                    .Candidate(ift)
                    .AddParameter("MinLength", 2));
            AddInvalid("null", 1)
                .NegationResult("NotMinLengthSpecification<String>")
                .Result("MinLengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<string>), "Object length is lower than [1]")
                    .Candidate(null)
                    .AddParameter("MinLength", 1));
            AddInvalid(new FakeType {Second = "null"}, 0)
                .NegationResult("NotMinLengthSpecification<FakeType>")
                .Result("MinLengthSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(MinLengthSpecification<FakeType>), "Object length is lower than [0]")
                    .Candidate(null)
                    .AddParameter("MinLength", 0));
        }
    }
}