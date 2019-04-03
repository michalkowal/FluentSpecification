using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class EmptyData : SpecificationData
    {
        public EmptyData()
        {
            var emptyArr = new int[0];
            var emptyList = new List<string>();
            var emptyDict = new Dictionary<string, bool>();
            var emptyFake = new FakeType();

            AddValid((object) null)
                .Result("EmptySpecification<Object>")
                .NegationResult("NotEmptySpecification<Object>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<object>), "Object is empty")
                    .Candidate(null));
            AddValid("null")
                .Result("EmptySpecification<String>")
                .NegationResult("NotEmptySpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<string>), "Object is empty")
                    .Candidate(null));
            AddValid(new FakeType {Second = "null"})
                .Result("EmptySpecification<FakeType>")
                .NegationResult("NotEmptySpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<FakeType>), "Object is empty")
                    .Candidate(null));
            AddValid("")
                .Result("EmptySpecification<String>")
                .NegationResult("NotEmptySpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<string>), "Object is empty")
                    .Candidate(""));
            AddValid(0)
                .Result("EmptySpecification<Int32>")
                .NegationResult("NotEmptySpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<int>), "Object is empty")
                    .Candidate(0));
            AddValid(0.0)
                .Result("EmptySpecification<Double>")
                .NegationResult("NotEmptySpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<double>), "Object is empty")
                    .Candidate(0.0));
            AddValid(false)
                .Result("EmptySpecification<Boolean>")
                .NegationResult("NotEmptySpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<bool>), "Object is empty")
                    .Candidate(false));
            AddValid(emptyArr)
                .Result("EmptySpecification<Int32[]>")
                .NegationResult("NotEmptySpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<int[]>), "Object is empty")
                    .Candidate(emptyArr));
            AddValid(emptyList)
                .Result("EmptySpecification<List<String>>")
                .NegationResult("NotEmptySpecification<List<String>>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<List<string>>), "Object is empty")
                    .Candidate(emptyList));
            AddValid(emptyDict)
                .Result("EmptySpecification<Dictionary<String,Boolean>>")
                .NegationResult("NotEmptySpecification<Dictionary<String,Boolean>>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<Dictionary<string, bool>>), "Object is empty")
                    .Candidate(emptyDict));
            AddValid(emptyFake)
                .Result("EmptySpecification<FakeType>")
                .NegationResult("NotEmptySpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<FakeType>), "Object is empty")
                    .Candidate(emptyFake));

            var obj = new object();
            var arr = new[] {-1};
            var list = new List<string> {"123"};
            var dict = new Dictionary<string, bool> {{"1", false}};
            var fake = new FakeType {Fourth = new[] {1, 2, 3}};

            AddInvalid(obj)
                .NegationResult("NotEmptySpecification<Object>")
                .Result("EmptySpecification<Object>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<object>), "Object is not empty")
                    .Candidate(obj));
            AddInvalid(" ")
                .NegationResult("NotEmptySpecification<String>")
                .Result("EmptySpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<string>), "Object is not empty")
                    .Candidate(" "));
            AddInvalid("\t")
                .NegationResult("NotEmptySpecification<String>")
                .Result("EmptySpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<string>), "Object is not empty")
                    .Candidate("\t"));
            AddInvalid("\n")
                .NegationResult("NotEmptySpecification<String>")
                .Result("EmptySpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<string>), "Object is not empty")
                    .Candidate("\n"));
            AddInvalid("\r")
                .NegationResult("NotEmptySpecification<String>")
                .Result("EmptySpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<string>), "Object is not empty")
                    .Candidate("\r"));
            AddInvalid("test")
                .NegationResult("NotEmptySpecification<String>")
                .Result("EmptySpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<string>), "Object is not empty")
                    .Candidate("test"));
            AddInvalid(1)
                .NegationResult("NotEmptySpecification<Int32>")
                .Result("EmptySpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<int>), "Object is not empty")
                    .Candidate(1));
            AddInvalid(0.1)
                .NegationResult("NotEmptySpecification<Double>")
                .Result("EmptySpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<double>), "Object is not empty")
                    .Candidate(0.1));
            AddInvalid(true)
                .NegationResult("NotEmptySpecification<Boolean>")
                .Result("EmptySpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<bool>), "Object is not empty")
                    .Candidate(true));
            AddInvalid(arr)
                .NegationResult("NotEmptySpecification<Int32[]>")
                .Result("EmptySpecification<Int32[]>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<int[]>), "Object is not empty")
                    .Candidate(arr));
            AddInvalid(list)
                .NegationResult("NotEmptySpecification<List<String>>")
                .Result("EmptySpecification<List<String>>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<List<string>>), "Object is not empty")
                    .Candidate(list));
            AddInvalid(dict)
                .NegationResult("NotEmptySpecification<Dictionary<String,Boolean>>")
                .Result("EmptySpecification<Dictionary<String,Boolean>>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<Dictionary<string, bool>>), "Object is not empty")
                    .Candidate(dict));
            AddInvalid(fake)
                .NegationResult("NotEmptySpecification<FakeType>")
                .Result("EmptySpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(EmptySpecification<FakeType>), "Object is not empty")
                    .Candidate(fake));
        }
    }
}