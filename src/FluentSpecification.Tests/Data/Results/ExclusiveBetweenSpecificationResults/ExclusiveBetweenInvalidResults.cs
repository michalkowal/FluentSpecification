using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.ExclusiveBetweenSpecificationResults
{
    public class ExclusiveBetweenInvalidResults : List<ExpectedSpecificationResult>
    {
        public ExclusiveBetweenInvalidResults()
        {
            #region 2/2/3

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 2 },
                                { "To", 3 }
                            },
                            Candidate = 2,
                            Errors = new List<string>
                            {
                                "Value is not between [2] and [3]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 2 },
                                { "To", 3 }
                            },
                            Candidate = 2,
                            Errors = new List<string>
                            {
                                "Value is not between [2] and [3]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Int32>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [2] and [3]"
                    }
                });

            #endregion

            #region -2/-3/-2

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -3 },
                                { "To", -2 }
                            },
                            Candidate = -2,
                            Errors = new List<string>
                            {
                                "Value is not between [-3] and [-2]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -3 },
                                { "To", -2 }
                            },
                            Candidate = -2,
                            Errors = new List<string>
                            {
                                "Value is not between [-3] and [-2]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Int32>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [-3] and [-2]"
                    }
                });

            #endregion

            #region 1/-3/-1

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -3 },
                                { "To", -1 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Value is not between [-3] and [-1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -3 },
                                { "To", -1 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Value is not between [-3] and [-1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Int32>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [-3] and [-1]"
                    }
                });

            #endregion

            #region 5/1/3

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 1 },
                                { "To", 3 }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "Value is not between [1] and [3]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 1 },
                                { "To", 3 }
                            },
                            Candidate = 5,
                            Errors = new List<string>
                            {
                                "Value is not between [1] and [3]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Int32>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [1] and [3]"
                    }
                });

            #endregion

            #region -1/-10/-5/intComparer

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -10 },
                                { "To", -5 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Value is not between [-10] and [-5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -10 },
                                { "To", -5 }
                            },
                            Candidate = -1,
                            Errors = new List<string>
                            {
                                "Value is not between [-10] and [-5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Int32>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [-10] and [-5]"
                    }
                });

            #endregion

            #region 3.5/3.5/3.5

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 3.5 },
                                { "To", 3.5 }
                            },
                            Candidate = 3.5,
                            Errors = new List<string>
                            {
                                "Value is not between [3.5] and [3.5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 3.5 },
                                { "To", 3.5 }
                            },
                            Candidate = 3.5,
                            Errors = new List<string>
                            {
                                "Value is not between [3.5] and [3.5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Double>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [3.5] and [3.5]"
                    }
                });

            #endregion

            #region -3.5/-3.5/-3.5

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -3.5 },
                                { "To", -3.5 }
                            },
                            Candidate = -3.5,
                            Errors = new List<string>
                            {
                                "Value is not between [-3.5] and [-3.5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -3.5 },
                                { "To", -3.5 }
                            },
                            Candidate = -3.5,
                            Errors = new List<string>
                            {
                                "Value is not between [-3.5] and [-3.5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Double>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [-3.5] and [-3.5]"
                    }
                });

            #endregion

            #region 5.74/2.74/3.74

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 2.74 },
                                { "To", 3.74 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Value is not between [2.74] and [3.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 2.74 },
                                { "To", 3.74 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Value is not between [2.74] and [3.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Double>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [2.74] and [3.74]"
                    }
                });

            #endregion

            #region -3.74/-7.74/-5.74

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -7.74 },
                                { "To", -5.74 }
                            },
                            Candidate = -3.74,
                            Errors = new List<string>
                            {
                                "Value is not between [-7.74] and [-5.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -7.74 },
                                { "To", -5.74 }
                            },
                            Candidate = -3.74,
                            Errors = new List<string>
                            {
                                "Value is not between [-7.74] and [-5.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Double>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [-7.74] and [-5.74]"
                    }
                });

            #endregion

            #region 5.74/-3.74/5.73

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -3.74 },
                                { "To", 5.73 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Value is not between [-3.74] and [5.73]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", -3.74 },
                                { "To", 5.73 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Value is not between [-3.74] and [5.73]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Double>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [-3.74] and [5.73]"
                    }
                });

            #endregion

            #region False/False/True

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", false },
                                { "To", true }
                            },
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Value is not between [False] and [True]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", false },
                                { "To", true }
                            },
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Value is not between [False] and [True]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Boolean>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [False] and [True]"
                    }
                });

            #endregion

            #region "123"/"121"/"122"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", "121" },
                                { "To", "122" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Value is not between [121] and [122]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", "121" },
                                { "To", "122" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Value is not between [121] and [122]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<String>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [121] and [122]"
                    }
                });

            #endregion

            #region "1234"/"122"/"1233"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", "122" },
                                { "To", "1233" }
                            },
                            Candidate = "1234",
                            Errors = new List<string>
                            {
                                "Value is not between [122] and [1233]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", "122" },
                                { "To", "1233" }
                            },
                            Candidate = "1234",
                            Errors = new List<string>
                            {
                                "Value is not between [122] and [1233]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<String>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [122] and [1233]"
                    }
                });

            #endregion

            #region "123"/"123"/"124"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", "123" },
                                { "To", "124" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Value is not between [123] and [124]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", "123" },
                                { "To", "124" }
                            },
                            Candidate = "123",
                            Errors = new List<string>
                            {
                                "Value is not between [123] and [124]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<String>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [123] and [124]"
                    }
                });

            #endregion

            #region null/"test"/"test1"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", "test" },
                                { "To", "test1" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [test] and [test1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", "test" },
                                { "To", "test1" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [test] and [test1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<String>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [test] and [test1]"
                    }
                });

            #endregion

            #region null/null/"test"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", "test" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [test]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", "test" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [test]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<String>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [null] and [test]"
                    }
                });

            #endregion

            #region (string)null/null/null

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<String>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [null] and [null]"
                    }
                });

            #endregion

            #region 2019-11-15/2019-07-11/2019-11-15

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", DateTime.Parse("2019-07-11") },
                                { "To", DateTime.Parse("2019-11-15") }
                            },
                            Candidate = DateTime.Parse("2019-11-15"),
                            Errors = new List<string>
                            {
                                "Value is not between [07/11/2019 00:00:00] and [11/15/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", DateTime.Parse("2019-07-11") },
                                { "To", DateTime.Parse("2019-11-15") }
                            },
                            Candidate = DateTime.Parse("2019-11-15"),
                            Errors = new List<string>
                            {
                                "Value is not between [07/11/2019 00:00:00] and [11/15/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<DateTime>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [07/11/2019 00:00:00] and [11/15/2019 00:00:00]"
                    }
                });

            #endregion

            #region 2019-11-15/2019-12-11/2019-12-15

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", DateTime.Parse("2019-12-11") },
                                { "To", DateTime.Parse("2019-12-15") }
                            },
                            Candidate = DateTime.Parse("2019-11-15"),
                            Errors = new List<string>
                            {
                                "Value is not between [12/11/2019 00:00:00] and [12/15/2019 00:00:00]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", DateTime.Parse("2019-12-11") },
                                { "To", DateTime.Parse("2019-12-15") }
                            },
                            Candidate = DateTime.Parse("2019-11-15"),
                            Errors = new List<string>
                            {
                                "Value is not between [12/11/2019 00:00:00] and [12/15/2019 00:00:00]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<DateTime>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [12/11/2019 00:00:00] and [12/15/2019 00:00:00]"
                    }
                });

            #endregion

            #region cmp/notCmp1/notCmp2

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(10)] and [Fake(15)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(10)] and [Fake(15)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [Fake(10)] and [Fake(15)]"
                    }
                });

            #endregion

            #region cmp/notCmp3/notCmp4

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(1)] and [Fake(3)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(1)] and [Fake(3)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [Fake(1)] and [Fake(3)]"
                    }
                });

            #endregion

            #region cmp/notCmp5/notCmp6

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(23)] and [Fake(30)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(23)] and [Fake(30)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [Fake(23)] and [Fake(30)]"
                    }
                });

            #endregion

            #region cmpInter1/cmpInter2/cmpInter3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<ComparableInterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [FluentSpecification.Tests.Mocks.ComparableInterFakeType] and [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<ComparableInterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [FluentSpecification.Tests.Mocks.ComparableInterFakeType] and [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<ComparableInterFakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [FluentSpecification.Tests.Mocks.ComparableInterFakeType] and [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                    }
                });

            #endregion

            #region (ComparableFakeType)null/notCmp1/notCmp2

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(10)] and [Fake(15)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(10)] and [Fake(15)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [Fake(10)] and [Fake(15)]"
                    }
                });

            #endregion

            #region (ComparableFakeType)null/null/notCmp2

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [Fake(15)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [Fake(15)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [null] and [Fake(15)]"
                    }
                });

            #endregion

            #region (ComparableFakeType)null/null/null

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [null] and [null]"
                    }
                });

            #endregion

            #region cmpFakeType/notCmpFakeType1/notCmpFakeType2/comparer

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(10)] and [Fake(15)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(10)] and [Fake(15)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<FakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [Fake(10)] and [Fake(15)]"
                    }
                });

            #endregion

            #region cmpFakeType/notCmpFakeType3/notCmpFakeType4/comparer

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(1)] and [Fake(3)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(1)] and [Fake(3)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<FakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [Fake(1)] and [Fake(3)]"
                    }
                });

            #endregion

            #region cmpFakeType/notCmpFakeType5/notCmpFakeType6/comparer

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(23)] and [Fake(30)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(23)] and [Fake(30)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<FakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [Fake(23)] and [Fake(30)]"
                    }
                });

            #endregion

            #region (FakeType)null/notCmpFakeType1/notCmpFakeType2/comparer

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(10)] and [Fake(15)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [Fake(10)] and [Fake(15)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<FakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [Fake(10)] and [Fake(15)]"
                    }
                });

            #endregion

            #region (FakeType)null/null/notCmpFakeType2/comparer

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [Fake(15)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [Fake(15)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<FakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [null] and [Fake(15)]"
                    }
                });

            #endregion

            #region (FakeType)null/null/null/comparer

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<FakeType>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [null] and [null]"
                    }
                });

            #endregion

            #region (int?)null/0/1

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 0 },
                                { "To", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [0] and [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", 0 },
                                { "To", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [0] and [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [0] and [1]"
                    }
                });

            #endregion

            #region (int?)null/(int?)null/1

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [null] and [1]"
                    }
                });

            #endregion

            #region (int?)null/(int?)null/(int?)null

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(ExclusiveBetweenSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "From", null },
                                { "To", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not between [null] and [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ExclusiveBetweenSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "ExclusiveBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not between [null] and [null]"
                    }
                });

            #endregion
        }
    }
}