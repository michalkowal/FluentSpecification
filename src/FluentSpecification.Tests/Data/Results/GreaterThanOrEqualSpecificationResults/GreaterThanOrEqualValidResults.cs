using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.GreaterThanOrEqualSpecificationResults
{
    public class GreaterThanOrEqualValidResults : List<ExpectedSpecificationResult>
    {
        public GreaterThanOrEqualValidResults()
        {
            #region 2/2

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 2 }
                            },
                            Candidate = 2,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Int32>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region -2/-2

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -2 }
                            },
                            Candidate = -2,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Int32>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region 5/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 1 }
                            },
                            Candidate = 5,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Int32>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region 1/-1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -1 }
                            },
                            Candidate = 1,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Int32>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region -1/-9/intComparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -9 }
                            },
                            Candidate = -1,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Int32>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region 3.5/3.5

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 3.5 }
                            },
                            Candidate = 3.5,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Double>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region -3.5/-3.5

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -3.5 }
                            },
                            Candidate = -3.5,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Double>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region 5.75/5.74

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", 5.74 }
                            },
                            Candidate = 5.75,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Double>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region 0.0/-2.5

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -2.5 }
                            },
                            Candidate = 0.0,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Double>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region -5.74/-5.75

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Double>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", -5.75 }
                            },
                            Candidate = -5.74,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Double>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region False/False

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", false }
                            },
                            Candidate = false,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Boolean>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region True/False

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Boolean>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", false }
                            },
                            Candidate = true,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Boolean>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "124"/"123"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "124",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<String>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "1234"/"123"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "1234",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<String>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "123"/"123"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", "123" }
                            },
                            Candidate = "123",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<String>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "test1"/null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = "test1",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<String>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region (string)null/null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<String>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region 2019-07-11/2018-01-15

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2018-01-15") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<DateTime>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region 2019-07-11/2019-07-01

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-07-01") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<DateTime>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region 2019-07-11/2019-07-11

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<DateTime>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", DateTime.Parse("2019-07-11") }
                            },
                            Candidate = DateTime.Parse("2019-07-11"),
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<DateTime>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region cmp/cmp2

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<ComparableFakeType>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region cmp3/cmp4

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<ComparableFakeType>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region (ComparableFakeType)null/null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<ComparableFakeType>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region cmpInter1/cmpInter3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableInterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<ComparableInterFakeType>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region cmpInter1/cmpInter2

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<ComparableInterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<ComparableInterFakeType>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region cmpFakeType/cmpFakeType2/comparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<FakeType>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region cmpFakeType3/cmpFakeType4/comparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<FakeType>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region (FakeType)null/null/comparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<FakeType>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region (int?)0/null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = 0,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Nullable<Int32>>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region (int?)null/null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanOrEqualSpecification<Nullable<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "GreaterThan", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "GreaterThanOrEqualSpecification<Nullable<Int32>>",
                        ShortTrace = "GreaterThanOrEqual"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion
        }
    }
}