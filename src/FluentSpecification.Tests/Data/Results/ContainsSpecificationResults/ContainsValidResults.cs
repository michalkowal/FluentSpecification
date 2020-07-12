using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.ContainsSpecificationResults
{
    public class ContainsValidResults : List<ExpectedSpecificationResult>
    {
        public ContainsValidResults()
        {
            #region arr/5

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 5 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification<Int32[],Int32>",
                        ShortTrace = "Contains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region list/"Second"

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", "Second" }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification<List<String>,String>",
                        ShortTrace = "Contains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region dict/["First", false]

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", new KeyValuePair<String, Boolean>("First", false) }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>",
                        ShortTrace = "Contains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region cmpArr/cmp

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
                            IsNegation = false,
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
                        FullTrace = "ContainsSpecification<EquatableFakeType[],EquatableFakeType>",
                        ShortTrace = "Contains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ft/200/intComparer

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expected", 200 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "ContainsSpecification<FakeType,Int32>",
                        ShortTrace = "Contains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ftArr/ft

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
                            IsNegation = false,
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
                        FullTrace = "ContainsSpecification<FakeType[],FakeType>",
                        ShortTrace = "Contains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ftArr/empty/comparer

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
                            IsNegation = false,
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
                        FullTrace = "ContainsSpecification<FakeType[],FakeType>",
                        ShortTrace = "Contains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ftArr/(FakeType)null

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
                            IsNegation = false,
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
                        FullTrace = "ContainsSpecification<FakeType[],FakeType>",
                        ShortTrace = "Contains"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ftArr2/(FakeType)cmp2

            Add(new ExpectedSpecificationResult
            {
                TotalSpecificationsCount = 1,
                OverallResult = true,
                Specifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = true,
                        SpecificationType = typeof(ContainsSpecification<FakeType[], FakeType>),
                        IsNegation = false,
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
                    FullTrace = "ContainsSpecification<FakeType[],FakeType>",
                    ShortTrace = "Contains"
                },
                FailedSpecificationsCount = 0,
                Errors = new List<string>()
            });

            #endregion
        }
    }
}