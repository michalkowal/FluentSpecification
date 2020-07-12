using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.ContainsSpecificationResults
{
    public class ContainsNegationValidResults : List<ExpectedSpecificationResult>
    {
        public ContainsNegationValidResults()
        {
            #region arr/16

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(ContainsSpecification<Int32[],Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 16 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<Int32[],Int32>",
                        ShortTrace = "NotContains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region list/"Third"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(ContainsSpecification<List<String>,String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "Third" }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<List<String>,String>",
                        ShortTrace = "NotContains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region dict/["Third", false]

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(ContainsSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", new KeyValuePair<String, Boolean>("Third", false) }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>",
                        ShortTrace = "NotContains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ft/16/intComparer

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(ContainsSpecification<FakeType,Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 16 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<FakeType,Int32>",
                        ShortTrace = "NotContains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region cmpArr/notCmp

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(ContainsSpecification<EquatableFakeType[],EquatableFakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<EquatableFakeType[],EquatableFakeType>",
                        ShortTrace = "NotContains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ftArr/empty

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(ContainsSpecification<FakeType[],FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<FakeType[],FakeType>",
                        ShortTrace = "NotContains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region (FakeType)null/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(ContainsSpecification<FakeType,Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotContainsSpecification<FakeType,Int32>",
                        ShortTrace = "NotContains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion
        }
    }
}