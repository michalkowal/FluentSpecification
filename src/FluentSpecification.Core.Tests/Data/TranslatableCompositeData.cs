using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class TranslatableCompositeData : SpecificationData<string>
    {
        public TranslatableCompositeData()
        {
            Valid("Custom mock message")
                .Result(2, "TrueMockComplexSpecification Mock TrueMockComplexSpecification");

            Invalid("Custom mock message")
                .Result(2, "FailedFalseMockComplexSpecification Mock FailedFalseMockComplexSpecification", c =>
                {
                    c.CustomError("Custom mock message");
                    c.FailedSpecification(typeof(FalseMockComplexSpecification),
                            "MockComplexSpecification is not satisfied")
                        .AddParameter("Result", false);
                    c.FailedSpecification(typeof(FalseMockComplexSpecification),
                            "MockComplexSpecification is not satisfied")
                        .AddParameter("Result", false);
                });
        }
    }
}
