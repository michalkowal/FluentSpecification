using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Data.Results.ExpressionSpecificationResults
{
    public class ExpressionValidResults : List<ExpectedSpecificationResult>
    {
        public ExpressionValidResults()
        {
            #region dum/True<object>

            Add(new ExpectedSpecificationResult
            {
                TotalSpecificationsCount = 1,
                OverallResult = true,
                Specifications = new List<ExpectedSpecificationInfo>
                {
                    new ExpectedSpecificationInfo
                    {
                        Result = true,
                        SpecificationType = typeof(ExpressionSpecification<object>),
                        IsNegation = false,
                        Parameters = new Dictionary<string, object>
                        {
                            { "Expression", null }
                        },
                        Candidate = null,
                        Errors = new List<string>()
                    }
                },
                FailedSpecifications = new List<ExpectedSpecificationInfo>(),
                Trace = new ExpectedSpecificationTrace
                {
                    FullTrace = "ExpressionSpecification<Object>",
                    ShortTrace = "Expression"
                },
                FailedSpecificationsCount = 0,
                Errors = new List<string>()
            });

            #endregion
        }
    }
}
