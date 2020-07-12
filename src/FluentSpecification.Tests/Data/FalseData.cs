using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.FalseSpecificationResults;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class FalseData : SpecificationData
    {
        public FalseData()
        {
            var factory = new FalseFactory();

            AddValidWithResult<bool, FalseValidResults>(false, factory);
            AddInvalidWithResult<bool, FalseInvalidResults>(true, factory);
        }
    }
}
