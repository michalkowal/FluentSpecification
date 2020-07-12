using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.StringContainsSpecificationResults;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class StringContainsData : SpecificationData
    {
        private void Valid(string candidate, string expected)
        {
            AddValidWithResults<string, StringContainsValidResults, StringContainsNegationInvalidResults>(
                candidate, new StringContainsFactory(expected));
        }

        private void Invalid(string candidate, string expected)
        {
            AddInvalidWithResults<string, StringContainsInvalidResults, StringContainsNegationValidResults>(
                candidate, new StringContainsFactory(expected));
        }

        public StringContainsData()
        {
            Valid("lorem ipsum", "lorem ipsum");
            Valid("lorem ipsum", "lorem");
            Valid("lorem ipsum", "ipsum");
            Valid("lorem ipsum", " ");

            Invalid(null, "test");
            Invalid("test", "Test");
            Invalid("test", "TEST");
            Invalid("test", "testing");
        }
    }
}