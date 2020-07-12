using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.AnySpecificationResults
{
    public class AnyValidResults : List<ExpectedSpecificationResult>
    {
        public AnyValidResults()
        {
            #region arr/True<int>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 2,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AnySpecification<Int32[],Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
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
                            Candidate = 1,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<Int32[],Int32>([0](MockComplexSpecification[Int32]))",
                        ShortTrace = "Any([0](MockComplex))"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region list/True<string>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 2,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AnySpecification<List<String>,String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
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
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<List<String>,String>([0](MockComplexSpecification[String]))",
                        ShortTrace = "Any([0](MockComplex))"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region dict/True<KeyValuePair<string, bool>>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 2,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AnySpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
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
                            Candidate = new KeyValuePair<String,Boolean>("First", false),
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>([0](MockComplexSpecification[KeyValuePair<String,Boolean>]))",
                        ShortTrace = "Any([0](MockComplex))"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ft/True<int>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 2,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AnySpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
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
                            Candidate = 1,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<FakeType,Int32>([0](MockComplexSpecification[Int32]))",
                        ShortTrace = "Any([0](MockComplex))"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region arr/FewInt

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 4,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AnySpecification<Int32[],Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
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
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 200,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
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
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<Int32[],Int32>([0](FailedMockComplexSpecification[Int32]) Or [1](FailedMockComplexSpecification[Int32]) Or [2](MockComplexSpecification[Int32]))",
                        ShortTrace = "Any([0](FailedMockComplex) Or [1](FailedMockComplex) Or [2](MockComplex))"
                    },
                    FailedSpecificationsCount = 2,
                    Errors = new List<string>
                    {
                        "[0] MockComplexSpecification is not satisfied",
                        "[1] MockComplexSpecification is not satisfied"
                    }
                });

            #endregion

            #region list/FewString

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 2,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AnySpecification<List<String>,String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
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
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<List<String>,String>([0](MockComplexSpecification[String]))",
                        ShortTrace = "Any([0](MockComplex))"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region dict/FewPair

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 3,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AnySpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
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
                            Candidate = new KeyValuePair<String, Boolean>("First", false),
                            Errors = new List<string>
                            {
                                "[0] MockComplexSpecification is not satisfied"
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
                            Candidate = new KeyValuePair<String, Boolean>("Second", true),
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
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
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>([0](FailedMockComplexSpecification[KeyValuePair<String,Boolean>]) Or [1](MockComplexSpecification[KeyValuePair<String,Boolean>]))",
                        ShortTrace = "Any([0](FailedMockComplex) Or [1](MockComplex))"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "[0] MockComplexSpecification is not satisfied"
                    }
                });

            #endregion

            #region ft/FewInt

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 4,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AnySpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAny", null }
                            },
                            Candidate = null,
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
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 200,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
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
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AnySpecification<FakeType,Int32>([0](FailedMockComplexSpecification[Int32]) Or [1](FailedMockComplexSpecification[Int32]) Or [2](MockComplexSpecification[Int32]))",
                        ShortTrace = "Any([0](FailedMockComplex) Or [1](FailedMockComplex) Or [2](MockComplex))"
                    },
                    FailedSpecificationsCount = 2,
                    Errors = new List<string>
                    {
                        "[0] MockComplexSpecification is not satisfied",
                        "[1] MockComplexSpecification is not satisfied"
                    }
                });

            #endregion
        }
    }
}