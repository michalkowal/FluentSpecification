using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.GreaterThanOrEqualSpecificationResults
{
    public class GreaterThanOrEqualInvalidResults : List<ExpectedSpecificationResult>
    {
        public GreaterThanOrEqualInvalidResults()
        {
            #region -1/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 1 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Object is lower than [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 1 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Object is lower than [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Int32>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [1]"
                    }
                });

            #endregion

            #region 3/5

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5 }
                            },
                            Candidate = 3,
                            Errors = new List<string>
                            {
                                "Object is lower than [5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5 }
                            },
                            Candidate = 3,
                            Errors = new List<string>
                            {
                                "Object is lower than [5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Int32>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [5]"
                    }
                });

            #endregion

            #region -10/-1/intComparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -1 }
                            },
                            Candidate = -10,
                            Errors = new List<string>
                            {
                                "Object is lower than [-1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -1 }
                            },
                            Candidate = -10,
                            Errors = new List<string>
                            {
                                "Object is lower than [-1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Int32>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [-1]"
                    }
                });

            #endregion

            #region 3.74/5.74

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = 3.74,
                            Errors = new List<string>
                            {
                                "Object is lower than [5.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = 3.74,
                            Errors = new List<string>
                            {
                                "Object is lower than [5.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Double>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [5.74]"
                    }
                });

            #endregion

            #region -5.74/-3.74

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -3.74 }
                            },
                            Candidate = -5.74,
                            Errors = new List<string>
                            {
                                "Object is lower than [-3.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -3.74 }
                            },
                            Candidate = -5.74,
                            Errors = new List<string>
                            {
                                "Object is lower than [-3.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Double>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [-3.74]"
                    }
                });

            #endregion

            #region -3.74/5.74

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = -3.74,
                            Errors = new List<string>
                            {
                                "Object is lower than [5.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = -3.74,
                            Errors = new List<string>
                            {
                                "Object is lower than [5.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Double>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [5.74]"
                    }
                });

            #endregion

            #region False/True

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", true }
                            },
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Object is lower than [True]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", true }
                            },
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Object is lower than [True]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Boolean>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [True]"
                    }
                });

            #endregion

            #region "122"/"123"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "122",
                            Errors = new List<string>
                            {
                                "Object is lower than [123]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "122",
                            Errors = new List<string>
                            {
                                "Object is lower than [123]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<String>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [123]"
                    }
                });

            #endregion

            #region "123"/"1234"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "1234" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is lower than [1234]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "1234" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is lower than [1234]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<String>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [1234]"
                    }
                });

            #endregion

            #region 2019-07-11/2019-11-15

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-11-15") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is lower than [11/15/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-11-15") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is lower than [11/15/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<DateTime>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [11/15/2019 00:00:00]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [Fake(11)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [Fake(11)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [Fake(11)]"
                    }
                });

            #endregion

            #region (string)null/test

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "test" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [test]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "test" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [test]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<String>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [test]"
                    }
                });

            #endregion

            #region (ComparableFakeType)null/new ComparableFakeType()

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [Fake(0)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [Fake(0)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [Fake(0)]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [Fake(11)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [Fake(11)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<FakeType>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [Fake(11)]"
                    }
                });

            #endregion

            #region (FakeType)null/new FakeType()/comparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [Fake(0)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [Fake(0)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<FakeType>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [Fake(0)]"
                    }
                });

            #endregion

            #region (int?)null/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "GreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [0]"
                    }
                });

            #endregion
        }
    }
}