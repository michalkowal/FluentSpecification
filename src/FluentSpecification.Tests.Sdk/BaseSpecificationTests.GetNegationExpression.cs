using FluentSpecification.Abstractions.Generic;
using Xunit;

namespace FluentSpecification.Tests.Sdk
{
    public partial class BaseSpecificationTests
    {
        protected void Assert_GetNegationExpressionInvoke_True<TCandidate>(INegatableLinqSpecification<TCandidate> sut, TCandidate candidate)
        {
            AssertGetNegationExpressionInvoke(sut, candidate, true);
        }

        protected void Assert_GetNegationExpressionInvoke_False<TCandidate>(INegatableLinqSpecification<TCandidate> sut, TCandidate candidate)
        {
            AssertGetNegationExpressionInvoke(sut, candidate, false);
        }

        private void AssertGetNegationExpressionInvoke<TCandidate>(INegatableLinqSpecification<TCandidate> sut, TCandidate candidate, bool expectedOverall)
        {
            var overall = sut.GetNegationExpression().Compile().Invoke(candidate);

            Assert.Equal(expectedOverall, overall);
        }
    }
}
