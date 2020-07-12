using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.GreaterThanSpecificationResults
{
    public class GreaterThanNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public GreaterThanNegationInvalidResults()
        {
            #region 5/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 1 }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "Object is greater than [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 1 }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "Object is greater than [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanSpecification<Int32>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [1]"
                    }
                });

            #endregion

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
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -1 }
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
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -1 }
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
                        FullTrace = "NotGreaterThanSpecification<Int32>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [-1]"
                    }
                });

            #endregion

            #region -1/-9/intComparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -9 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Object is greater than [-9]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -9 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Object is greater than [-9]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanSpecification<Int32>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [-9]"
                    }
                });

            #endregion

            #region 5.75/5.74

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = 5.75,
                            Errors = new List<string>
                            {
                                "Object is greater than [5.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = 5.75,
                            Errors = new List<string>
                            {
                                "Object is greater than [5.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanSpecification<Double>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [5.74]"
                    }
                });

            #endregion

            #region 0.0/-2.5

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -2.5 }
                            },
                            Candidate = 0.0,
                            Errors = new List<string>
                            {
                                "Object is greater than [-2.5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -2.5 }
                            },
                            Candidate = 0.0,
                            Errors = new List<string>
                            {
                                "Object is greater than [-2.5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanSpecification<Double>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [-2.5]"
                    }
                });

            #endregion

            #region -5.74/-5.75

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -5.75 }
                            },
                            Candidate = -5.74,
                            Errors = new List<string>
                            {
                                "Object is greater than [-5.75]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -5.75 }
                            },
                            Candidate = -5.74,
                            Errors = new List<string>
                            {
                                "Object is greater than [-5.75]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanSpecification<Double>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [-5.75]"
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
                            SpecificationType = typeof(GreaterThanSpecification<Boolean>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", false }
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
                            SpecificationType = typeof(GreaterThanSpecification<Boolean>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", false }
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
                        FullTrace = "NotGreaterThanSpecification<Boolean>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [False]"
                    }
                });

            #endregion

            #region "124"/"123"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "124",
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
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "124",
                            Errors = new List<string>
                            {
                                "Object is greater than [123]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanSpecification<String>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [123]"
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
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
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
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
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
                        FullTrace = "NotGreaterThanSpecification<String>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
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
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                        FullTrace = "NotGreaterThanSpecification<String>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [null]"
                    }
                });

            #endregion

            #region 2019-07-11/2018-01-15

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2018-01-15") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is greater than [01/15/2018 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2018-01-15") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is greater than [01/15/2018 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanSpecification<DateTime>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [01/15/2018 00:00:00]"
                    }
                });

            #endregion

            #region 2019-07-11/2019-07-01

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-07-01") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is greater than [07/01/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-07-01") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is greater than [07/01/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanSpecification<DateTime>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [07/01/2019 00:00:00]"
                    }
                });

            #endregion

            #region cmp/cmp2

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than [Fake(116)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than [Fake(116)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [Fake(116)]"
                    }
                });

            #endregion

            #region cmpInter1/cmpInter3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<ComparableInterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<ComparableInterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanSpecification<ComparableInterFakeType>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                    }
                });

            #endregion

            #region cmpFakeType/cmpFakeType2/comparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than [Fake(116)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than [Fake(116)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanSpecification<FakeType>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than [Fake(116)]"
                    }
                });

            #endregion

            #region 0/(int?)null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Nullable<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                            SpecificationType = typeof(GreaterThanSpecification<Nullable<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                        FullTrace = "NotGreaterThanSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "NotGreaterThan+Failed"
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