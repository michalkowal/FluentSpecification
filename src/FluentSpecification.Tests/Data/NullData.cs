using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.NullSpecificationResults;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class NullData : SpecificationData
    {
        private void Valid<T>(T candidate)
        {
            AddValidWithResults<T, NullValidResults, NullInvalidNegationResults>(
                candidate, new NullFactory<T>());
        }

        private void Invalid<T>(T candidate)
        {
            AddInvalidWithResults<T, NullInvalidResults, NullValidNegationResults>(
                candidate, new NullFactory<T>());
        }

        public NullData()
        {
            Valid<string>(null);
            Valid<int?>(null);

            Invalid("");
            Invalid(0);
        }
    }
}
