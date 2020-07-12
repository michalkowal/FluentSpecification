using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.FalseSpecificationResults
{
    public class FalseInvalidResults : List<ExpectedSpecificationResult>
    {
        public FalseInvalidResults()
        {
            Add(new ExpectedSpecificationResult
            {
                TotalSpecificationsCount = 1,
                OverallResult = false,
                Specifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = false,
                        SpecificationType = typeof(FalseSpecification),
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>(),
                        Candidate = true,
                        Errors = new List<string>
                        {
                            "Value is True"
                        }
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = false,
                        SpecificationType = typeof(FalseSpecification),
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>(),
                        Candidate = true,
                        Errors = new List<string>
                        {
                            "Value is True"
                        }
                    }
                },
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "FalseSpecification+Failed",
                    ShortTrace = "False+Failed"
                },
                FailedSpecificationsCount = 1,
                Errors = new List<string>
                {
                    "Value is True"
                }
            });
        }
    }
}
