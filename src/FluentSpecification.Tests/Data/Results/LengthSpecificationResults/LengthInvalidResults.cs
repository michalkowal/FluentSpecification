using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.LengthSpecificationResults
{
    public class LengthInvalidResults : List<ExpectedSpecificationResult>
    {
        public LengthInvalidResults()
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
                            SpecificationType = typeof(LengthSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 1 }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object length is not [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 1 }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object length is not [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<String>+Failed",
                        ShortTrace = "Length+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not [1]"
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
                            SpecificationType = typeof(LengthSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 10 }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object length is not [10]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 10 }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object length is not [10]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<String>+Failed",
                        ShortTrace = "Length+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not [10]"
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
                            SpecificationType = typeof(LengthSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<Int32[]>+Failed",
                        ShortTrace = "Length+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not [1]"
                    }
                });

            #endregion

            #region arr/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<Int32[]>+Failed",
                        ShortTrace = "Length+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not [0]"
                    }
                });

            #endregion

            #region list/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<List<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<List<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<List<Int32>>+Failed",
                        ShortTrace = "Length+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not [0]"
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
                            SpecificationType = typeof(LengthSpecification<Dictionary<Int32,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 5 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<Dictionary<Int32,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 5 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<Dictionary<Int32,Boolean>>+Failed",
                        ShortTrace = "Length+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not [5]"
                    }
                });

            #endregion

            #region ft/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<FakeType>+Failed",
                        ShortTrace = "Length+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not [1]"
                    }
                });

            #endregion

            #region ift/3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<InterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [3]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<InterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [3]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<InterFakeType>+Failed",
                        ShortTrace = "Length+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not [3]"
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
                            SpecificationType = typeof(LengthSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<String>+Failed",
                        ShortTrace = "Length+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not [1]"
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
                            SpecificationType = typeof(LengthSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<FakeType>+Failed",
                        ShortTrace = "Length+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not [0]"
                    }
                });

            #endregion
        }
    }
}