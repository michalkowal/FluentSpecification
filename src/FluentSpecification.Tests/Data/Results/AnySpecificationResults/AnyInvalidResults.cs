using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.AnySpecificationResults
{
    public class AnyInvalidResults : List<ExpectedSpecificationResult>
    {
        public AnyInvalidResults()
        {
            #region (FakeType)null/True<int>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AnySpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection is null"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AnySpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Collection is null"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<FakeType,Int32>()+Failed",
                        ShortTrace = "Any()+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Collection is null"
                    }
                });

            #endregion

            #region arr/False<int>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 6,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AnySpecification<Int32[],Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "All elements are not specified"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "[0] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "[1] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 200,
                            Errors = new List<string>
                            {
                                "[2] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 6,
                            Errors = new List<string>
                            {
                                "[3] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 100,
                            Errors = new List<string>
                            {
                                "[4] MockComplexSpecification is not satisfied"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AnySpecification<Int32[],Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "All elements are not specified"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "[0] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "[1] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 200,
                            Errors = new List<string>
                            {
                                "[2] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 6,
                            Errors = new List<string>
                            {
                                "[3] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 100,
                            Errors = new List<string>
                            {
                                "[4] MockComplexSpecification is not satisfied"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<Int32[],Int32>([0](FailedMockComplexSpecification[Int32]) Or [1](FailedMockComplexSpecification[Int32]) Or [2](FailedMockComplexSpecification[Int32]) Or [3](FailedMockComplexSpecification[Int32]) Or [4](FailedMockComplexSpecification[Int32]))+Failed",
                        ShortTrace = "Any([0](FailedMockComplex) Or [1](FailedMockComplex) Or [2](FailedMockComplex) Or [3](FailedMockComplex) Or [4](FailedMockComplex))+Failed"
                    },
                    FailedSpecificationsCount = 6,
                    Errors = new List<string>
                    {
                        "All elements are not specified",
                        "[0] MockComplexSpecification is not satisfied",
                        "[1] MockComplexSpecification is not satisfied",
                        "[2] MockComplexSpecification is not satisfied",
                        "[3] MockComplexSpecification is not satisfied",
                        "[4] MockComplexSpecification is not satisfied"
                    }
                });

            #endregion

            #region list/False<string>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 3,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AnySpecification<List<String>,String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "All elements are not specified"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = "First",
                            Errors = new List<string>
                            {
                                "[0] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = "Second",
                            Errors = new List<string>
                            {
                                "[1] MockComplexSpecification is not satisfied"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AnySpecification<List<String>,String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "All elements are not specified"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = "First",
                            Errors = new List<string>
                            {
                                "[0] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = "Second",
                            Errors = new List<string>
                            {
                                "[1] MockComplexSpecification is not satisfied"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<List<String>,String>([0](FailedMockComplexSpecification[String]) Or [1](FailedMockComplexSpecification[String]))+Failed",
                        ShortTrace = "Any([0](FailedMockComplex) Or [1](FailedMockComplex))+Failed"
                    },
                    FailedSpecificationsCount = 3,
                    Errors = new List<string>
                    {
                        "All elements are not specified",
                        "[0] MockComplexSpecification is not satisfied",
                        "[1] MockComplexSpecification is not satisfied"
                    }
                });

            #endregion

            #region dict/False<KeyValuePair<string, bool>>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 3,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AnySpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "All elements are not specified"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = new KeyValuePair<String, Boolean>("First", false),
                            Errors = new List<string>
                            {
                                "[0] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = new KeyValuePair<String, Boolean>("Second", true),
                            Errors = new List<string>
                            {
                                "[1] MockComplexSpecification is not satisfied"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AnySpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "All elements are not specified"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = new KeyValuePair<String, Boolean>("First", false),
                            Errors = new List<string>
                            {
                                "[0] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = new KeyValuePair<String, Boolean>("Second", true),
                            Errors = new List<string>
                            {
                                "[1] MockComplexSpecification is not satisfied"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>([0](FailedMockComplexSpecification[KeyValuePair<String,Boolean>]) Or [1](FailedMockComplexSpecification[KeyValuePair<String,Boolean>]))+Failed",
                        ShortTrace = "Any([0](FailedMockComplex) Or [1](FailedMockComplex))+Failed"
                    },
                    FailedSpecificationsCount = 3,
                    Errors = new List<string>
                    {
                        "All elements are not specified",
                        "[0] MockComplexSpecification is not satisfied",
                        "[1] MockComplexSpecification is not satisfied"
                    }
                });

            #endregion

            #region ft/False<int>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 6,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AnySpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "All elements are not specified"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "[0] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "[1] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 200,
                            Errors = new List<string>
                            {
                                "[2] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 6,
                            Errors = new List<string>
                            {
                                "[3] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 100,
                            Errors = new List<string>
                            {
                                "[4] MockComplexSpecification is not satisfied"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AnySpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "All elements are not specified"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "[0] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "[1] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 200,
                            Errors = new List<string>
                            {
                                "[2] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 6,
                            Errors = new List<string>
                            {
                                "[3] MockComplexSpecification is not satisfied"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 100,
                            Errors = new List<string>
                            {
                                "[4] MockComplexSpecification is not satisfied"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<FakeType,Int32>([0](FailedMockComplexSpecification[Int32]) Or [1](FailedMockComplexSpecification[Int32]) Or [2](FailedMockComplexSpecification[Int32]) Or [3](FailedMockComplexSpecification[Int32]) Or [4](FailedMockComplexSpecification[Int32]))+Failed",
                        ShortTrace = "Any([0](FailedMockComplex) Or [1](FailedMockComplex) Or [2](FailedMockComplex) Or [3](FailedMockComplex) Or [4](FailedMockComplex))+Failed"
                    },
                    FailedSpecificationsCount = 6,
                    Errors = new List<string>
                    {
                        "All elements are not specified",
                        "[0] MockComplexSpecification is not satisfied",
                        "[1] MockComplexSpecification is not satisfied",
                        "[2] MockComplexSpecification is not satisfied",
                        "[3] MockComplexSpecification is not satisfied",
                        "[4] MockComplexSpecification is not satisfied"
                    }
                });

            #endregion

            #region empty/True<int>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AnySpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "All elements are not specified"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AnySpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "All elements are not specified"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<FakeType,Int32>()+Failed",
                        ShortTrace = "Any()+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "All elements are not specified"
                    }
                });

            #endregion
        }
    }
}