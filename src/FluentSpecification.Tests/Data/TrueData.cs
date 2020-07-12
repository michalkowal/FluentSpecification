using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.TrueSpecificationResults;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class TrueData : SpecificationData
    {
        public TrueData()
        {
            var factory = new TrueFactory();

            AddValidWithResult<bool, TrueValidResults>(true, factory);
            AddInvalidWithResult<bool, TrueInvalidResults>(false, factory);
        }
    }
}
