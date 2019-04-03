using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class LengthBetweenData : SpecificationData
    {
        public LengthBetweenData()
        {
            int[] emptyArr = new int[0], arr = {1, 2, 3};
            var list = new List<int> {1, 2, 3};
            var dict = new Dictionary<int, bool> {{1, false}, {2, true}};
            var ft = new FakeType {Fourth = new[] {1, 2, 3}};
            var ift = new InterFakeType();

            AddValid("", 0, 0)
                .Result("LengthBetweenSpecification<String>")
                .NegationResult("NotLengthBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<string>),
                        "Object length is between [0] and [0]")
                    .Candidate("")
                    .AddParameter("MinLength", 0)
                    .AddParameter("MaxLength", 0));
            AddValid("test", 1, 4)
                .Result("LengthBetweenSpecification<String>")
                .NegationResult("NotLengthBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<string>),
                        "Object length is between [1] and [4]")
                    .Candidate("test")
                    .AddParameter("MinLength", 1)
                    .AddParameter("MaxLength", 4));
            AddValid(emptyArr, 0, 0)
                .Result("LengthBetweenSpecification<Int32[]>")
                .NegationResult("NotLengthBetweenSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<int[]>),
                        "Object length is between [0] and [0]")
                    .Candidate(emptyArr)
                    .AddParameter("MinLength", 0)
                    .AddParameter("MaxLength", 0));
            AddValid(arr, 2, 3)
                .Result("LengthBetweenSpecification<Int32[]>")
                .NegationResult("NotLengthBetweenSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<int[]>),
                        "Object length is between [2] and [3]")
                    .Candidate(arr)
                    .AddParameter("MinLength", 2)
                    .AddParameter("MaxLength", 3));
            AddValid(list, -1, 10)
                .Result("LengthBetweenSpecification<List<Int32>>")
                .NegationResult("NotLengthBetweenSpecification<List<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<List<int>>),
                        "Object length is between [-1] and [10]")
                    .Candidate(list)
                    .AddParameter("MinLength", -1)
                    .AddParameter("MaxLength", 10));
            AddValid(dict, 0, 5)
                .Result("LengthBetweenSpecification<Dictionary<Int32,Boolean>>")
                .NegationResult("NotLengthBetweenSpecification<Dictionary<Int32,Boolean>>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<Dictionary<int, bool>>),
                        "Object length is between [0] and [5]")
                    .Candidate(dict)
                    .AddParameter("MinLength", 0)
                    .AddParameter("MaxLength", 5));
            AddValid(ft, 0, 3)
                .Result("LengthBetweenSpecification<FakeType>")
                .NegationResult("NotLengthBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<FakeType>),
                        "Object length is between [0] and [3]")
                    .Candidate(ft)
                    .AddParameter("MinLength", 0)
                    .AddParameter("MaxLength", 3));
            AddValid(ift, 1, 1)
                .Result("LengthBetweenSpecification<InterFakeType>")
                .NegationResult("NotLengthBetweenSpecification<InterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<InterFakeType>),
                        "Object length is between [1] and [1]")
                    .Candidate(ift)
                    .AddParameter("MinLength", 1)
                    .AddParameter("MaxLength", 1));

            AddInvalid("", 1, 10)
                .NegationResult("NotLengthBetweenSpecification<String>")
                .Result("LengthBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<string>),
                        "Object length is not between [1] and [10]")
                    .Candidate("")
                    .AddParameter("MinLength", 1)
                    .AddParameter("MaxLength", 10));
            AddInvalid("test", 10, 20)
                .NegationResult("NotLengthBetweenSpecification<String>")
                .Result("LengthBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<string>),
                        "Object length is not between [10] and [20]")
                    .Candidate("test")
                    .AddParameter("MinLength", 10)
                    .AddParameter("MaxLength", 20));
            AddInvalid(emptyArr, 1, 2)
                .NegationResult("NotLengthBetweenSpecification<Int32[]>")
                .Result("LengthBetweenSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<int[]>),
                        "Object length is not between [1] and [2]")
                    .Candidate(emptyArr)
                    .AddParameter("MinLength", 1)
                    .AddParameter("MaxLength", 2));
            AddInvalid(arr, -5, -1)
                .NegationResult("NotLengthBetweenSpecification<Int32[]>")
                .Result("LengthBetweenSpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<int[]>),
                        "Object length is not between [-5] and [-1]")
                    .Candidate(arr)
                    .AddParameter("MinLength", -5)
                    .AddParameter("MaxLength", -1));
            AddInvalid(list, 0, 1)
                .NegationResult("NotLengthBetweenSpecification<List<Int32>>")
                .Result("LengthBetweenSpecification<List<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<List<int>>),
                        "Object length is not between [0] and [1]")
                    .Candidate(list)
                    .AddParameter("MinLength", 0)
                    .AddParameter("MaxLength", 1));
            AddInvalid(dict, 0, 1)
                .NegationResult("NotLengthBetweenSpecification<Dictionary<Int32,Boolean>>")
                .Result("LengthBetweenSpecification<Dictionary<Int32,Boolean>>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<Dictionary<int, bool>>),
                        "Object length is not between [0] and [1]")
                    .Candidate(dict)
                    .AddParameter("MinLength", 0)
                    .AddParameter("MaxLength", 1));
            AddInvalid(ft, 4, 6)
                .NegationResult("NotLengthBetweenSpecification<FakeType>")
                .Result("LengthBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<FakeType>),
                        "Object length is not between [4] and [6]")
                    .Candidate(ft)
                    .AddParameter("MinLength", 4)
                    .AddParameter("MaxLength", 6));
            AddInvalid(ift, 4, 6)
                .NegationResult("NotLengthBetweenSpecification<InterFakeType>")
                .Result("LengthBetweenSpecification<InterFakeType>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<InterFakeType>),
                        "Object length is not between [4] and [6]")
                    .Candidate(ift)
                    .AddParameter("MinLength", 4)
                    .AddParameter("MaxLength", 6));
            AddInvalid("null", 0, 1)
                .NegationResult("NotLengthBetweenSpecification<String>")
                .Result("LengthBetweenSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<string>),
                        "Object length is not between [0] and [1]")
                    .Candidate(null)
                    .AddParameter("MinLength", 0)
                    .AddParameter("MaxLength", 1));
            AddInvalid(new FakeType {Second = "null"}, 0, 0)
                .NegationResult("NotLengthBetweenSpecification<FakeType>")
                .Result("LengthBetweenSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(LengthBetweenSpecification<FakeType>),
                        "Object length is not between [0] and [0]")
                    .Candidate(null)
                    .AddParameter("MinLength", 0)
                    .AddParameter("MaxLength", 0));
        }
    }
}