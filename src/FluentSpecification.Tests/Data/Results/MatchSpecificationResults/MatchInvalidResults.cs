using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.MatchSpecificationResults
{
    public class MatchInvalidResults : List<ExpectedSpecificationResult>
    {
        public MatchInvalidResults()
        {
            #region "2019-02-261"/"^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$"

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
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>
                        {
                            { "Pattern", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$" }
                        },
                        Candidate = "2019-02-261",
                        Errors = new List<string>
                        {
                            "String not match pattern [^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$]"
                        }
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = false,
                        SpecificationType = typeof(MatchSpecification),
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>
                        {
                            { "Pattern", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$" }
                        },
                        Candidate = "2019-02-261",
                        Errors = new List<string>
                        {
                            "String not match pattern [^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$]"
                        }
                    }
                },
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "MatchSpecification+Failed",
                    ShortTrace = "Match+Failed"
                },
                FailedSpecificationsCount = 1,
                Errors = new List<string>
                {
                    "String not match pattern [^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$]"
                }
            });

            #endregion

            #region null/"^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$"

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
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>
                        {
                            { "Pattern", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$" }
                        },
                        Candidate = null,
                        Errors = new List<string>
                        {
                            "String not match pattern [^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$]"
                        }
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = false,
                        SpecificationType = typeof(MatchSpecification),
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>
                        {
                            { "Pattern", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$" }
                        },
                        Candidate = null,
                        Errors = new List<string>
                        {
                            "String not match pattern [^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$]"
                        }
                    }
                },
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "MatchSpecification+Failed",
                    ShortTrace = "Match+Failed"
                },
                FailedSpecificationsCount = 1,
                Errors = new List<string>
                {
                    "String not match pattern [^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$]"
                }
            });

            #endregion
        }
    }
}
