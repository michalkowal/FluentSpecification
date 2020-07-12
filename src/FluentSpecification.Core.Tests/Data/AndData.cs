using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class AndData : SpecificationData<bool, bool>
    {
        public AndData()
        {
            Valid(true, true)
                .Result("TrueMockValidationSpecification And TrueMockValidationSpecification",
                    "TrueMockValidation And TrueMockValidation", c =>
                    {
                        c.Specification(typeof(TrueMockValidationSpecification))
                            .AddParameter("Result", true);
                        c.Specification(typeof(TrueMockValidationSpecification))
                            .AddParameter("Result", true);
                    });

            Invalid(false, true)
                .Result("FailedFalseMockValidationSpecification And TrueMockValidationSpecification",
                    "FailedFalseMockValidation And TrueMockValidation", c =>
                    {
                        c.FailedSpecification(typeof(FalseMockValidationSpecification),
                                "MockValidationSpecification is not satisfied")
                            .AddParameter("Result", false);
                        c.Specification(typeof(TrueMockValidationSpecification))
                            .AddParameter("Result", true);
                    });
            Invalid(true, false)
                .Result("TrueMockValidationSpecification And FailedFalseMockValidationSpecification",
                    "TrueMockValidation And FailedFalseMockValidation", c =>
                    {
                        c.Specification(typeof(TrueMockValidationSpecification))
                            .AddParameter("Result", true);
                        c.FailedSpecification(typeof(FalseMockValidationSpecification),
                                "MockValidationSpecification is not satisfied")
                            .AddParameter("Result", false);
                    });
            Invalid(false, false)
                .Result("FailedFalseMockValidationSpecification And FailedFalseMockValidationSpecification",
                    "FailedFalseMockValidation And FailedFalseMockValidation", c =>
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