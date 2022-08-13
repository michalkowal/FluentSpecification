using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class TranslatableData : SpecificationData<string>
    {
        public TranslatableData()
        {
            Valid("Custom mock message")
                .Result("TrueMockValidationSpecification");

            Invalid("Custom mock message")
                .Result("FailedFalseMockValidationSpecification", c => c
                    .CustomError("Custom mock message")
                    .FailedSpecification(typeof(FalseMockValidationSpecification),
                        "MockValidationSpecification is not satisfied")
                    .AddParameter("Result", false));
        }
    }
}
