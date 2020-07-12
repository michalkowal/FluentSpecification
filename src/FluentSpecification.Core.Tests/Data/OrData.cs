using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class OrData : SpecificationData<bool, bool>
    {
        public OrData()
        {
            Valid(true, true)
                .Result("TrueMockValidationSpecification Or TrueMockValidationSpecification",
                    "TrueMockValidation Or TrueMockValidation", c =>
                    {
                        c.Specification(typeof(TrueMockValidationSpecification))
                            .AddParameter("Result", true);
                        c.Specification(typeof(TrueMockValidationSpecification))
                            .AddParameter("Result", true);
                    });
            Valid(false, true)
                .Result("FailedFalseMockValidationSpecification Or TrueMockValidationSpecification",
                    "FailedFalseMockValidation Or TrueMockValidation", c =>
                    {
                        c.FailedSpecification(typeof(FalseMockValidationSpecification),
                                "MockValidationSpecification is not satisfied")
                            .AddParameter("Result", false);
                        c.Specification(typeof(TrueMockValidationSpecification))
                            .AddParameter("Result", true);
                    });
            Valid(true, false)
                .Result("TrueMockValidationSpecification Or FailedFalseMockValidationSpecification",
                    "TrueMockValidation Or FailedFalseMockValidation", c =>
                    {
                        c.Specification(typeof(TrueMockValidationSpecification))
                            .AddParameter("Result", true);
                        c.FailedSpecification(typeof(FalseMockValidationSpecification),
                                "MockValidationSpecification is not satisfied")
                            .AddParameter("Result", false);
                    });

            Invalid(false, false)
                .Result("FailedFalseMockValidationSpecification Or FailedFalseMockValidationSpecification",
                    "FailedFalseMockValidation Or FailedFalseMockValidation", c =>
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