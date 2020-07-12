using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.EmptySpecificationResults
{
    public class EmptyNegationValidResults : List<ExpectedSpecificationResult>
    {
        public EmptyNegationValidResults()
        {
            #region obj

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<Object>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Object>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region " "

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = " ",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<String>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "	"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "	",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<String>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "\n"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "\n",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<String>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "\r"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "\r",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<String>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region "test"

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "test",
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<String>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region 1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<Int32>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 1,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Int32>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region 0,1

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<Double>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 0.1,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Double>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region True

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<Boolean>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = true,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Boolean>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region arr

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<Int32[]>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Int32[]>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region list

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<List<String>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<List<String>>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region dict

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<Dictionary<String,Boolean>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<Dictionary<String,Boolean>>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region fake

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = true,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = true,
                            SpecificationType = typeof(EmptySpecification<FakeType>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>()
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotEmptySpecification<FakeType>",
                        ShortTrace = "NotEmpty"
                    },
                    FailedSpecificationsCount = 0,
                    Errors = new List<string>()
                });

            #endregion

            #region (int?)0

            Add(new ExpectedSpecificationResult
            {
                TotalSpecificationsCount = 1,
                OverallResult = true,
                Specifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = true,
                        SpecificationType = typeof(EmptySpecification<int?>),
                        IsNegation = true,
                        Parameters = new Dictionary<string, object>(),
                        Candidate = 0,
                        Errors = new List<string>()
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "NotEmptySpecification<Nullable<Int32>>",
                    ShortTrace = "NotEmpty"
                },
                FailedSpecificationsCount = 0,
                Errors = new List<string>()
            });

            #endregion
        }
    }
}