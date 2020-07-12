using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.LengthBetweenSpecificationResults
{
    public class LengthBetweenInvalidResults : List<ExpectedSpecificationResult>
    {
        public LengthBetweenInvalidResults()
        {
            #region ""/1/10

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 },
                                { "MaxLength", 10 }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object length is not between [1] and [10]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 },
                                { "MaxLength", 10 }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object length is not between [1] and [10]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<String>+Failed",
                        ShortTrace = "LengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not between [1] and [10]"
                    }
                });

            #endregion

            #region "test"/10/20

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 10 },
                                { "MaxLength", 20 }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object length is not between [10] and [20]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 10 },
                                { "MaxLength", 20 }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object length is not between [10] and [20]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<String>+Failed",
                        ShortTrace = "LengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not between [10] and [20]"
                    }
                });

            #endregion

            #region emptyArr/1/2

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 },
                                { "MaxLength", 2 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [1] and [2]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 },
                                { "MaxLength", 2 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [1] and [2]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<Int32[]>+Failed",
                        ShortTrace = "LengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not between [1] and [2]"
                    }
                });

            #endregion

            #region arr/-5/-1

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", -5 },
                                { "MaxLength", -1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [-5] and [-1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", -5 },
                                { "MaxLength", -1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [-5] and [-1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<Int32[]>+Failed",
                        ShortTrace = "LengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not between [-5] and [-1]"
                    }
                });

            #endregion

            #region list/0/1

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [0] and [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<List<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [0] and [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<List<Int32>>+Failed",
                        ShortTrace = "LengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not between [0] and [1]"
                    }
                });

            #endregion

            #region dict/0/1

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [0] and [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<Dictionary<Int32,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [0] and [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<Dictionary<Int32,Boolean>>+Failed",
                        ShortTrace = "LengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not between [0] and [1]"
                    }
                });

            #endregion

            #region ft/4/6

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 4 },
                                { "MaxLength", 6 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [4] and [6]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 4 },
                                { "MaxLength", 6 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [4] and [6]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<FakeType>+Failed",
                        ShortTrace = "LengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not between [4] and [6]"
                    }
                });

            #endregion

            #region ift/4/6

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 4 },
                                { "MaxLength", 6 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [4] and [6]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<InterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 4 },
                                { "MaxLength", 6 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [4] and [6]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<InterFakeType>+Failed",
                        ShortTrace = "LengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not between [4] and [6]"
                    }
                });

            #endregion

            #region (string)null/0/1

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [0] and [1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [0] and [1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<String>+Failed",
                        ShortTrace = "LengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not between [0] and [1]"
                    }
                });

            #endregion

            #region (FakeType)null/0/0

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [0] and [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(LengthBetweenSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object length is not between [0] and [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<FakeType>+Failed",
                        ShortTrace = "LengthBetween+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object length is not between [0] and [0]"
                    }
                });

            #endregion
        }
    }
}