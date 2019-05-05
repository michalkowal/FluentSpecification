using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class LengthData : SpecificationData
    {
        public LengthData()
        {
            int[] emptyArr = new int[0], arr = {1, 2, 3};
            var list = new List<int> {1, 2, 3};
            var dict = new Dictionary<int, bool> {{1, false}, {2, true}};
            var ft = new FakeType {Fourth = new[] {1, 2, 3}};
            var ift = new InterFakeType();

            AddValid("", 0)
                .Result("LengthSpecification<String>")
                .NegationResult("NotLengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<string>), "Object length is [0]")
                    .Candidate("")
                    .AddParameter("Length", 0));
            AddValid("test", 4)
                .Result("LengthSpecification<String>")
                .NegationResult("NotLengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<string>), "Object length is [4]")
                    .Candidate("test")
                    .AddParameter("Length", 4));
            AddValid(emptyArr, 0)
                .Result("LengthSpecification<Int32[]>")
                .NegationResult("NotLengthSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<int[]>), "Object length is [0]")
                    .Candidate(emptyArr)
                    .AddParameter("Length", 0));
            AddValid(arr, 3)
                .Result("LengthSpecification<Int32[]>")
                .NegationResult("NotLengthSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<int[]>), "Object length is [3]")
                    .Candidate(arr)
                    .AddParameter("Length", 3));
            AddValid(list, 3)
                .Result("LengthSpecification<List<Int32>>")
                .NegationResult("NotLengthSpecification<List<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<List<int>>), "Object length is [3]")
                    .Candidate(list)
                    .AddParameter("Length", 3));
            AddValid(dict, 2)
                .Result("LengthSpecification<Dictionary<Int32,Boolean>>")
                .NegationResult("NotLengthSpecification<Dictionary<Int32,Boolean>>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<Dictionary<int, bool>>), "Object length is [2]")
                    .Candidate(dict)
                    .AddParameter("Length", 2));
            AddValid(ft, 3)
                .Result("LengthSpecification<FakeType>")
                .NegationResult("NotLengthSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<FakeType>), "Object length is [3]")
                    .Candidate(ft)
                    .AddParameter("Length", 3));
            AddValid(ift, 1)
                .Result("LengthSpecification<InterFakeType>")
                .NegationResult("NotLengthSpecification<InterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<InterFakeType>), "Object length is [1]")
                    .Candidate(ift)
                    .AddParameter("Length", 1));

            AddInvalid("", 1)
                .NegationResult("NotLengthSpecification<String>")
                .Result("LengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<string>), "Object length is not [1]")
                    .Candidate("")
                    .AddParameter("Length", 1));
            AddInvalid("test", 10)
                .NegationResult("NotLengthSpecification<String>")
                .Result("LengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<string>), "Object length is not [10]")
                    .Candidate("test")
                    .AddParameter("Length", 10));
            AddInvalid(emptyArr, 1)
                .NegationResult("NotLengthSpecification<Int32[]>")
                .Result("LengthSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<int[]>), "Object length is not [1]")
                    .Candidate(emptyArr)
                    .AddParameter("Length", 1));
            AddInvalid(arr, 0)
                .NegationResult("NotLengthSpecification<Int32[]>")
                .Result("LengthSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<int[]>), "Object length is not [0]")
                    .Candidate(arr)
                    .AddParameter("Length", 0));
            AddInvalid(list, 0)
                .NegationResult("NotLengthSpecification<List<Int32>>")
                .Result("LengthSpecification<List<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<List<int>>), "Object length is not [0]")
                    .Candidate(list)
                    .AddParameter("Length", 0));
            AddInvalid(dict, 5)
                .NegationResult("NotLengthSpecification<Dictionary<Int32,Boolean>>")
                .Result("LengthSpecification<Dictionary<Int32,Boolean>>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<Dictionary<int, bool>>), "Object length is not [5]")
                    .Candidate(dict)
                    .AddParameter("Length", 5));
            AddInvalid(ft, 1)
                .NegationResult("NotLengthSpecification<FakeType>")
                .Result("LengthSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<FakeType>), "Object length is not [1]")
                    .Candidate(ft)
                    .AddParameter("Length", 1));
            AddInvalid(ift, 3)
                .NegationResult("NotLengthSpecification<InterFakeType>")
                .Result("LengthSpecification<InterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<InterFakeType>), "Object length is not [3]")
                    .Candidate(ift)
                    .AddParameter("Length", 3));
            AddInvalid("null", 1)
                .NegationResult("NotLengthSpecification<String>")
                .Result("LengthSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<string>), "Object length is not [1]")
                    .Candidate(null)
                    .AddParameter("Length", 1));
            AddInvalid(new FakeType {Second = "null"}, 0)
                .NegationResult("NotLengthSpecification<FakeType>")
                .Result("LengthSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LengthSpecification<FakeType>), "Object length is not [0]")
                    .Candidate(null)
                    .AddParameter("Length", 0));
        }
    }
}