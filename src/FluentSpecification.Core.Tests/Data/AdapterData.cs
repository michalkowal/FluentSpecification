using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class AdapterData : SpecificationData<bool>
    {
        public AdapterData()
        {
            Valid(false)
                .Result("TrueMockSpecification")
                .NegationResult("NotTrueMockSpecification+Failed", c => c
                    .FailedSpecification(typeof(TrueMockSpecification),
                        "Specification [TrueMockSpecification] is satisfied by candidate"));
            Valid(true)
                .Result("TrueMockValidationSpecification")
                .NegationResult("FailedNotTrueMockNegatableValidationSpecification", c => c
                    .FailedSpecification(typeof(TrueMockNegatableValidationSpecification),
                        "NotMockNegatableValidationSpecification is satisfied")
                    .AddParameter("Result", true));

            Invalid(false)
                .Result("FalseMockSpecification+Failed", c => c
                    .FailedSpecification(typeof(FalseMockSpecification),
                        "Specification [FalseMockSpecification] is not satisfied by candidate"))
                .NegationResult("NotFalseMockSpecification");
            Invalid(true)
                .Result("FailedFalseMockValidationSpecification", c => c
                    .FailedSpecification(typeof(FalseMockValidationSpecification),
                        "MockValidationSpecification is not satisfied")
                    .AddParameter("Result", false))
                .NegationResult("NotFalseMockNegatableValidationSpecification");
        }
    }
}