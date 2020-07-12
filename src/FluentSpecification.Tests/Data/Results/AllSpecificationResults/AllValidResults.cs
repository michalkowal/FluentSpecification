using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.AllSpecificationResults
{
    public class AllValidResults : List<ExpectedSpecificationResult>
    {
        public AllValidResults()
        {
            #region arr/True<int>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 6,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AllSpecification<Int32[],Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 1,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 5,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 200,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 6,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 100,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AllSpecification<Int32[],Int32>([0](MockComplexSpecification[Int32]) And [1](MockComplexSpecification[Int32]) And [2](MockComplexSpecification[Int32]) And [3](MockComplexSpecification[Int32]) And [4](MockComplexSpecification[Int32]))",
                        ShortTrace = "All([0](MockComplex) And [1](MockComplex) And [2](MockComplex) And [3](MockComplex) And [4](MockComplex))"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region list/True<string>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 3,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AllSpecification<List<String>,String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = "First",
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = "Second",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AllSpecification<List<String>,String>([0](MockComplexSpecification[String]) And [1](MockComplexSpecification[String]))",
                        ShortTrace = "All([0](MockComplex) And [1](MockComplex))"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region dict/True<KeyValuePair<string, bool>>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 3,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AllSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = new KeyValuePair<String, Boolean>("First", true),
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<KeyValuePair<String,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = new KeyValuePair<String, Boolean>("Second", false),
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AllSpecification<Dictionary<String,Boolean>,KeyValuePair<String,Boolean>>([0](MockComplexSpecification[KeyValuePair<String,Boolean>]) And [1](MockComplexSpecification[KeyValuePair<String,Boolean>]))",
                        ShortTrace = "All([0](MockComplex) And [1](MockComplex))"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ft/True<int>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 6,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AllSpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 1,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 5,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 200,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 6,
                            Errors = new List<string>()
                        },
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(MockComplexSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Expression", null }
                            },
                            Candidate = 100,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AllSpecification<FakeType,Int32>([0](MockComplexSpecification[Int32]) And [1](MockComplexSpecification[Int32]) And [2](MockComplexSpecification[Int32]) And [3](MockComplexSpecification[Int32]) And [4](MockComplexSpecification[Int32]))",
                        ShortTrace = "All([0](MockComplex) And [1](MockComplex) And [2](MockComplex) And [3](MockComplex) And [4](MockComplex))"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region empty/True<int>

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(AllSpecification<FakeType,Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "SpecificationForAll", null }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "AllSpecification<FakeType,Int32>()",
                        ShortTrace = "All()"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion
        }
    }
}