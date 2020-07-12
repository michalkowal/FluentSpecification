using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.LengthSpecificationResults
{
    public class LengthValidResults : List<ExpectedSpecificationResult>
    {
        public LengthValidResults()
        {
            #region ""/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 0 }
                            },
                            Candidate = "",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<String>",
                        ShortTrace = "Length"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "test"/4

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 4 }
                            },
                            Candidate = "test",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<String>",
                        ShortTrace = "Length"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region emptyArr/0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 0 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<Int32[]>",
                        ShortTrace = "Length"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region arr/3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthSpecification<Int32[]>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<Int32[]>",
                        ShortTrace = "Length"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region list/3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthSpecification<List<Int32>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<List<Int32>>",
                        ShortTrace = "Length"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region dict/2

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthSpecification<Dictionary<Int32,Boolean>>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 2 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<Dictionary<Int32,Boolean>>",
                        ShortTrace = "Length"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ft/3

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthSpecification<FakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 3 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<FakeType>",
                        ShortTrace = "Length"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region ift/1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(LengthSpecification<InterFakeType>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>
                            {
                                { "Length", 1 }
                            },
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "LengthSpecification<InterFakeType>",
                        ShortTrace = "Length"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion
        }
    }
}