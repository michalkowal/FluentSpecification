using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.EmptySpecificationResults
{
    public class EmptyNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public EmptyNegationInvalidResults()
        {
            #region null

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Object>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Object>+Failed",
                        ShortTrace = "NotEmpty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is empty"
                    }
                });

            #endregion

            #region (string)null

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<String>+Failed",
                        ShortTrace = "NotEmpty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is empty"
                    }
                });

            #endregion

            #region (FakeType)null

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<FakeType>+Failed",
                        ShortTrace = "NotEmpty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is empty"
                    }
                });

            #endregion

            #region ""

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<String>+Failed",
                        ShortTrace = "NotEmpty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is empty"
                    }
                });

            #endregion

            #region 0

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Int32>+Failed",
                        ShortTrace = "NotEmpty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is empty"
                    }
                });

            #endregion

            #region 0.0

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 0.0,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 0.0,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Double>+Failed",
                        ShortTrace = "NotEmpty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is empty"
                    }
                });

            #endregion

            #region False

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Boolean>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Boolean>+Failed",
                        ShortTrace = "NotEmpty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is empty"
                    }
                });

            #endregion

            #region emptyArr

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Int32[]>+Failed",
                        ShortTrace = "NotEmpty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is empty"
                    }
                });

            #endregion

            #region emptyList

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<List<String>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<List<String>>+Failed",
                        ShortTrace = "NotEmpty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is empty"
                    }
                });

            #endregion

            #region emptyDict

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<Dictionary<String,Boolean>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Dictionary<String,Boolean>>+Failed",
                        ShortTrace = "NotEmpty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is empty"
                    }
                });

            #endregion

            #region emptyFake

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<FakeType>+Failed",
                        ShortTrace = "NotEmpty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is empty"
                    }
                });

            #endregion

            #region (int?)null

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmptySpecification<int?>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is empty"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "NotEmpty+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is empty"
                    }
                });

            #endregion
        }
    }
}