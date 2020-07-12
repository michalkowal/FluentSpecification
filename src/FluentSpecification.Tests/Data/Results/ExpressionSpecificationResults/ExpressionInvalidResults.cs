using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.ExpressionSpecificationResults
{
    public class ExpressionInvalidResults : List<ExpectedSpecificationResult>
    {
        public ExpressionInvalidResults()
        {
            #region dum/False<object>

            Add(new ExpectedSpecificationResult
            {
                TotalSpecificationsCount = 1,
                OverallResult = false,
                Specifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = false,
                        SpecificationType = typeof(ExpressionSpecification<object>),
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>
                        {
                            { "Expression", null }
                        },
                        Candidate = null,
                        Errors = new List<string>
                        {
                            "Specification doesn't meet expression: [candidate => False]"
                        }
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = false,
                        SpecificationType = typeof(ExpressionSpecification<object>),
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>
                        {
                            { "Expression", null }
                        },
                        Candidate = null,
                        Errors = new List<string>
                        {
                            "Specification doesn't meet expression: [candidate => False]"
                        }
                    }
                },
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "ExpressionSpecification<Object>+Failed",
                    ShortTrace = "Expression+Failed"
                },
                FailedSpecificationsCount = 1,
                Errors = new List<string>
                {
                    "Specification doesn't meet expression: [candidate => False]"
                }
            });

            #endregion
        }
    }
}
