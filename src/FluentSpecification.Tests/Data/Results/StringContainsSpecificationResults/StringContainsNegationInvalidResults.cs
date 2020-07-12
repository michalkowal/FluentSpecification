using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.StringContainsSpecificationResults
{
    public class StringContainsNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public StringContainsNegationInvalidResults()
        {
            #region "lorem ipsum"/"lorem ipsum"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "lorem ipsum" }
                            },
                            Candidate = "lorem ipsum",
                            Errors = new List<string>
                            {
                                "String contains [lorem ipsum]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "lorem ipsum" }
                            },
                            Candidate = "lorem ipsum",
                            Errors = new List<string>
                            {
                                "String contains [lorem ipsum]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String contains [lorem ipsum]"
                    }
                });

            #endregion

            #region "lorem ipsum"/"lorem"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "lorem" }
                            },
                            Candidate = "lorem ipsum",
                            Errors = new List<string>
                            {
                                "String contains [lorem]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "lorem" }
                            },
                            Candidate = "lorem ipsum",
                            Errors = new List<string>
                            {
                                "String contains [lorem]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String contains [lorem]"
                    }
                });

            #endregion

            #region "lorem ipsum"/"ipsum"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "ipsum" }
                            },
                            Candidate = "lorem ipsum",
                            Errors = new List<string>
                            {
                                "String contains [ipsum]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "ipsum" }
                            },
                            Candidate = "lorem ipsum",
                            Errors = new List<string>
                            {
                                "String contains [ipsum]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String contains [ipsum]"
                    }
                });

            #endregion

            #region "lorem ipsum"/" "

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", " " }
                            },
                            Candidate = "lorem ipsum",
                            Errors = new List<string>
                            {
                                "String contains [ ]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", " " }
                            },
                            Candidate = "lorem ipsum",
                            Errors = new List<string>
                            {
                                "String contains [ ]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String contains [ ]"
                    }
                });

            #endregion
        }
    }
}