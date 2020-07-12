using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.LessThanSpecificationResults
{
    public class LessThanInvalidResults : List<ExpectedSpecificationResult>
    {
        public LessThanInvalidResults()
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
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 2 }
                            },
                            Candidate = 2,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [2]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 2 }
                            },
                            Candidate = 2,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [2]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Int32>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [2]"
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
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -2 }
                            },
                            Candidate = -2,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-2]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -2 }
                            },
                            Candidate = -2,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-2]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Int32>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [-2]"
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
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -1 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -1 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Int32>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [-1]"
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
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 3 }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [3]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 3 }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [3]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Int32>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [3]"
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
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -10 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-10]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -10 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-10]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Int32>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [-10]"
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
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 3.5 }
                            },
                            Candidate = 3.5,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [3.5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 3.5 }
                            },
                            Candidate = 3.5,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [3.5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Double>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [3.5]"
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
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -3.5 }
                            },
                            Candidate = -3.5,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-3.5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -3.5 }
                            },
                            Candidate = -3.5,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-3.5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Double>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [-3.5]"
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
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 3.74 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [3.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", 3.74 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [3.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Double>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [3.74]"
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
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -5.74 }
                            },
                            Candidate = -3.74,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-5.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -5.74 }
                            },
                            Candidate = -3.74,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-5.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Double>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [-5.74]"
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
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -3.74 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-3.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", -3.74 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-3.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Double>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [-3.74]"
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
                            SpecificationType = typeof(LessThanSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", false }
                            },
                            Candidate = true,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [False]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", false }
                            },
                            Candidate = true,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [False]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Boolean>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [False]"
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
                            SpecificationType = typeof(LessThanSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", false }
                            },
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [False]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", false }
                            },
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [False]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Boolean>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [False]"
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
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "122" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [122]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "122" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [122]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<String>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [122]"
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
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "123" }
                            },
                            Candidate = "1234",
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [123]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "123" }
                            },
                            Candidate = "1234",
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [123]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<String>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [123]"
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
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "123" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [123]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", "123" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [123]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<String>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [123]"
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
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = "test1",
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = "test1",
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<String>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [null]"
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
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<String>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [null]"
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
                            SpecificationType = typeof(LessThanSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-11-15"),
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-11-15"),
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<DateTime>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [07/11/2019 00:00:00]"
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
                            SpecificationType = typeof(LessThanSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [07/11/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<DateTime>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [07/11/2019 00:00:00]"
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
                            SpecificationType = typeof(LessThanSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(10)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(10)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [Fake(10)]"
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
                            SpecificationType = typeof(LessThanSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(10)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(10)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [Fake(10)]"
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
                            SpecificationType = typeof(LessThanSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [null]"
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
                            SpecificationType = typeof(LessThanSpecification<ComparableInterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<ComparableInterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<ComparableInterFakeType>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
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
                            SpecificationType = typeof(LessThanSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(10)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(10)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<FakeType>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [Fake(10)]"
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
                            SpecificationType = typeof(LessThanSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(10)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(10)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<FakeType>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [Fake(10)]"
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
                            SpecificationType = typeof(LessThanSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<FakeType>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [null]"
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
                            SpecificationType = typeof(LessThanSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [null]"
                    }
                });

            #endregion

            #region (int?)null/null

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LessThanSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "LessThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LessThanSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "LessThan+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [null]"
                    }
                });

            #endregion
        }
    }
}