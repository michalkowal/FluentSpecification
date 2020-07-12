using System.Linq;

namespace FluentSpecification.Tests.Sdk.Data.Validation
{
    public class ValidationSpecificationTestCaseData<TCandidate, TFactory> : SpecificationTestCaseData<TCandidate, TFactory>
        where TFactory : SpecificationFactory<TCandidate>
    {
        public ExpectedSpecificationResult ExpectedResult { get; }

        public ValidationSpecificationTestCaseData(TCandidate candidate, 
            TFactory factory, ExpectedSpecificationResult expectedResult) : 
            base(candidate, factory)
        {
            ExpectedResult = expectedResult;
        }

        public override object[] ToArray()
        {
            var result = base.ToArray();
            result = result.Concat(new object[] {ExpectedResult}).ToArray();

            return result;
        }
    }
}
