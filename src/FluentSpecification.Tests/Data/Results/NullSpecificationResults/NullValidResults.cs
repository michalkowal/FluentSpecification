using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;
using System.Collections.Generic;

namespace FluentSpecification.Tests.Data.Results.NullSpecificationResults
{
    public class NullValidResults : List<ExpectedSpecificationResult>
    {
        public NullValidResults()
        {
            #region (string)null

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
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>(),
                        Candidate = null,
                        Errors = new List<string>()
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "NullSpecification<String>",
                    ShortTrace = "Null"
                },
                FailedSpecificationsCount = 0,
                Errors = new List<string>()
            });

            #endregion

            #region (int?)null

            Add(new ExpectedSpecificationResult
            {
                TotalSpecificationsCount = 1,
                OverallResult = true,
                Specifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = true,
                        SpecificationType = typeof(NullSpecification<int?>),
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>(),
                        Candidate = null,
                        Errors = new List<string>()
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "NullSpecification<Nullable<Int32>>",
                    ShortTrace = "Null"
                },
                FailedSpecificationsCount = 0,
                Errors = new List<string>()
            });

            #endregion
        }
    }
}
