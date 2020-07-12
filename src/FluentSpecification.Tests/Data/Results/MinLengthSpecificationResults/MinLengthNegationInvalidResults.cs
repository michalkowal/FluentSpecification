using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.MinLengthSpecificationResults
{
    public class MinLengthNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public MinLengthNegationInvalidResults()
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
                            SpecificationType = typeof(MinLengthSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object length is greater than [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object length is greater than [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMinLengthSpecification<String>+Failed",
                        ShortTrace = "NotMinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is greater than [0]"
                    }
                });

            #endregion

            #region "test"/4

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 4 }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object length is greater than [4]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 4 }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object length is greater than [4]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMinLengthSpecification<String>+Failed",
                        ShortTrace = "NotMinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is greater than [4]"
                    }
                });

            #endregion

            #region emptyArr/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is greater than [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is greater than [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMinLengthSpecification<Int32[]>+Failed",
                        ShortTrace = "NotMinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is greater than [0]"
                    }
                });

            #endregion

            #region arr/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is greater than [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is greater than [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMinLengthSpecification<Int32[]>+Failed",
                        ShortTrace = "NotMinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is greater than [1]"
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
                            SpecificationType = typeof(MinLengthSpecification<List<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is greater than [3]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<List<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is greater than [3]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMinLengthSpecification<List<Int32>>+Failed",
                        ShortTrace = "NotMinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is greater than [3]"
                    }
                });

            #endregion

            #region dict/2

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<Dictionary<Int32,Boolean>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 2 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is greater than [2]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<Dictionary<Int32,Boolean>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 2 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is greater than [2]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMinLengthSpecification<Dictionary<Int32,Boolean>>+Failed",
                        ShortTrace = "NotMinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is greater than [2]"
                    }
                });

            #endregion

            #region ft/2

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 2 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is greater than [2]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 2 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is greater than [2]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMinLengthSpecification<FakeType>+Failed",
                        ShortTrace = "NotMinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is greater than [2]"
                    }
                });

            #endregion

            #region ift/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<InterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is greater than [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<InterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is greater than [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotMinLengthSpecification<InterFakeType>+Failed",
                        ShortTrace = "NotMinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is greater than [0]"
                    }
                });

            #endregion
        }
    }
}