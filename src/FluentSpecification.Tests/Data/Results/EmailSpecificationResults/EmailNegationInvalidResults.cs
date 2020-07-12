using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.EmailSpecificationResults
{
    public class EmailNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public EmailNegationInvalidResults()
        {
            #region "email@example.com"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion

            #region "firstname.lastname@example.com"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "firstname.lastname@example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "firstname.lastname@example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion

            #region "email@subdomain.example.com"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@subdomain.example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@subdomain.example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion

            #region "firstname+lastname@example.com"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "firstname+lastname@example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "firstname+lastname@example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion

            #region "email@123.123.123.123"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@123.123.123.123",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@123.123.123.123",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion

            #region "email@[123.123.123.123]"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@[123.123.123.123]",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@[123.123.123.123]",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion

            #region "\"email\"@example.com"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "\"email\"@example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "\"email\"@example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion

            #region "1234567890@example.com"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "1234567890@example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "1234567890@example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion

            #region "email@example-one.com"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example-one.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example-one.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion

            #region "email@example.name"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example.name",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example.name",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion

            #region "email@example.museum"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example.museum",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example.museum",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion

            #region "email@example.co.jp"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example.co.jp",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example.co.jp",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion

            #region "firstname-lastname@example.com"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "firstname-lastname@example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "firstname-lastname@example.com",
                            Errors = new List<string>
                            {
                                "String is valid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmailSpecification+Failed",
                        ShortTrace = "NotEmail+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is valid email"
                    }
                });

            #endregion
        }
    }
}