using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.GreaterThanSpecificationResults
{
    public class GreaterThanValidResults : List<ExpectedSpecificationResult>
    {
        public GreaterThanValidResults()
        {
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
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
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
                        FullTrace = "GreaterThanSpecification<Int32>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
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
                        FullTrace = "GreaterThanSpecification<Int32>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<Int32>),
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
                        FullTrace = "GreaterThanSpecification<Int32>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
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
                        FullTrace = "GreaterThanSpecification<Double>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
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
                        FullTrace = "GreaterThanSpecification<Double>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<Double>),
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
                        FullTrace = "GreaterThanSpecification<Double>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<Boolean>),
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
                        FullTrace = "GreaterThanSpecification<Boolean>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<String>),
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
                        FullTrace = "GreaterThanSpecification<String>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<String>),
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
                        FullTrace = "GreaterThanSpecification<String>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<String>),
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
                        FullTrace = "GreaterThanSpecification<String>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<DateTime>),
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
                        FullTrace = "GreaterThanSpecification<DateTime>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<DateTime>),
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
                        FullTrace = "GreaterThanSpecification<DateTime>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<ComparableFakeType>),
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
                        FullTrace = "GreaterThanSpecification<ComparableFakeType>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<ComparableInterFakeType>),
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
                        FullTrace = "GreaterThanSpecification<ComparableInterFakeType>",
                        ShortTrace = "GreaterThan"
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
                            SpecificationType = typeof(GreaterThanSpecification<FakeType>),
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
                        FullTrace = "GreaterThanSpecification<FakeType>",
                        ShortTrace = "GreaterThan"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region 0/(int?)null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(GreaterThanSpecification<Nullable<Int32>>),
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
                        FullTrace = "GreaterThanSpecification<Nullable<Int32>>",
                        ShortTrace = "GreaterThan"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion
        }
    }
}