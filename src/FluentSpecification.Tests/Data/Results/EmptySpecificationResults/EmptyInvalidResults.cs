using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.EmptySpecificationResults
{
    public class EmptyInvalidResults : List<ExpectedSpecificationResult>
    {
        public EmptyInvalidResults()
        {
            #region obj

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Object>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Object>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<Object>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region " "

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = " ",
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = " ",
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<String>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region "	"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "	",
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "	",
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<String>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region "\n"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "\n",
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "\n",
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<String>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region "\r"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "\r",
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "\r",
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<String>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region "test"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<String>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region 1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<Int32>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region 0,1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 0.1,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 0.1,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<Double>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region True

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = true,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = true,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<Boolean>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region arr

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<Int32[]>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region list

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<List<String>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<List<String>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<List<String>>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region dict

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Dictionary<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Dictionary<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<Dictionary<String,Boolean>>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region fake

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<FakeType>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion

            #region (int?)0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<int?>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<int?>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Object is not empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmptySpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "Empty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not empty"
                    }
                });

            #endregion
        }
    }
}