using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.LengthBetweenSpecificationResults
{
    public class LengthBetweenValidResults : List<ExpectedSpecificationResult>
    {
        public LengthBetweenValidResults()
        {
            #region ""/0/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthBetweenSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 0 }
                            },
                            Candidate = "",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<String>",
                        ShortTrace = "LengthBetween"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "test"/1/4

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthBetweenSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 },
                                { "MaxLength", 4 }
                            },
                            Candidate = "test",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<String>",
                        ShortTrace = "LengthBetween"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region emptyArr/0/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthBetweenSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<Int32[]>",
                        ShortTrace = "LengthBetween"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region arr/2/3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthBetweenSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 2 },
                                { "MaxLength", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<Int32[]>",
                        ShortTrace = "LengthBetween"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region list/-1/10

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthBetweenSpecification<List<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", -1 },
                                { "MaxLength", 10 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<List<Int32>>",
                        ShortTrace = "LengthBetween"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region dict/0/5

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthBetweenSpecification<Dictionary<Int32,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 5 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<Dictionary<Int32,Boolean>>",
                        ShortTrace = "LengthBetween"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ft/0/3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthBetweenSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 0 },
                                { "MaxLength", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<FakeType>",
                        ShortTrace = "LengthBetween"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ift/1/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthBetweenSpecification<InterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "MinLength", 1 },
                                { "MaxLength", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthBetweenSpecification<InterFakeType>",
                        ShortTrace = "LengthBetween"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion
        }
    }
}