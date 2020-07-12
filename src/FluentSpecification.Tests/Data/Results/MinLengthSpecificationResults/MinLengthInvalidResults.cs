using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.MinLengthSpecificationResults
{
    public class MinLengthInvalidResults : List<ExpectedSpecificationResult>
    {
        public MinLengthInvalidResults()
        {
            #region ""/1

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 }
                            },
                            Candidate = "",
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
                            SpecificationType = typeof(MinLengthSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object length is lower than [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "MinLengthSpecification<String>+Failed",
                        ShortTrace = "MinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [1]"
                    }
                });

            #endregion

            #region "test"/10

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 10 }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object length is lower than [10]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 10 }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object length is lower than [10]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "MinLengthSpecification<String>+Failed",
                        ShortTrace = "MinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [10]"
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
                            SpecificationType = typeof(MinLengthSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 }
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
                            SpecificationType = typeof(MinLengthSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 }
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
                        FullTrace = "MinLengthSpecification<Int32[]>+Failed",
                        ShortTrace = "MinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [1]"
                    }
                });

            #endregion

            #region arr/20

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 20 }
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
                            SpecificationType = typeof(MinLengthSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 20 }
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
                        FullTrace = "MinLengthSpecification<Int32[]>+Failed",
                        ShortTrace = "MinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [20]"
                    }
                });

            #endregion

            #region list/4

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 4 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [4]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<List<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 4 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [4]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "MinLengthSpecification<List<Int32>>+Failed",
                        ShortTrace = "MinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [4]"
                    }
                });

            #endregion

            #region dict/5

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 5 }
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
                            SpecificationType = typeof(MinLengthSpecification<Dictionary<Int32,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 5 }
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
                        FullTrace = "MinLengthSpecification<Dictionary<Int32,Boolean>>+Failed",
                        ShortTrace = "MinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [5]"
                    }
                });

            #endregion

            #region ft/5

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 5 }
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
                            SpecificationType = typeof(MinLengthSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 5 }
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
                        FullTrace = "MinLengthSpecification<FakeType>+Failed",
                        ShortTrace = "MinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [5]"
                    }
                });

            #endregion

            #region ift/2

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 2 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [2]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(MinLengthSpecification<InterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 2 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [2]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "MinLengthSpecification<InterFakeType>+Failed",
                        ShortTrace = "MinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [2]"
                    }
                });

            #endregion

            #region (string)null/1

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 }
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
                            SpecificationType = typeof(MinLengthSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 }
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
                        FullTrace = "MinLengthSpecification<String>+Failed",
                        ShortTrace = "MinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [1]"
                    }
                });

            #endregion

            #region (FakeType)null/0

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 }
                            },
                            Candidate = null,
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
                            SpecificationType = typeof(MinLengthSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is lower than [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "MinLengthSpecification<FakeType>+Failed",
                        ShortTrace = "MinLength+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is lower than [0]"
                    }
                });

            #endregion
        }
    }
}