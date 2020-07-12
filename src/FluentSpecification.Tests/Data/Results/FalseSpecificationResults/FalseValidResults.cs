using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.FalseSpecificationResults
{
    public class FalseValidResults : List<ExpectedSpecificationResult>
    {
        public FalseValidResults()
        {
            Add(new ExpectedSpecificationResult
            {
                TotalSpecificationsCount = 1,
                OverallResult = true,
                Specifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = true,
                        SpecificationType = typeof(FalseSpecification),
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>(),
                        Candidate = false,
                        Errors = new List<string>()
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "FalseSpecification",
                    ShortTrace = "False"
                },
                FailedSpecificationsCount = 0,
                Errors = new List<string>()
            });
        }
    }
}
