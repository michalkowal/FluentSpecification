using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using Xunit;

namespace FluentSpecification.Tests.Sdk
{
    public abstract partial class BaseSpecificationTests
    {
        protected void Assert_GetExpressionInvoke_True<TCandidate>(ILinqSpecification<TCandidate> sut, TCandidate candidate)
        {
            AssertGetExpressionInvoke(sut, candidate, true);
        }

        protected void Assert_GetExpressionInvoke_False<TCandidate>(ILinqSpecification<TCandidate> sut, TCandidate candidate)
        {
            AssertGetExpressionInvoke(sut, candidate, false);
        }

        protected void Assert_GetExpression_EqualsBaseExpression<TCandidate>(ILinqSpecification<TCandidate> sut)
        {
            var expected = sut.GetExpression().ToString();
            var sutExpression = ((ILinqSpecification) sut).GetExpression();
            var result = sutExpression.ToString();

            Assert.Equal(expected, result);
        }

        private void AssertGetExpressionInvoke<TCandidate>(ILinqSpecification<TCandidate> sut, TCandidate candidate, bool expectedOverall)
        {
            var overall = sut.GetExpression().Compile().Invoke(candidate);

            Assert.Equal(expectedOverall, overall);
        }
    }
}
