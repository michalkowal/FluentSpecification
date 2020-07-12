using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.CreditCardSpecificationResults
{
    public class CreditCardNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public CreditCardNegationInvalidResults()
        {
            #region "4111 1111 1111 1111"

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "4111 1111 1111 1111",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "4111 1111 1111 1111",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotCreditCardSpecification+Failed",
                        ShortTrace = "NotCreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is correct credit card number"
                    }
                });

            #endregion

            #region "5500 0000 0000 0004"

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "5500 0000 0000 0004",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "5500 0000 0000 0004",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotCreditCardSpecification+Failed",
                        ShortTrace = "NotCreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is correct credit card number"
                    }
                });

            #endregion

            #region "3400-0000-0000-009"

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "3400-0000-0000-009",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "3400-0000-0000-009",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotCreditCardSpecification+Failed",
                        ShortTrace = "NotCreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is correct credit card number"
                    }
                });

            #endregion

            #region "3000 0000 0000 04"

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "3000 0000 0000 04",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "3000 0000 0000 04",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotCreditCardSpecification+Failed",
                        ShortTrace = "NotCreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is correct credit card number"
                    }
                });

            #endregion

            #region "6011,0000,0000,0004"

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "6011,0000,0000,0004",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "6011,0000,0000,0004",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotCreditCardSpecification+Failed",
                        ShortTrace = "NotCreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is correct credit card number"
                    }
                });

            #endregion

            #region "3566002020360505"

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "3566002020360505",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "3566002020360505",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotCreditCardSpecification+Failed",
                        ShortTrace = "NotCreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is correct credit card number"
                    }
                });

            #endregion

            #region "6759649826438453"

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "6759649826438453",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "6759649826438453",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotCreditCardSpecification+Failed",
                        ShortTrace = "NotCreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is correct credit card number"
                    }
                });

            #endregion

            #region "5555 5555 5555 8726"

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "5555 5555 5555 8726",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "5555 5555 5555 8726",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotCreditCardSpecification+Failed",
                        ShortTrace = "NotCreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is correct credit card number"
                    }
                });

            #endregion

            #region "378282246310005"

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "378282246310005",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "378282246310005",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotCreditCardSpecification+Failed",
                        ShortTrace = "NotCreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is correct credit card number"
                    }
                });

            #endregion

            #region "3530111333300000"

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "3530111333300000",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "3530111333300000",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotCreditCardSpecification+Failed",
                        ShortTrace = "NotCreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is correct credit card number"
                    }
                });

            #endregion

            #region "4917484589897107"

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "4917484589897107",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(CreditCardSpecification),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "4917484589897107",
                            Errors = new List<string>
                            {
                                "Value is correct credit card number"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotCreditCardSpecification+Failed",
                        ShortTrace = "NotCreditCard+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Value is correct credit card number"
                    }
                });

            #endregion
        }
    }
}