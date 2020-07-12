using System.Collections.Generic;
using System.Reflection;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class ComplexData : SpecificationData
    {
        public ComplexData()
        {
            AddValid(1)
                .Result("MockCommonSpecification<Int32>", "MockCommon", c => c
                    .Specification(typeof(MockCommonSpecification<int>))
                    .Candidate(1))
                .NegationResult("NotMockCommonSpecification<Int32>+Failed", "NotMockCommon+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<int>), "Match")
                    .Candidate(1));
            AddValid(1.5)
                .Result("MockCommonSpecification<Double>", "MockCommon", c => c
                    .Specification(typeof(MockCommonSpecification<double>))
                    .Candidate(1.5))
                .NegationResult("NotMockCommonSpecification<Double>+Failed", "NotMockCommon+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<double>), "Match")
                    .Candidate(1.5));
            AddValid(true)
                .Result("MockCommonSpecification<Boolean>", "MockCommon", c => c
                    .Specification(typeof(MockCommonSpecification<bool>))
                    .Candidate(true))
                .NegationResult("NotMockCommonSpecification<Boolean>+Failed", "NotMockCommon+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<bool>), "Match")
                    .Candidate(true));
            AddValid(BindingFlags.NonPublic)
                .Result("MockCommonSpecification<BindingFlags>", "MockCommon", c => c
                    .Specification(typeof(MockCommonSpecification<BindingFlags>))
                    .Candidate(BindingFlags.NonPublic))
                .NegationResult("NotMockCommonSpecification<BindingFlags>+Failed", "NotMockCommon+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<BindingFlags>), "Match")
                    .Candidate(BindingFlags.NonPublic));

            var obj = new object();
            var list = new List<int>();
            var fake = new FakeType();
            AddInvalid(obj)
                .Result("MockCommonSpecification<Object>+Failed", "MockCommon+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<object>), "Not match")
                    .Candidate(obj))
                .NegationResult("NotMockCommonSpecification<Object>", "NotMockCommon", c => c
                    .Specification(typeof(MockCommonSpecification<object>))
                    .Candidate(obj));
            AddInvalid(list)
                .Result("MockCommonSpecification<List<Int32>>+Failed", "MockCommon+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<List<int>>), "Not match")
                    .Candidate(list))
                .NegationResult("NotMockCommonSpecification<List<Int32>>", "NotMockCommon", c => c
                    .Specification(typeof(MockCommonSpecification<List<int>>))
                    .Candidate(list));
            AddInvalid(fake)
                .Result("MockCommonSpecification<FakeType>+Failed", "MockCommon+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<FakeType>), "Not match")
                    .Candidate(fake))
                .NegationResult("NotMockCommonSpecification<FakeType>", "NotMockCommon", c => c
                    .Specification(typeof(MockCommonSpecification<FakeType>))
                    .Candidate(fake));
            AddInvalid("")
                .Result("MockCommonSpecification<String>+Failed", "MockCommon+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<string>), "Not match")
                    .Candidate(""))
                .NegationResult("NotMockCommonSpecification<String>", "NotMockCommon", c => c
                    .Specification(typeof(MockCommonSpecification<string>))
                    .Candidate(""));
        }
    }
}