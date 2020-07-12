using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class AdapterData : SpecificationData<bool>
    {
        public AdapterData()
        {
            Valid(false)
                .Result("TrueMockSpecification", "TrueMock", c => c
                    .Specification(typeof(TrueMockSpecification)))
                .NegationResult("NotTrueMockSpecification+Failed", "NotTrueMock+Failed", c => c
                    .FailedSpecification(typeof(TrueMockSpecification),
                        "Specification [TrueMockSpecification] is satisfied by candidate"));
            Valid(true)
                .Result("TrueMockValidationSpecification", "TrueMockValidation", c => c
                    .Specification(typeof(TrueMockValidationSpecification))
                    .AddParameter("Result", true))
                .NegationResult("FailedNotTrueMockNegatableValidationSpecification", "FailedNotTrueMockNegatableValidation", c => c
                    .FailedSpecification(typeof(TrueMockNegatableValidationSpecification),
                        "NotMockNegatableValidationSpecification is satisfied")
                    .AddParameter("Result", true));

            Invalid(false)
                .Result("FalseMockSpecification+Failed", "FalseMock+Failed", c => c
                    .FailedSpecification(typeof(FalseMockSpecification),
                        "Specification [FalseMockSpecification] is not satisfied by candidate"))
                .NegationResult("NotFalseMockSpecification", "NotFalseMock", c => c
                    .Specification(typeof(FalseMockSpecification)));
            Invalid(true)
                .Result("FailedFalseMockValidationSpecification", "FailedFalseMockValidation",c => c
                    .FailedSpecification(typeof(FalseMockValidationSpecification),
                        "MockValidationSpecification is not satisfied")
                    .AddParameter("Result", false))
                .NegationResult("NotFalseMockNegatableValidationSpecification", "NotFalseMockNegatableValidation", c => c
                    .Specification(typeof(FalseMockNegatableValidationSpecification))
                    .AddParameter("Result", false));
        }
    }
}