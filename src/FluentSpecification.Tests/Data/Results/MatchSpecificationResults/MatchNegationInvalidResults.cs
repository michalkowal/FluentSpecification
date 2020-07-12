using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.MatchSpecificationResults
{
    public class MatchNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public MatchNegationInvalidResults()
        {
            #region "2019-02-26"/"^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$"

            Add(new ExpectedSpecificationResult
            {
                TotalSpecificationsCount = 1,
                OverallResult = false,
                Specifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = false,
                        SpecificationType = typeof(MatchSpecification),
                        IsNegation = true,
                        Parameters = new Dictionary<string, object>
                        {
                            { "Pattern", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$" }
                        },
                        Candidate = "2019-02-26",
                        Errors = new List<string>
                        {
                            "String match pattern [^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$]"
                        }
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = false,
                        SpecificationType = typeof(MatchSpecification),
                        IsNegation = true,
                        Parameters = new Dictionary<string, object>
                        {
                            { "Pattern", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$" }
                        },
                        Candidate = "2019-02-26",
                        Errors = new List<string>
                        {
                            "String match pattern [^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$]"
                        }
                    }
                },
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "NotMatchSpecification+Failed",
                    ShortTrace = "NotMatch+Failed"
                },
                FailedSpecificationsCount = 1,
                Errors = new List<string>
                {
                    "String match pattern [^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$]"
                }
            });

            #endregion
        }
    }
}
