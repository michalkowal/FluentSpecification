using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class TranslatableCompositeData : SpecificationData<string>
    {
        public TranslatableCompositeData()
        {
            Valid("Custom mock message")
                .Result(2, "TrueMockValidationSpecification[System.Object] Mock TrueMockValidationSpecification[System.Object]");

            Invalid("Custom mock message")
                .Result(2, "FailedFalseMockValidationSpecification[System.Object] Mock FailedFalseMockValidationSpecification[System.Object]", c =>
                {
                    c.CustomError("Custom mock message");
                    c.FailedSpecification(typeof(FalseMockValidationSpecification<object>),
                            "MockValidationSpecification is not satisfied")
                        .AddParameter("Result", false);
                    c.FailedSpecification(typeof(FalseMockValidationSpecification<object>),
                            "MockValidationSpecification is not satisfied")
                        .AddParameter("Result", false);
                });
        }
    }
}
