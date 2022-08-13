using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class MaxLengthData : SpecificationData
    {
        public MaxLengthData()
        {
            int[] emptyArr = Array.Empty<int>(), arr = {1, 2, 3};
            var list = new List<int> {1, 2, 3};
            var dict = new Dictionary<int, bool> {{1, false}, {2, true}};
            var ft = new FakeType {Fourth = new[] {1, 2, 3}};
            var ift = new InterFakeType();

            AddValid("", 0)
                .Result("MaxLengthSpecification<String>")
                .NegationResult("NotMaxLengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<string>), "Object length is lower than [0]")
                    .Candidate("")
                    .AddParameter("MaxLength", 0));
            AddValid("test", 25)
                .Result("MaxLengthSpecification<String>")
                .NegationResult("NotMaxLengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<string>), "Object length is lower than [25]")
                    .Candidate("test")
                    .AddParameter("MaxLength", 25));
            AddValid(emptyArr, 1)
                .Result("MaxLengthSpecification<Int32[]>")
                .NegationResult("NotMaxLengthSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<int[]>), "Object length is lower than [1]")
                    .Candidate(emptyArr)
                    .AddParameter("MaxLength", 1));
            AddValid(arr, 5)
                .Result("MaxLengthSpecification<Int32[]>")
                .NegationResult("NotMaxLengthSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<int[]>), "Object length is lower than [5]")
                    .Candidate(arr)
                    .AddParameter("MaxLength", 5));
            AddValid(list, 3)
                .Result("MaxLengthSpecification<List<Int32>>")
                .NegationResult("NotMaxLengthSpecification<List<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<List<int>>), "Object length is lower than [3]")
                    .Candidate(list)
                    .AddParameter("MaxLength", 3));
            AddValid(dict, 20)
                .Result("MaxLengthSpecification<Dictionary<Int32,Boolean>>")
                .NegationResult("NotMaxLengthSpecification<Dictionary<Int32,Boolean>>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<Dictionary<int, bool>>),
                        "Object length is lower than [20]")
                    .Candidate(dict)
                    .AddParameter("MaxLength", 20));
            AddValid(ft, 3)
                .Result("MaxLengthSpecification<FakeType>")
                .NegationResult("NotMaxLengthSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<FakeType>), "Object length is lower than [3]")
                    .Candidate(ft)
                    .AddParameter("MaxLength", 3));
            AddValid(ift, 1)
                .Result("MaxLengthSpecification<InterFakeType>")
                .NegationResult("NotMaxLengthSpecification<InterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<InterFakeType>),
                        "Object length is lower than [1]")
                    .Candidate(ift)
                    .AddParameter("MaxLength", 1));

            AddInvalid("", -1)
                .NegationResult("NotMaxLengthSpecification<String>")
                .Result("MaxLengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<string>), "Object length is greater than [-1]")
                    .Candidate("")
                    .AddParameter("MaxLength", -1));
            AddInvalid("test", 2)
                .NegationResult("NotMaxLengthSpecification<String>")
                .Result("MaxLengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<string>), "Object length is greater than [2]")
                    .Candidate("test")
                    .AddParameter("MaxLength", 2));
            AddInvalid(emptyArr, -1)
                .NegationResult("NotMaxLengthSpecification<Int32[]>")
                .Result("MaxLengthSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<int[]>), "Object length is greater than [-1]")
                    .Candidate(emptyArr)
                    .AddParameter("MaxLength", -1));
            AddInvalid(arr, 0)
                .NegationResult("NotMaxLengthSpecification<Int32[]>")
                .Result("MaxLengthSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<int[]>), "Object length is greater than [0]")
                    .Candidate(arr)
                    .AddParameter("MaxLength", 0));
            AddInvalid(list, 2)
                .NegationResult("NotMaxLengthSpecification<List<Int32>>")
                .Result("MaxLengthSpecification<List<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<List<int>>), "Object length is greater than [2]")
                    .Candidate(list)
                    .AddParameter("MaxLength", 2));
            AddInvalid(dict, 1)
                .NegationResult("NotMaxLengthSpecification<Dictionary<Int32,Boolean>>")
                .Result("MaxLengthSpecification<Dictionary<Int32,Boolean>>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<Dictionary<int, bool>>),
                        "Object length is greater than [1]")
                    .Candidate(dict)
                    .AddParameter("MaxLength", 1));
            AddInvalid(ft, 0)
                .NegationResult("NotMaxLengthSpecification<FakeType>")
                .Result("MaxLengthSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<FakeType>), "Object length is greater than [0]")
                    .Candidate(ft)
                    .AddParameter("MaxLength", 0));
            AddInvalid(ift, 0)
                .NegationResult("NotMaxLengthSpecification<InterFakeType>")
                .Result("MaxLengthSpecification<InterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<InterFakeType>),
                        "Object length is greater than [0]")
                    .Candidate(ift)
                    .AddParameter("MaxLength", 0));
            AddInvalid("null", 1)
                .NegationResult("NotMaxLengthSpecification<String>")
                .Result("MaxLengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<string>), "Object length is greater than [1]")
                    .Candidate(null)
                    .AddParameter("MaxLength", 1));
            AddInvalid(new FakeType {Second = "null"}, 0)
                .NegationResult("NotMaxLengthSpecification<FakeType>")
                .Result("MaxLengthSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(MaxLengthSpecification<FakeType>), "Object length is greater than [0]")
                    .Candidate(null)
                    .AddParameter("MaxLength", 0));
        }
    }
}