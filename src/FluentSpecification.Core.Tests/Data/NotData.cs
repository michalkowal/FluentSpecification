using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class NotData : SpecificationData<bool>
    {
        public NotData()
        {
            Valid(false)
                .Result("Not(FailedFalseMockComplexSpecification)");
            Valid(true)
                .Result("NotFalseMockNegatableComplexSpecification");

            Invalid(false)
                .Result("Not(TrueMockComplexSpecification)");
            Invalid(true)
                .Result("FailedNotTrueMockNegatableComplexSpecification", c =>
                {
                    c.FailedSpecification(typeof(TrueMockNegatableComplexSpecification),
                            "NotMockNegatableValidationSpecification is satisfied")
                        .AddParameter("Result", true);
                });
        }
    }
}