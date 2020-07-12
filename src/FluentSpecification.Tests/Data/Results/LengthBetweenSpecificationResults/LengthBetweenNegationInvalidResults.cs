using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.LengthBetweenSpecificationResults
{
    public class LengthBetweenNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public LengthBetweenNegationInvalidResults()
        {
            #region ""/0/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 0 }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object length is between [0] and [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 0 }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object length is between [0] and [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLengthBetweenSpecification<String>+Failed",
                        ShortTrace = "NotLengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is between [0] and [0]"
                    }
                });

            #endregion

            #region "test"/1/4

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 },
                                { "MaxLength", 4 }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object length is between [1] and [4]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 },
                                { "MaxLength", 4 }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object length is between [1] and [4]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLengthBetweenSpecification<String>+Failed",
                        ShortTrace = "NotLengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is between [1] and [4]"
                    }
                });

            #endregion

            #region emptyArr/0/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is between [0] and [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is between [0] and [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLengthBetweenSpecification<Int32[]>+Failed",
                        ShortTrace = "NotLengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is between [0] and [0]"
                    }
                });

            #endregion

            #region arr/2/3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 2 },
                                { "MaxLength", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is between [2] and [3]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 2 },
                                { "MaxLength", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is between [2] and [3]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLengthBetweenSpecification<Int32[]>+Failed",
                        ShortTrace = "NotLengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is between [2] and [3]"
                    }
                });

            #endregion

            #region list/-1/10

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<List<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", -1 },
                                { "MaxLength", 10 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is between [-1] and [10]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<List<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", -1 },
                                { "MaxLength", 10 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is between [-1] and [10]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLengthBetweenSpecification<List<Int32>>+Failed",
                        ShortTrace = "NotLengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is between [-1] and [10]"
                    }
                });

            #endregion

            #region dict/0/5

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<Dictionary<Int32,Boolean>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 5 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is between [0] and [5]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<Dictionary<Int32,Boolean>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 5 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is between [0] and [5]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLengthBetweenSpecification<Dictionary<Int32,Boolean>>+Failed",
                        ShortTrace = "NotLengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is between [0] and [5]"
                    }
                });

            #endregion

            #region ft/0/3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is between [0] and [3]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is between [0] and [3]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLengthBetweenSpecification<FakeType>+Failed",
                        ShortTrace = "NotLengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is between [0] and [3]"
                    }
                });

            #endregion

            #region ift/1/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<InterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 },
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is between [1] and [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<InterFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 },
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is between [1] and [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotLengthBetweenSpecification<InterFakeType>+Failed",
                        ShortTrace = "NotLengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is between [1] and [1]"
                    }
                });

            #endregion
        }
    }
}