using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class TranslatableCompositeData : SpecificationData<string>
    {
        public TranslatableCompositeData()
        {
            Valid("Custom mock message")
                .Result(2, "MockCompositeInternalSpecification Mock MockCompositeInternalSpecification");

            Invalid("Custom mock message")
                .Result(2, "FailedMockCompositeInternalSpecification Mock FailedMockCompositeInternalSpecification", c =>
                {
                    c.CustomError("Custom mock message");
                    c.FailedSpecification(typeof(FalseMockCompositeSpecification<object>.InternalSpecification),
                            "MockValidationSpecification is not satisfied")
                        .AddParameter("Result", false)
                        .AddParameter("External", 0);
                    c.FailedSpecification(typeof(FalseMockCompositeSpecification<object>.InternalSpecification),
                            "MockValidationSpecification is not satisfied")
                        .AddParameter("Result", false)
                        .AddParameter("External", 0);
                });
        }
    }
}
