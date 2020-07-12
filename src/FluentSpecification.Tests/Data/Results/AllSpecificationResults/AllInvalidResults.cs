using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.AllSpecificationResults
{
    public class AllInvalidResults : List<ExpectedSpecificationResult>
    {
        public AllInvalidResults()
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
                            SpecificationType = typeof(AllSpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
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
                            SpecificationType = typeof(AllSpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
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
                        FullTrace = "AllSpecification<FakeType,Int32>()+Failed",
                        ShortTrace = "All()+Failed"
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
                            SpecificationType = typeof(AllSpecification<Int32[],Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
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
                            SpecificationType = typeof(AllSpecification<Int32[],Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
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
                        FullTrace = "AllSpecification<Int32[],Int32>([0](FailedMockComplexSpecification[Int32]) And [1](FailedMockComplexSpecification[Int32]) And [2](FailedMockComplexSpecification[Int32]) And [3](FailedMockComplexSpecification[Int32]) And [4](FailedMockComplexSpecification[Int32]))+Failed",
                        ShortTrace = "All([0](FailedMockComplex) And [1](FailedMockComplex) And [2](FailedMockComplex) And [3](FailedMockComplex) And [4](FailedMockComplex))+Failed"
                    },
                    FailedSpecificationsCount = 6,
                    Errors = new List<string>
                    {
                        "One or more elements are not specified",
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
                            SpecificationType = typeof(AllSpecification<List<String>,String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
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
                            SpecificationType = typeof(AllSpecification<List<String>,String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
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
                        FullTrace = "AllSpecification<List<String>,String>([0](FailedMockComplexSpecification[String]) And [1](FailedMockComplexSpecification[String]))+Failed",
                        ShortTrace = "All([0](FailedMockComplex) And [1](FailedMockComplex))+Failed"
                    },
                    FailedSpecificationsCount = 3,
                    Errors = new List<string>
                    {
                        "One or more elements are not specified",
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
                            SpecificationType = typeof(AllSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
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
                            Candidate = new KeyValuePair<String, Boolean>("First", true),
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
                            Candidate = new KeyValuePair<String, Boolean>("Second", false),
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
                            SpecificationType = typeof(AllSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
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
                            Candidate = new KeyValuePair<String, Boolean>("First", true),
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
                            Candidate = new KeyValuePair<String, Boolean>("Second", false),
                            Errors = new List<string>
                            {
                                "[1] MockComplexSpecification is not satisfied"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AllSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>([0](FailedMockComplexSpecification[KeyValuePair<String,Boolean>]) And [1](FailedMockComplexSpecification[KeyValuePair<String,Boolean>]))+Failed",
                        ShortTrace = "All([0](FailedMockComplex) And [1](FailedMockComplex))+Failed"
                    },
                    FailedSpecificationsCount = 3,
                    Errors = new List<string>
                    {
                        "One or more elements are not specified",
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
                            SpecificationType = typeof(AllSpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
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
                            SpecificationType = typeof(AllSpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
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
                        FullTrace = "AllSpecification<FakeType,Int32>([0](FailedMockComplexSpecification[Int32]) And [1](FailedMockComplexSpecification[Int32]) And [2](FailedMockComplexSpecification[Int32]) And [3](FailedMockComplexSpecification[Int32]) And [4](FailedMockComplexSpecification[Int32]))+Failed",
                        ShortTrace = "All([0](FailedMockComplex) And [1](FailedMockComplex) And [2](FailedMockComplex) And [3](FailedMockComplex) And [4](FailedMockComplex))+Failed"
                    },
                    FailedSpecificationsCount = 6,
                    Errors = new List<string>
                    {
                        "One or more elements are not specified",
                        "[0] MockComplexSpecification is not satisfied",
                        "[1] MockComplexSpecification is not satisfied",
                        "[2] MockComplexSpecification is not satisfied",
                        "[3] MockComplexSpecification is not satisfied",
                        "[4] MockComplexSpecification is not satisfied"
                    }
                });

            #endregion

            #region arr/FewInt

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 6,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AllSpecification<Int32[],Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 1,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 5,
                            Errors = new List<string>()
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
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 6,
                            Errors = new List<string>()
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
                            SpecificationType = typeof(AllSpecification<Int32[],Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
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
                            Candidate = 100,
                            Errors = new List<string>
                            {
                                "[4] MockComplexSpecification is not satisfied"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AllSpecification<Int32[],Int32>([0](MockComplexSpecification[Int32]) And [1](MockComplexSpecification[Int32]) And [2](FailedMockComplexSpecification[Int32]) And [3](MockComplexSpecification[Int32]) And [4](FailedMockComplexSpecification[Int32]))+Failed",
                        ShortTrace = "All([0](MockComplex) And [1](MockComplex) And [2](FailedMockComplex) And [3](MockComplex) And [4](FailedMockComplex))+Failed"
                    },
                    FailedSpecificationsCount = 3,
                    Errors = new List<string>
                    {
                        "One or more elements are not specified",
                        "[2] MockComplexSpecification is not satisfied",
                        "[4] MockComplexSpecification is not satisfied"
                    }
                });

            #endregion

            #region list/FewString

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 3,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AllSpecification<List<String>,String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = "First",
                            Errors = new List<string>()
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
                            SpecificationType = typeof(AllSpecification<List<String>,String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
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
                        FullTrace = "AllSpecification<List<String>,String>([0](MockComplexSpecification[String]) And [1](FailedMockComplexSpecification[String]))+Failed",
                        ShortTrace = "All([0](MockComplex) And [1](FailedMockComplex))+Failed"
                    },
                    FailedSpecificationsCount = 2,
                    Errors = new List<string>
                    {
                        "One or more elements are not specified",
                        "[1] MockComplexSpecification is not satisfied"
                    }
                });

            #endregion

            #region dict/FewPair

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 3,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AllSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = new KeyValuePair<String, Boolean>("First", true),
                            Errors = new List<string>()
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
                            Candidate = new KeyValuePair<String, Boolean>("Second", false),
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
                            SpecificationType = typeof(AllSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
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
                            Candidate = new KeyValuePair<String, Boolean>("Second", false),
                            Errors = new List<string>
                            {
                                "[1] MockComplexSpecification is not satisfied"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AllSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>([0](MockComplexSpecification[KeyValuePair<String,Boolean>]) And [1](FailedMockComplexSpecification[KeyValuePair<String,Boolean>]))+Failed",
                        ShortTrace = "All([0](MockComplex) And [1](FailedMockComplex))+Failed"
                    },
                    FailedSpecificationsCount = 2,
                    Errors = new List<string>
                    {
                        "One or more elements are not specified",
                        "[1] MockComplexSpecification is not satisfied"
                    }
                });

            #endregion

            #region ft/FewInt

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 6,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(AllSpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
                            }
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 1,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 5,
                            Errors = new List<string>()
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
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 6,
                            Errors = new List<string>()
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
                            SpecificationType = typeof(AllSpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "One or more elements are not specified"
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
                            Candidate = 100,
                            Errors = new List<string>
                            {
                                "[4] MockComplexSpecification is not satisfied"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AllSpecification<FakeType,Int32>([0](MockComplexSpecification[Int32]) And [1](MockComplexSpecification[Int32]) And [2](FailedMockComplexSpecification[Int32]) And [3](MockComplexSpecification[Int32]) And [4](FailedMockComplexSpecification[Int32]))+Failed",
                        ShortTrace = "All([0](MockComplex) And [1](MockComplex) And [2](FailedMockComplex) And [3](MockComplex) And [4](FailedMockComplex))+Failed"
                    },
                    FailedSpecificationsCount = 3,
                    Errors = new List<string>
                    {
                        "One or more elements are not specified",
                        "[2] MockComplexSpecification is not satisfied",
                        "[4] MockComplexSpecification is not satisfied"
                    }
                });

            #endregion
        }
    }
}