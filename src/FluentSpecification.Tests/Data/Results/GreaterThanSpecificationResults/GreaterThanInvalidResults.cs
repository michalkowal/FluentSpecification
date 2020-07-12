using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.GreaterThanSpecificationResults
{
    public class GreaterThanInvalidResults : List<ExpectedSpecificationResult>
    {
        public GreaterThanInvalidResults()
        {
            #region 2/2

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 2 }
                            },
                            Candidate = 2,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [2]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 2 }
                            },
                            Candidate = 2,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [2]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Int32>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [2]"
                    }
                });

            #endregion

            #region -2/-2

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -2 }
                            },
                            Candidate = -2,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [-2]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -2 }
                            },
                            Candidate = -2,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [-2]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Int32>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [-2]"
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
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 1 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 1 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Int32>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [1]"
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
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5 }
                            },
                            Candidate = 3,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5 }
                            },
                            Candidate = 3,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Int32>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [5]"
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
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -1 }
                            },
                            Candidate = -10,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [-1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -1 }
                            },
                            Candidate = -10,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [-1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Int32>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [-1]"
                    }
                });

            #endregion

            #region 3.5/3.5

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 3.5 }
                            },
                            Candidate = 3.5,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [3.5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 3.5 }
                            },
                            Candidate = 3.5,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [3.5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Double>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [3.5]"
                    }
                });

            #endregion

            #region -3.5/-3.5

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -3.5 }
                            },
                            Candidate = -3.5,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [-3.5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -3.5 }
                            },
                            Candidate = -3.5,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [-3.5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Double>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [-3.5]"
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
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = 3.74,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [5.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = 3.74,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [5.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Double>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [5.74]"
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
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -3.74 }
                            },
                            Candidate = -5.74,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [-3.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -3.74 }
                            },
                            Candidate = -5.74,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [-3.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Double>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [-3.74]"
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
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = -3.74,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [5.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = -3.74,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [5.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Double>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [5.74]"
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
                            SpecificationType = typeof(GreaterThanSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", true }
                            },
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [True]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", true }
                            },
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [True]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Boolean>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [True]"
                    }
                });

            #endregion

            #region False/False

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", false }
                            },
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [False]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", false }
                            },
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [False]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Boolean>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [False]"
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
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "122",
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [123]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "122",
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [123]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<String>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [123]"
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
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "1234" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [1234]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "1234" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [1234]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<String>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [1234]"
                    }
                });

            #endregion

            #region "123"/"123"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [123]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [123]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<String>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [123]"
                    }
                });

            #endregion

            #region (string)null/null

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<String>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [null]"
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
                            SpecificationType = typeof(GreaterThanSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-11-15") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [11/15/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-11-15") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [11/15/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<DateTime>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [11/15/2019 00:00:00]"
                    }
                });

            #endregion

            #region 2019-07-11/2019-07-11

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<DateTime>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [07/11/2019 00:00:00]"
                    }
                });

            #endregion

            #region notCmp1/notCmp2

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [Fake(10)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [Fake(10)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [Fake(10)]"
                    }
                });

            #endregion

            #region notCmp2/notCmp3

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [Fake(11)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [Fake(11)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [Fake(11)]"
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
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "test" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [test]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "test" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [test]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<String>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [test]"
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
                            SpecificationType = typeof(GreaterThanSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [Fake(0)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [Fake(0)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [Fake(0)]"
                    }
                });

            #endregion

            #region (ComparableFakeType)null/null

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [null]"
                    }
                });

            #endregion

            #region cmpInter1/cmpInter2

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<ComparableInterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<ComparableInterFakeType>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                    }
                });

            #endregion

            #region notCmpFakeType1/notCmpFakeType2/comparer

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [Fake(10)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [Fake(10)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<FakeType>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [Fake(10)]"
                    }
                });

            #endregion

            #region notCmpFakeType2/notCmpFakeType3/comparer

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [Fake(11)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [Fake(11)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<FakeType>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [Fake(11)]"
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
                            SpecificationType = typeof(GreaterThanSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [Fake(0)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [Fake(0)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<FakeType>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [Fake(0)]"
                    }
                });

            #endregion

            #region (FakeType)null/null/comparer

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<FakeType>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [null]"
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
                            SpecificationType = typeof(GreaterThanSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [0]"
                    }
                });

            #endregion

            #region (int?)null/(int?)null

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is lower than or equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "GreaterThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is lower than or equal to [null]"
                    }
                });

            #endregion
        }
    }
}