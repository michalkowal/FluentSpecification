using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.TrueSpecificationResults
{
    public class TrueInvalidResults : List<ExpectedSpecificationResult>
    {
        public TrueInvalidResults()
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
                        SpecificationType = typeof(TrueSpecification),
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>(),
                        Candidate = false,
                        Errors = new List<string>
                        {
                            "Value is False"
                        }
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = false,
                        SpecificationType = typeof(TrueSpecification),
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>(),
                        Candidate = false,
                        Errors = new List<string>
                        {
                            "Value is False"
                        }
                    }
                },
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "TrueSpecification+Failed",
                    ShortTrace = "True+Failed"
                },
                FailedSpecificationsCount = 1,
                Errors = new List<string>
                {
                    "Value is False"
                }
            });
        }
    }
}
