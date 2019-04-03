using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class StringContainsData : SpecificationData<string, string>
    {
        public StringContainsData()
        {
            SpecificationResult validResult = new SpecificationResult("ContainsSpecification"),
                negationResult = new SpecificationResult("NotContainsSpecification");

            Valid("lorem ipsum", "lorem ipsum")
                .Result(validResult)
                .NegationResult("NotContainsSpecification+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification), "String contains [lorem ipsum]")
                    .Candidate("lorem ipsum")
                    .AddParameter("Expected", "lorem ipsum"));
            Valid("lorem ipsum", "lorem")
                .Result(validResult)
                .NegationResult("NotContainsSpecification+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification), "String contains [lorem]")
                    .Candidate("lorem ipsum")
                    .AddParameter("Expected", "lorem"));
            Valid("lorem ipsum", "ipsum")
                .Result(validResult)
                .NegationResult("NotContainsSpecification+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification), "String contains [ipsum]")
                    .Candidate("lorem ipsum")
                    .AddParameter("Expected", "ipsum"));
            Valid("lorem ipsum", " ")
                .Result(validResult)
                .NegationResult("NotContainsSpecification+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification), "String contains [ ]")
                    .Candidate("lorem ipsum")
                    .AddParameter("Expected", " "));

            Invalid(null, "test")
                .NegationResult(negationResult)
                .Result("ContainsSpecification+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification), "String not contains [test]")
                    .Candidate(null)
                    .AddParameter("Expected", "test"));
            Invalid("test", "Test")
                .NegationResult(negationResult)
                .Result("ContainsSpecification+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification), "String not contains [Test]")
                    .Candidate("test")
                    .AddParameter("Expected", "Test"));
            Invalid("test", "TEST")
                .NegationResult(negationResult)
                .Result("ContainsSpecification+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification), "String not contains [TEST]")
                    .Candidate("test")
                    .AddParameter("Expected", "TEST"));
            Invalid("test", "testing")
                .NegationResult(negationResult)
                .Result("ContainsSpecification+Failed", c => c
                    .FailedSpecification(typeof(ContainsSpecification), "String not contains [testing]")
                    .Candidate("test")
                    .AddParameter("Expected", "testing"));
        }
    }
}