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
                .Result("MockCommonSpecification<Int32>")
                .NegationResult("NotMockCommonSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<int>), "Match")
                    .Candidate(1));
            AddValid(1.5)
                .Result("MockCommonSpecification<Double>")
                .NegationResult("NotMockCommonSpecification<Double>+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<double>), "Match")
                    .Candidate(1.5));
            AddValid(true)
                .Result("MockCommonSpecification<Boolean>")
                .NegationResult("NotMockCommonSpecification<Boolean>+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<bool>), "Match")
                    .Candidate(true));
            AddValid(BindingFlags.NonPublic)
                .Result("MockCommonSpecification<BindingFlags>")
                .NegationResult("NotMockCommonSpecification<BindingFlags>+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<BindingFlags>), "Match")
                    .Candidate(BindingFlags.NonPublic));

            var obj = new object();
            var list = new List<int>();
            var fake = new FakeType();
            AddInvalid(obj)
                .Result("MockCommonSpecification<Object>+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<object>), "Not match")
                    .Candidate(obj))
                .NegationResult("NotMockCommonSpecification<Object>");
            AddInvalid(list)
                .Result("MockCommonSpecification<List<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<List<int>>), "Not match")
                    .Candidate(list))
                .NegationResult("NotMockCommonSpecification<List<Int32>>");
            AddInvalid(fake)
                .Result("MockCommonSpecification<FakeType>+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<FakeType>), "Not match")
                    .Candidate(fake))
                .NegationResult("NotMockCommonSpecification<FakeType>");
            AddInvalid("")
                .Result("MockCommonSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(MockCommonSpecification<string>), "Not match")
                    .Candidate(""))
                .NegationResult("NotMockCommonSpecification<String>");
        }
    }
}