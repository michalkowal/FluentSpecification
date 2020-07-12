using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.EmailSpecificationResults
{
    public class EmailInvalidResults : List<ExpectedSpecificationResult>
    {
        public EmailInvalidResults()
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
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
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
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
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
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = " ",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = " ",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
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
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "	",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "	",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "plainAddress"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "plainAddress",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "plainAddress",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "#@%^%#$@#$@#.com"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "#@%^%#$@#$@#.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "#@%^%#$@#$@#.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "@example.com"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "Joe Smith <email@example.com>"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "Joe Smith <email@example.com>",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "Joe Smith <email@example.com>",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "email.example.com"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email.example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email.example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "email@example@example.com"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region ".email@example.com"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = ".email@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = ".email@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "email.@example.com"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email.@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email.@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "email..email@example.com"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email..email@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email..email@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "あいうえお@example.com"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "あいうえお@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "あいうえお@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "email@example.com (Joe Smith)"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example.com (Joe Smith)",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example.com (Joe Smith)",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "email@example"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "email@-example.com"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@-example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@-example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "email@example..com"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example..com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "email@example..com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion

            #region "Abc..123@example.com"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "Abc..123@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EmailSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "Abc..123@example.com",
                            Errors = new List<string>
                            {
                                "String is invalid email"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EmailSpecification+Failed",
                        ShortTrace = "Email+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "String is invalid email"
                    }
                });

            #endregion
        }
    }
}