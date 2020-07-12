using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.GreaterThanOrEqualSpecificationResults
{
    public class GreaterThanOrEqualNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public GreaterThanOrEqualNegationInvalidResults()
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 2 }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 2 }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<Int32>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -2 }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -2 }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<Int32>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [-2]"
                    }
                });

            #endregion

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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 1 }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 1 }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanOrEqualSpecification<Int32>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [1]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -1 }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -1 }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<Int32>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [-1]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -9 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-9]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -9 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-9]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanOrEqualSpecification<Int32>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [-9]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 3.5 }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 3.5 }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<Double>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -3.5 }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -3.5 }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<Double>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [-3.5]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = 5.75,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [5.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = 5.75,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [5.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanOrEqualSpecification<Double>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [5.74]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -2.5 }
                            },
                            Candidate = 0.0,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-2.5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -2.5 }
                            },
                            Candidate = 0.0,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-2.5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanOrEqualSpecification<Double>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [-2.5]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -5.75 }
                            },
                            Candidate = -5.74,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-5.75]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -5.75 }
                            },
                            Candidate = -5.74,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [-5.75]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanOrEqualSpecification<Double>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [-5.75]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Boolean>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", false }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Boolean>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", false }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<Boolean>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [False]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Boolean>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", false }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Boolean>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", false }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<Boolean>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [False]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "124",
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "124",
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [123]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanOrEqualSpecification<String>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [123]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<String>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<String>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<String>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<String>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [null]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2018-01-15") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [01/15/2018 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2018-01-15") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [01/15/2018 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanOrEqualSpecification<DateTime>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [01/15/2018 00:00:00]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-07-01") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [07/01/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-07-01") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [07/01/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanOrEqualSpecification<DateTime>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [07/01/2019 00:00:00]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-07-11") }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<DateTime>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-07-11") }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<DateTime>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [07/11/2019 00:00:00]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(116)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(116)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanOrEqualSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [Fake(116)]"
                    }
                });

            #endregion

            #region cmp3/cmp4

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(11)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(11)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanOrEqualSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [Fake(11)]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [null]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableInterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableInterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<ComparableInterFakeType>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableInterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableInterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<ComparableInterFakeType>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(116)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(116)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanOrEqualSpecification<FakeType>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [Fake(116)]"
                    }
                });

            #endregion

            #region cmpFakeType3/cmpFakeType4/comparer

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(11)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is greater than or equal to [Fake(11)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotGreaterThanOrEqualSpecification<FakeType>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is greater than or equal to [Fake(11)]"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<FakeType>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Nullable<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Nullable<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Nullable<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Nullable<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
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
                        FullTrace = "NotGreaterThanOrEqualSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "NotGreaterThanOrEqual+Failed"
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