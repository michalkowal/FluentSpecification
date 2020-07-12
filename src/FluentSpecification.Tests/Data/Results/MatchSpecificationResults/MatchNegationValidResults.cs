using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.MatchSpecificationResults
{
    public class MatchNegationValidResults : List<ExpectedSpecificationResult>
    {
        public MatchNegationValidResults()
        {
            #region "2019-02-261"/"^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$"

            Add(new ExpectedSpecificationResult
            {
                TotalSpecificationsCount = 1,
                OverallResult = true,
                Specifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = true,
                        SpecificationType = typeof(MatchSpecification),
                        IsNegation = true,
                        Parameters = new Dictionary<string, object>
                        {
                            { "Pattern", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$" }
                        },
                        Candidate = "2019-02-261",
                        Errors = new List<string>()
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "NotMatchSpecification",
                    ShortTrace = "NotMatch"
                },
                FailedSpecificationsCount = 0,
                Errors = new List<string>()
            });

            #endregion

            #region null/"^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$"

            Add(new ExpectedSpecificationResult
            {
                TotalSpecificationsCount = 1,
                OverallResult = true,
                Specifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = true,
                        SpecificationType = typeof(MatchSpecification),
                        IsNegation = true,
                        Parameters = new Dictionary<string, object>
                        {
                            { "Pattern", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$" }
                        },
                        Candidate = null,
                        Errors = new List<string>()
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "NotMatchSpecification",
                    ShortTrace = "NotMatch"
                },
                FailedSpecificationsCount = 0,
                Errors = new List<string>()
            });

            #endregion
        }
    }
}
