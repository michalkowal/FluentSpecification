using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.ExclusiveBetweenSpecificationResults
{
    public class ExclusiveBetweenNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public ExclusiveBetweenNegationInvalidResults()
        {
            #region 1/0/5

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 0 },
                                { "To", 5 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Value is between [0] and [5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 0 },
                                { "To", 5 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Value is between [0] and [5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<Int32>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [0] and [5]"
                    }
                });

            #endregion

            #region -1/-5/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -5 },
                                { "To", 1 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Value is between [-5] and [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -5 },
                                { "To", 1 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Value is between [-5] and [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<Int32>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [-5] and [1]"
                    }
                });

            #endregion

            #region -9/-24/-1/intComparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -24 },
                                { "To", -1 }
                            },
                            Candidate = -9,
                            Errors = new List<string>
                            {
                                "Value is between [-24] and [-1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -24 },
                                { "To", -1 }
                            },
                            Candidate = -9,
                            Errors = new List<string>
                            {
                                "Value is between [-24] and [-1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<Int32>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [-24] and [-1]"
                    }
                });

            #endregion

            #region 5.74/5.73/5.75

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 5.73 },
                                { "To", 5.75 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Value is between [5.73] and [5.75]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 5.73 },
                                { "To", 5.75 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Value is between [5.73] and [5.75]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<Double>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [5.73] and [5.75]"
                    }
                });

            #endregion

            #region -2.5/-3.0/0.0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -3.0 },
                                { "To", 0.0 }
                            },
                            Candidate = -2.5,
                            Errors = new List<string>
                            {
                                "Value is between [-3] and [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -3.0 },
                                { "To", 0.0 }
                            },
                            Candidate = -2.5,
                            Errors = new List<string>
                            {
                                "Value is between [-3] and [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<Double>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [-3] and [0]"
                    }
                });

            #endregion

            #region -5.75/-5.76/-5.74

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -5.76 },
                                { "To", -5.74 }
                            },
                            Candidate = -5.75,
                            Errors = new List<string>
                            {
                                "Value is between [-5.76] and [-5.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -5.76 },
                                { "To", -5.74 }
                            },
                            Candidate = -5.75,
                            Errors = new List<string>
                            {
                                "Value is between [-5.76] and [-5.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<Double>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [-5.76] and [-5.74]"
                    }
                });

            #endregion

            #region "123"/"122"/"124"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", "122" },
                                { "To", "124" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Value is between [122] and [124]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", "122" },
                                { "To", "124" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Value is between [122] and [124]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<String>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [122] and [124]"
                    }
                });

            #endregion

            #region "123"/"12"/"1234"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", "12" },
                                { "To", "1234" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Value is between [12] and [1234]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", "12" },
                                { "To", "1234" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Value is between [12] and [1234]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<String>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [12] and [1234]"
                    }
                });

            #endregion

            #region "test"/null/"test1"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", "test1" }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Value is between [null] and [test1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", "test1" }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Value is between [null] and [test1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<String>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [null] and [test1]"
                    }
                });

            #endregion

            #region 2018-01-15/2017-05-16/2019-07-11

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", DateTime.Parse("2017-05-16") },
                                { "To", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2018-01-15"),
                            Errors = new List<string>
                            {
                                "Value is between [05/16/2017 00:00:00] and [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", DateTime.Parse("2017-05-16") },
                                { "To", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2018-01-15"),
                            Errors = new List<string>
                            {
                                "Value is between [05/16/2017 00:00:00] and [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<DateTime>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [05/16/2017 00:00:00] and [07/11/2019 00:00:00]"
                    }
                });

            #endregion

            #region 2019-07-05/2019-07-01/2019-07-11

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", DateTime.Parse("2019-07-01") },
                                { "To", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-07-05"),
                            Errors = new List<string>
                            {
                                "Value is between [07/01/2019 00:00:00] and [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", DateTime.Parse("2019-07-01") },
                                { "To", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-07-05"),
                            Errors = new List<string>
                            {
                                "Value is between [07/01/2019 00:00:00] and [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<DateTime>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [07/01/2019 00:00:00] and [07/11/2019 00:00:00]"
                    }
                });

            #endregion

            #region cmp/cmpFrom/cmpTo

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is between [Fake(1)] and [Fake(30)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is between [Fake(1)] and [Fake(30)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [Fake(1)] and [Fake(30)]"
                    }
                });

            #endregion

            #region cmp/null/cmpTo

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is between [null] and [Fake(30)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is between [null] and [Fake(30)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [null] and [Fake(30)]"
                    }
                });

            #endregion

            #region cmpFakeType/cmpFromFakeType/cmpToFakeType/comparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is between [Fake(1)] and [Fake(30)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is between [Fake(1)] and [Fake(30)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<FakeType>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [Fake(1)] and [Fake(30)]"
                    }
                });

            #endregion

            #region cmpFakeType/null/cmpToFakeType/comparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is between [null] and [Fake(30)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is between [null] and [Fake(30)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<FakeType>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [null] and [Fake(30)]"
                    }
                });

            #endregion

            #region 0/(int?)null/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Nullable<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", 1 }
                            },
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Value is between [null] and [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Nullable<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", 1 }
                            },
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Value is between [null] and [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotExclusiveBetweenSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "NotExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is between [null] and [1]"
                    }
                });

            #endregion
        }
    }
}