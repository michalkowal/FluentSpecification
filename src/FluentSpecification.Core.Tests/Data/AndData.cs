using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class AndData : SpecificationData<bool, bool>
    {
        public AndData()
        {
            Valid(true, true)
                .Result(2, "TrueMockValidationSpecification And TrueMockValidationSpecification");

            Invalid(false, true)
                .Result(2, "FailedFalseMockValidationSpecification And TrueMockValidationSpecification", c =>
                    c.FailedSpecification(typeof(FalseMockValidationSpecification),
                            "MockValidationSpecification is not satisfied")
                        .AddParameter("Result", false));
            Invalid(true, false)
                .Result(2, "TrueMockValidationSpecification And FailedFalseMockValidationSpecification", c =>
                    c.FailedSpecification(typeof(FalseMockValidationSpecification),
                            "MockValidationSpecification is not satisfied")
                        .AddParameter("Result", false));
            Invalid(false, false)
                .Result(2, "FailedFalseMockValidationSpecification And FailedFalseMockValidationSpecification", c =>
                {
                    c.FailedSpecification(typeof(FalseMockValidationSpecification),
                            "MockValidationSpecification is not satisfied")
                        .AddParameter("Result", false);
                    c.FailedSpecification(typeof(FalseMockValidationSpecification),
                            "MockValidationSpecification is not satisfied")
                        .AddParameter("Result", false);
                });
        }
    }
}