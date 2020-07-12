using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.IsTypeSpecificationResults
{
    public class IsTypeNegationInvalidResults : List<ExpectedSpecificationResult>
    {
        public IsTypeNegationInvalidResults()
        {
            #region ""/typeof(string)

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(String) }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object is type of [String]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(String) }
                            },
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object is type of [String]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotIsTypeSpecification<String>+Failed",
                        ShortTrace = "NotIsType+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is type of [String]"
                    }
                });

            #endregion

            #region 1/typeof(int)

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(Int32) }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is type of [Int32]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(Int32) }
                            },
                            Candidate = 1,
                            Errors = new List<string>
                            {
                                "Object is type of [Int32]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotIsTypeSpecification<Int32>+Failed",
                        ShortTrace = "NotIsType+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is type of [Int32]"
                    }
                });

            #endregion

            #region ft/typeof(FakeType)

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(FakeType) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is type of [FakeType]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(FakeType) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is type of [FakeType]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotIsTypeSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "NotIsType+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is type of [FakeType]"
                    }
                });

            #endregion

            #region ft/typeof(IComparable<ComparableFakeType>)

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(IComparable<ComparableFakeType>) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is type of [IComparable<ComparableFakeType>]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(IComparable<ComparableFakeType>) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is type of [IComparable<ComparableFakeType>]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotIsTypeSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "NotIsType+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is type of [IComparable<ComparableFakeType>]"
                    }
                });

            #endregion

            #region ft/typeof(IEnumerable<int>)

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
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(IEnumerable<Int32>) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is type of [IEnumerable<Int32>]"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(IsTypeSpecification<ComparableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", typeof(IEnumerable<Int32>) }
                            },
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is type of [IEnumerable<Int32>]"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotIsTypeSpecification<ComparableFakeType>+Failed",
                        ShortTrace = "NotIsType+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is type of [IEnumerable<Int32>]"
                    }
                });

            #endregion
        }
    }
}