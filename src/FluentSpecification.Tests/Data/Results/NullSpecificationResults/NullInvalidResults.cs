using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentSpecification.Tests.Data.Results.NullSpecificationResults
{
    public class NullInvalidResults : List<ExpectedSpecificationResult>
    {
        public NullInvalidResults()
        {
            #region ""

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
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object is not null"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(NullSpecification<String>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = "",
                            Errors = new List<string>
                            {
                                "Object is not null"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NullSpecification<String>+Failed",
                        ShortTrace = "Null+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not null"
                    }
                });

            #endregion

            #region 0

            Add(new ExpectedSpecificationResult
                {
                    TotalSpecificationsCount = 1,
                    OverallResult = false,
                    Specifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(NullSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Object is not null"
                            }
                        }
                    },
                    FailedSpecifications = new List<ExpectedSpecificationInfo>
                    {
                        new ExpectedSpecificationInfo
                        {
                            Result = false,
                            SpecificationType = typeof(NullSpecification<Int32>),
                            IsNegation = false,
                            Parameters = new Dictionary<string, object>(),
                            Candidate = 0,
                            Errors = new List<string>
                            {
                                "Object is not null"
                            }
                        }
                    },
                    Trace = new ExpectedSpecificationTrace
                    {
                        FullTrace = "NullSpecification<Int32>+Failed",
                        ShortTrace = "Null+Failed"
                    },
                    FailedSpecificationsCount = 1,
                    Errors = new List<string>
                    {
                        "Object is not null"
                    }
                });

            #endregion
        }
    }
}
