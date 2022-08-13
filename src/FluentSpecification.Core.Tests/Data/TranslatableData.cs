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
                .Result("FalseMockValidationSpecification+Failed", c => c
                    .FailedSpecification(typeof(FalseMockValidationSpecification),
                        "Custom mock message")
                    .AddParameter("Result", false));
        }
    }
}
