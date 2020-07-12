using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.TrueSpecificationResults
{
    public class TrueValidResults : List<ExpectedSpecificationResult>
    {
        public TrueValidResults()
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
                        SpecificationType = typeof(TrueSpecification),
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>(),
                        Candidate = true,
                        Errors = new List<string>()
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "TrueSpecification",
                    ShortTrace = "True"
                },
                FailedSpecificationsCount = 0,
                Errors = new List<string>()
            });
        }
    }
}
