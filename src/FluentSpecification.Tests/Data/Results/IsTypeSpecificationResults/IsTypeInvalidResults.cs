using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.IsTypeSpecificationResults
{
    public class IsTypeInvalidResults : List<ExpectedSpecificationResult>
    {
        public IsTypeInvalidResults()
        {
            #region ""/typeof(int)

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(Int32) }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object is not type of [Int32]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(Int32) }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object is not type of [Int32]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "IsTypeSpecification<String>+Failed",
                        ShortTrace = "IsType+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not type of [Int32]"
                    }
                });

            #endregion

            #region 1/typeof(string)

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(String) }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is not type of [String]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(String) }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is not type of [String]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "IsTypeSpecification<Int32>+Failed",
                        ShortTrace = "IsType+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not type of [String]"
                    }
                });

            #endregion

            #region ft/typeof(string)

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(String) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not type of [String]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(String) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not type of [String]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "IsTypeSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "IsType+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not type of [String]"
                    }
                });

            #endregion

            #region ft/typeof(EquatableFakeType)

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(EquatableFakeType) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not type of [EquatableFakeType]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(EquatableFakeType) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not type of [EquatableFakeType]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "IsTypeSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "IsType+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not type of [EquatableFakeType]"
                    }
                });

            #endregion

            #region ft/typeof(IEquatable<ComparableFakeType>)

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(IEquatable<ComparableFakeType>) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not type of [IEquatable<ComparableFakeType>]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(IEquatable<ComparableFakeType>) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not type of [IEquatable<ComparableFakeType>]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "IsTypeSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "IsType+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not type of [IEquatable<ComparableFakeType>]"
                    }
                });

            #endregion

            #region ft/typeof(IComparable<FakeType>)

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(IComparable<FakeType>) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not type of [IComparable<FakeType>]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(IComparable<FakeType>) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is not type of [IComparable<FakeType>]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "IsTypeSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "IsType+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not type of [IComparable<FakeType>]"
                    }
                });

            #endregion
        }
    }
}