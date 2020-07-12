using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.ContainsSpecificationResults
{
    public class ContainsNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public ContainsNegationInvalidResults()
        {
            #region arr/5

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 5 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<Int32[],Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 5 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<Int32[],Int32>+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection contains [5]"
                    }
                });

            #endregion

            #region list/"Second"

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "Second" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [Second]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<List<String>,String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "Second" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [Second]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<List<String>,String>+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection contains [Second]"
                    }
                });

            #endregion

            #region dict/["First", false]

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", new KeyValuePair<String, Boolean>("First", false) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [[First, False]]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", new KeyValuePair<String, Boolean>("First", false) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [[First, False]]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection contains [[First, False]]"
                    }
                });

            #endregion

            #region cmpArr/cmp

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [Fake(10)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<EquatableFakeType[],EquatableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [Fake(10)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<EquatableFakeType[],EquatableFakeType>+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection contains [Fake(10)]"
                    }
                });

            #endregion

            #region ft/200/intComparer

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 200 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [200]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<FakeType,Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 200 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [200]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<FakeType,Int32>+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection contains [200]"
                    }
                });

            #endregion

            #region ftArr/ft

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [Fake(1)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<FakeType[],FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [Fake(1)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<FakeType[],FakeType>+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection contains [Fake(1)]"
                    }
                });

            #endregion

            #region ftArr/empty/comparer

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [Fake(1)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<FakeType[],FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [Fake(1)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<FakeType[],FakeType>+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection contains [Fake(1)]"
                    }
                });

            #endregion

            #region ftArr/(FakeType)null

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<FakeType[],FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<FakeType[],FakeType>+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection contains [null]"
                    }
                });

            #endregion

            #region ftArr2/(FakeTypecmp2)

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<FakeType[], FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [Fake(15)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ContainsSpecification<FakeType[], FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection contains [Fake(15)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<FakeType[],FakeType>+Failed",
                        ShortTrace = "NotContains+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection contains [Fake(15)]"
                    }
                });

            #endregion
        }
    }
}