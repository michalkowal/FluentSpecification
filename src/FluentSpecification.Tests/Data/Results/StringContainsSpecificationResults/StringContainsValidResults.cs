using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.StringContainsSpecificationResults
{
    public class StringContainsValidResults : List<ExpectedSpecificationResult>
    {
        public StringContainsValidResults()
        {
            #region "lorem ipsum"/"lorem ipsum"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(ContainsSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "lorem ipsum" }
                            },
                            Candidate = "lorem ipsum",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification",
                        ShortTrace = "Contains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "lorem ipsum"/"lorem"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(ContainsSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "lorem" }
                            },
                            Candidate = "lorem ipsum",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification",
                        ShortTrace = "Contains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "lorem ipsum"/"ipsum"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(ContainsSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "ipsum" }
                            },
                            Candidate = "lorem ipsum",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification",
                        ShortTrace = "Contains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "lorem ipsum"/" "

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(ContainsSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", " " }
                            },
                            Candidate = "lorem ipsum",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification",
                        ShortTrace = "Contains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion
        }
    }
}