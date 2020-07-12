using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.MaxLengthSpecificationResults
{
    public class MaxLengthNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public MaxLengthNegationInvalidResults()
        {
            #region ""/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 0 }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object length is lower than [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 0 }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object length is lower than [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMaxLengthSpecification<String>+Failed",
                        ShortTrace = "NotMaxLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [0]"
                    }
                });

            #endregion

            #region "test"/25

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 25 }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object length is lower than [25]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 25 }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object length is lower than [25]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMaxLengthSpecification<String>+Failed",
                        ShortTrace = "NotMaxLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [25]"
                    }
                });

            #endregion

            #region emptyArr/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMaxLengthSpecification<Int32[]>+Failed",
                        ShortTrace = "NotMaxLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [1]"
                    }
                });

            #endregion

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
                            SpecificationType = typeof(MaxLengthSpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 5 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 5 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMaxLengthSpecification<Int32[]>+Failed",
                        ShortTrace = "NotMaxLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [5]"
                    }
                });

            #endregion

            #region list/3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<List<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [3]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<List<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [3]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMaxLengthSpecification<List<Int32>>+Failed",
                        ShortTrace = "NotMaxLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [3]"
                    }
                });

            #endregion

            #region dict/20

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<Dictionary<Int32,Boolean>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 20 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [20]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<Dictionary<Int32,Boolean>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 20 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [20]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMaxLengthSpecification<Dictionary<Int32,Boolean>>+Failed",
                        ShortTrace = "NotMaxLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [20]"
                    }
                });

            #endregion

            #region ft/3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [3]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [3]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMaxLengthSpecification<FakeType>+Failed",
                        ShortTrace = "NotMaxLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [3]"
                    }
                });

            #endregion

            #region ift/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<InterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MaxLengthSpecification<InterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMaxLengthSpecification<InterFakeType>+Failed",
                        ShortTrace = "NotMaxLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [1]"
                    }
                });

            #endregion
        }
    }
}