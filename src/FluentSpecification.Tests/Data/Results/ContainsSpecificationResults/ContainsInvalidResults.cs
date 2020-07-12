using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.ContainsSpecificationResults
{
    public class ContainsInvalidResults : List<ExpectedSpecificationResult>
    {
        public ContainsInvalidResults()
        {
            #region arr/16

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<Int32[],Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 16 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [16]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<Int32[],Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 16 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [16]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification<Int32[],Int32>+Failed",
                        ShortTrace = "Contains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection not contains [16]"
                    }
                });

            #endregion

            #region list/"Third"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<List<String>,String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "Third" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [Third]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<List<String>,String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "Third" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [Third]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification<List<String>,String>+Failed",
                        ShortTrace = "Contains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection not contains [Third]"
                    }
                });

            #endregion

            #region dict/["Third", false]

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", new KeyValuePair<String, Boolean>("Third", false) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [[Third, False]]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", new KeyValuePair<String, Boolean>("Third", false) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [[Third, False]]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>+Failed",
                        ShortTrace = "Contains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection not contains [[Third, False]]"
                    }
                });

            #endregion

            #region ft/16/intComparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 16 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [16]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 16 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [16]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification<FakeType,Int32>+Failed",
                        ShortTrace = "Contains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection not contains [16]"
                    }
                });

            #endregion

            #region cmpArr/notCmp

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<EquatableFakeType[],EquatableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [Fake(100)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<EquatableFakeType[],EquatableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [Fake(100)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification<EquatableFakeType[],EquatableFakeType>+Failed",
                        ShortTrace = "Contains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection not contains [Fake(100)]"
                    }
                });

            #endregion

            #region ftArr/empty

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<FakeType[],FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [Fake(1)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<FakeType[],FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [Fake(1)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification<FakeType[],FakeType>+Failed",
                        ShortTrace = "Contains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection not contains [Fake(1)]"
                    }
                });

            #endregion

            #region (FakeType)null/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection not contains [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification<FakeType,Int32>+Failed",
                        ShortTrace = "Contains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection not contains [1]"
                    }
                });

            #endregion
        }
    }
}