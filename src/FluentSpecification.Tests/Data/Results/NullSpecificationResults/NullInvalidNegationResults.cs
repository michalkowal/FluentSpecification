using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;
using System;
using System.Collections.Generic;

namespace FluentSpecification.Tests.Data.Results.NullSpecificationResults
{
    public class NullInvalidNegationResults : List<ExpectedSpecificationResult>
    {
        public NullInvalidNegationResults()
        {
            #region (string)null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(NullSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is null"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(NullSpecification<String>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is null"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotNullSpecification<String>+Failed",
                        ShortTrace = "NotNull+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is null"
                    }
                });

            #endregion

            #region (int?)null

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(NullSpecification<Nullable<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is null"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(NullSpecification<Nullable<Int32>>),
                            IsNegation = true,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = null,
                            Errors = new List<string>
                            {
                                "Object is null"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NotNullSpecification<Nullable<Int32>>+Failed",
                        ShortTrace = "NotNull+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is null"
                    }
                });

            #endregion
        }
    }
}
