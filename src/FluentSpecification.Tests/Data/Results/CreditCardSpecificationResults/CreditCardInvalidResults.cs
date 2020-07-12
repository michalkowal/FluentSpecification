using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.CreditCardSpecificationResults
{
    public class CreditCardInvalidResults : List<ExpectedSpecificationResult>
    {
        public CreditCardInvalidResults()
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
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "CreditCardSpecification+Failed",
                        ShortTrace = "CreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not correct credit card number"
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
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "CreditCardSpecification+Failed",
                        ShortTrace = "CreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not correct credit card number"
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
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = " ",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = " ",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "CreditCardSpecification+Failed",
                        ShortTrace = "CreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not correct credit card number"
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
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "	",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "	",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "CreditCardSpecification+Failed",
                        ShortTrace = "CreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not correct credit card number"
                    }
                });

            #endregion

            #region "plaintext"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "plaintext",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "plaintext",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "CreditCardSpecification+Failed",
                        ShortTrace = "CreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not correct credit card number"
                    }
                });

            #endregion

            #region "123456789"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "123456789",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "123456789",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "CreditCardSpecification+Failed",
                        ShortTrace = "CreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not correct credit card number"
                    }
                });

            #endregion

            #region "6745 5555 5555 8726"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "6745 5555 5555 8726",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "6745 5555 5555 8726",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "CreditCardSpecification+Failed",
                        ShortTrace = "CreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not correct credit card number"
                    }
                });

            #endregion

            #region "479282246310035"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "479282246310035",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "479282246310035",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "CreditCardSpecification+Failed",
                        ShortTrace = "CreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not correct credit card number"
                    }
                });

            #endregion

            #region "1430111333300000"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "1430111333300000",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "1430111333300000",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "CreditCardSpecification+Failed",
                        ShortTrace = "CreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not correct credit card number"
                    }
                });

            #endregion

            #region "0917484589897107"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "0917484589897107",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "0917484589897107",
                            Errors = new List<string>
                            {
                                "Value is not correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "CreditCardSpecification+Failed",
                        ShortTrace = "CreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is not correct credit card number"
                    }
                });

            #endregion
        }
    }
}