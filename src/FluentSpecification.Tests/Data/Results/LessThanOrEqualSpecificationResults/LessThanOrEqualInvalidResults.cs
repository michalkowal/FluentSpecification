using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.LessThanOrEqualSpecificationResults
{
    public class LessThanOrEqualInvalidResults : List<ExpectedSpecificationResult>
    {
        public LessThanOrEqualInvalidResults()
        {
            #region 1/-1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -1 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is greater than [-1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -1 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is greater than [-1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<Int32>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [-1]"
                    }
                });

            #endregion

            #region 5/3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 3 }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "Object is greater than [3]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 3 }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "Object is greater than [3]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<Int32>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [3]"
                    }
                });

            #endregion

            #region -1/-10/intComparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -10 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Object is greater than [-10]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -10 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Object is greater than [-10]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<Int32>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [-10]"
                    }
                });

            #endregion

            #region 5.74/3.74

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 3.74 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Object is greater than [3.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 3.74 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Object is greater than [3.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<Double>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [3.74]"
                    }
                });

            #endregion

            #region -3.74/-5.74

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -5.74 }
                            },
                            Candidate = -3.74,
                            Errors = new List<string>
                            {
                                "Object is greater than [-5.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -5.74 }
                            },
                            Candidate = -3.74,
                            Errors = new List<string>
                            {
                                "Object is greater than [-5.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<Double>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [-5.74]"
                    }
                });

            #endregion

            #region 5.74/-3.74

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -3.74 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Object is greater than [-3.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -3.74 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Object is greater than [-3.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<Double>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [-3.74]"
                    }
                });

            #endregion

            #region True/False

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", false }
                            },
                            Candidate = true,
                            Errors = new List<string>
                            {
                                "Object is greater than [False]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", false }
                            },
                            Candidate = true,
                            Errors = new List<string>
                            {
                                "Object is greater than [False]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<Boolean>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [False]"
                    }
                });

            #endregion

            #region "123"/"122"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "122" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is greater than [122]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "122" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is greater than [122]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<String>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [122]"
                    }
                });

            #endregion

            #region "1234"/"123"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "123" }
                            },
                            Candidate = "1234",
                            Errors = new List<string>
                            {
                                "Object is greater than [123]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "123" }
                            },
                            Candidate = "1234",
                            Errors = new List<string>
                            {
                                "Object is greater than [123]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<String>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [123]"
                    }
                });

            #endregion

            #region "test1"/null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = "test1",
                            Errors = new List<string>
                            {
                                "Object is greater than [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = "test1",
                            Errors = new List<string>
                            {
                                "Object is greater than [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<String>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [null]"
                    }
                });

            #endregion

            #region 2019-11-15/2019-07-11

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-11-15"),
                            Errors = new List<string>
                            {
                                "Object is greater than [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-11-15"),
                            Errors = new List<string>
                            {
                                "Object is greater than [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<DateTime>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [07/11/2019 00:00:00]"
                    }
                });

            #endregion

            #region notCmp1/cmp3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than [Fake(10)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than [Fake(10)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [Fake(10)]"
                    }
                });

            #endregion

            #region notCmpFakeType1/cmpFakeType3/comparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than [Fake(10)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than [Fake(10)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<FakeType>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [Fake(10)]"
                    }
                });

            #endregion

            #region (int?)0/null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Object is greater than [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanOrEqualSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Object is greater than [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanOrEqualSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "LessThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [null]"
                    }
                });

            #endregion
        }
    }
}