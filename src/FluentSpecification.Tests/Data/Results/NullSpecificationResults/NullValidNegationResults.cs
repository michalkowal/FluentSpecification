using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;
using System.Collections.Generic;

namespace FluentSpecification.Tests.Data.Results.NullSpecificationResults
{
    public class NullValidNegationResults : List<ExpectedSpecificationResult>
    {
        public NullValidNegationResults()
        {
            #region ""

            Add(new ExpectedSpecificationResult
            {
                TotalSpecificationsCount = 1,
                OverallResult = true,
                Specifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = true,
                        SpecificationType = typeof(NullSpecification<string>),
                        IsNegation = true,
                        Parameters = new Dictionary<string, object>(),
                        Candidate = "",
                        Errors = new List<string>()
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "NotNullSpecification<String>",
                    ShortTrace = "NotNull"
                },
                FailedSpecificationsCount = 0,
                Errors = new List<string>()
            });

            #endregion

            #region 0

            Add(new ExpectedSpecificationResult
            {
                TotalSpecificationsCount = 1,
                OverallResult = true,
                Specifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = true,
                        SpecificationType = typeof(NullSpecification<int>),
                        IsNegation = true,
                        Parameters = new Dictionary<string, object>(),
                        Candidate = 0,
                        Errors = new List<string>()
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "NotNullSpecification<Int32>",
                    ShortTrace = "NotNull"
                },
                FailedSpecificationsCount = 0,
                Errors = new List<string>()
            });

            #endregion
        }
    }
}
