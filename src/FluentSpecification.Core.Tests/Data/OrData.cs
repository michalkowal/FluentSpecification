using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class OrData : SpecificationData<bool, bool>
    {
        public OrData()
        {
            Valid(true, true)
                .Result(2, "TrueMockValidationSpecification Or TrueMockValidationSpecification");
            Valid(false, true)
                .Result(2, "FailedFalseMockValidationSpecification Or TrueMockValidationSpecification");
            Valid(true, false)
                .Result(2, "TrueMockValidationSpecification Or FailedFalseMockValidationSpecification");

            Invalid(false, false)
                .Result(2, "FailedFalseMockValidationSpecification Or FailedFalseMockValidationSpecification", c =>
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