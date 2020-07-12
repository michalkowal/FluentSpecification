using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.EqualSpecificationResults
{
    public class EqualInvalidResults : List<ExpectedSpecificationResult>
    {
        public EqualInvalidResults()
        {
            #region obj1/obj3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Object>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [System.Object]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Object>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [System.Object]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<Object>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [System.Object]"
                    }
                });

            #endregion

            #region "test"/"another test"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "another test" }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object is not equal to [another test]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "another test" }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object is not equal to [another test]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<String>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [another test]"
                    }
                });

            #endregion

            #region "test"/null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object is not equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = "test",
                            Errors = new List<string>
                            {
                                "Object is not equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<String>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [null]"
                    }
                });

            #endregion

            #region (string)null/"test"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "test" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [test]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "test" }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [test]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<String>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [test]"
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
                            SpecificationType = typeof(EqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", -1 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is not equal to [-1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", -1 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is not equal to [-1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<Int32>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [-1]"
                    }
                });

            #endregion

            #region 1/-1/intComparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", -1 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is not equal to [-1]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", -1 }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is not equal to [-1]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<Int32>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [-1]"
                    }
                });

            #endregion

            #region 5.74/3.74

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 3.74 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Object is not equal to [3.74]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 3.74 }
                            },
                            Candidate = 5.74,
                            Errors = new List<string>
                            {
                                "Object is not equal to [3.74]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<Double>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [3.74]"
                    }
                });

            #endregion

            #region False/True

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", true }
                            },
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Object is not equal to [True]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", true }
                            },
                            Candidate = false,
                            Errors = new List<string>
                            {
                                "Object is not equal to [True]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<Boolean>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [True]"
                    }
                });

            #endregion

            #region obj1/null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Object>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Object>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<Object>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [null]"
                    }
                });

            #endregion

            #region null/obj1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Object>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [System.Object]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Object>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [System.Object]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<Object>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [System.Object]"
                    }
                });

            #endregion

            #region eq1/neq

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<EquatableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [Fake(11)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<EquatableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [Fake(11)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<EquatableFakeType>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [Fake(11)]"
                    }
                });

            #endregion

            #region eq1/null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<EquatableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<EquatableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<EquatableFakeType>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [null]"
                    }
                });

            #endregion

            #region (EquatableFakeType)null/eq1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<EquatableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [Fake(15)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<EquatableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [Fake(15)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<EquatableFakeType>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [Fake(15)]"
                    }
                });

            #endregion

            #region cmp1/notCmp

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [Fake(11)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [Fake(11)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [Fake(11)]"
                    }
                });

            #endregion

            #region cmp1/null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [null]"
                    }
                });

            #endregion

            #region (ComparableFakeType)null/cmp1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [Fake(15)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [Fake(15)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [Fake(15)]"
                    }
                });

            #endregion

            #region cmpInter1/notCmpInter

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<ComparableInterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<ComparableInterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<ComparableInterFakeType>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [FluentSpecification.Tests.Mocks.ComparableInterFakeType]"
                    }
                });

            #endregion

            #region f1/f2

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [Fake(0)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [Fake(0)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<FakeType>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [Fake(0)]"
                    }
                });

            #endregion

            #region f1/null/comparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<FakeType>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [null]"
                    }
                });

            #endregion

            #region (FakeType)null/f1/comparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [Fake(0)]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [Fake(0)]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<FakeType>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [Fake(0)]"
                    }
                });

            #endregion

            #region 0/(int?)null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Object is not equal to [null]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Object is not equal to [null]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [null]"
                    }
                });

            #endregion

            #region (int?)null/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [0]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(EqualSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not equal to [0]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "EqualSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "Equal+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not equal to [0]"
                    }
                });

            #endregion
        }
    }
}