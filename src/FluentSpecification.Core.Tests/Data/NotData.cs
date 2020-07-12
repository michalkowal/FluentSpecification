using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class NotData : SpecificationData
    {
        public NotData()
        {
            AddValid()
                .Result("Not(FailedFalseMockComplexSpecification)", "Not(FailedFalseMockComplex)", c => c
                    .FailedSpecification(typeof(FalseMockComplexSpecification),
                        "MockValidationSpecification is not satisfied")
                    .AddParameter("Result", false))
                .NegationResult("FailedNotTrueMockNegatableComplexSpecification", "FailedNotTrueMockNegatableComplex", c => c
                    .FailedSpecification(typeof(TrueMockNegatableComplexSpecification),
                        "NotMockNegatableValidationSpecification is satisfied")
                    .AddParameter("Result", true));

            AddInvalid()
                .Result("Not(TrueMockComplexSpecification)", "Not(TrueMockComplex)", c => c
                    .Specification(typeof(TrueMockComplexSpecification))
                    .AddParameter("Result", true))
                .NegationResult("NotFalseMockNegatableComplexSpecification", "NotFalseMockNegatableComplex", c => c
                    .Specification(typeof(FalseMockNegatableComplexSpecification))
                    .AddParameter("Result", false));
        }
    }
}