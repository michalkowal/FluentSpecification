using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.MatchSpecificationResults;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class MatchData : SpecificationData
    {
        private void Valid(string candidate, string pattern)
        {
            AddValidWithResults<string, MatchValidResults, MatchNegationInvalidResults>(
                candidate, new MatchFactory(pattern));
        }
        private void Invalid(string candidate, string pattern)
        {
            AddInvalidWithResults<string, MatchInvalidResults, MatchNegationValidResults>(
                candidate, new MatchFactory(pattern));
        }

        public MatchData()
        {
            Valid("2019-02-26", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$");
            Invalid("2019-02-261", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$");
            Invalid(null, "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$");
        }
    }
}
