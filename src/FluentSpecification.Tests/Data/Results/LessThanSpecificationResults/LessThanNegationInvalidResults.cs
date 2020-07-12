using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.LessThanSpecificationResults
{
    public class LessThanNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public LessThanNegationInvalidResults()
        {
            #region 1/5

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 5 }
                            },
                            Candidate = 1,
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
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 5 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is lower than [5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLessThanSpecification<Int32>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [5]"
                    }
                });

            #endregion

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
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 1 }
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
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 1 }
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
                        FullTrace = "NotLessThanSpecification<Int32>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [1]"
                    }
                });

            #endregion

            #region -9/-1/intComparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -1 }
                            },
                            Candidate = -9,
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
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -1 }
                            },
                            Candidate = -9,
                            Errors = new List<string>
                            {
                                "Object is lower than [-1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLessThanSpecification<Int32>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [-1]"
                    }
                });

            #endregion

            #region 5.74/5.75

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 5.75 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Object is lower than [5.75]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 5.75 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Object is lower than [5.75]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLessThanSpecification<Double>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [5.75]"
                    }
                });

            #endregion

            #region -2.5/0.0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 0.0 }
                            },
                            Candidate = -2.5,
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
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 0.0 }
                            },
                            Candidate = -2.5,
                            Errors = new List<string>
                            {
                                "Object is lower than [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLessThanSpecification<Double>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [0]"
                    }
                });

            #endregion

            #region -5.75/-5.74

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -5.74 }
                            },
                            Candidate = -5.75,
                            Errors = new List<string>
                            {
                                "Object is lower than [-5.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -5.74 }
                            },
                            Candidate = -5.75,
                            Errors = new List<string>
                            {
                                "Object is lower than [-5.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLessThanSpecification<Double>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [-5.74]"
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
                            SpecificationType = typeof(LessThanSpecification<Boolean>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", true }
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
                            SpecificationType = typeof(LessThanSpecification<Boolean>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", true }
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
                        FullTrace = "NotLessThanSpecification<Boolean>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [True]"
                    }
                });

            #endregion

            #region "123"/"124"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "124" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is lower than [124]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "124" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is lower than [124]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLessThanSpecification<String>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [124]"
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
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "1234" }
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
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "1234" }
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
                        FullTrace = "NotLessThanSpecification<String>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [1234]"
                    }
                });

            #endregion

            #region (string)null/"test"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "test" }
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
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "test" }
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
                        FullTrace = "NotLessThanSpecification<String>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [test]"
                    }
                });

            #endregion

            #region 2018-01-15/2019-07-11

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2018-01-15"),
                            Errors = new List<string>
                            {
                                "Object is lower than [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2018-01-15"),
                            Errors = new List<string>
                            {
                                "Object is lower than [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLessThanSpecification<DateTime>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [07/11/2019 00:00:00]"
                    }
                });

            #endregion

            #region 2019-07-01/2019-07-11

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-07-01"),
                            Errors = new List<string>
                            {
                                "Object is lower than [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-07-01"),
                            Errors = new List<string>
                            {
                                "Object is lower than [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLessThanSpecification<DateTime>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [07/11/2019 00:00:00]"
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
                            SpecificationType = typeof(LessThanSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [Fake(154)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [Fake(154)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLessThanSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [Fake(154)]"
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
                            SpecificationType = typeof(LessThanSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
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
                            SpecificationType = typeof(LessThanSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
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
                        FullTrace = "NotLessThanSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [Fake(0)]"
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
                            SpecificationType = typeof(LessThanSpecification<ComparableInterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<ComparableInterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLessThanSpecification<ComparableInterFakeType>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
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
                            SpecificationType = typeof(LessThanSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [Fake(154)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than [Fake(154)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLessThanSpecification<FakeType>+Failed",
                        ShortTrace = "NotLessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than [Fake(154)]"
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
                            SpecificationType = typeof(LessThanSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
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
                            SpecificationType = typeof(LessThanSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
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
                        FullTrace = "NotLessThanSpecification<FakeType>+Failed",
                        ShortTrace = "NotLessThan+Failed"
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
                            SpecificationType = typeof(LessThanSpecification<Nullable<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 0 }
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
                            SpecificationType = typeof(LessThanSpecification<Nullable<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 0 }
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
                        FullTrace = "NotLessThanSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "NotLessThan+Failed"
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