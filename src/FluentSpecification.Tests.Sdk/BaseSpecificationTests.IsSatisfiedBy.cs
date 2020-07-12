using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Tests.Sdk.Data.Validation;
using Xunit;

namespace FluentSpecification.Tests.Sdk
{
    public partial class BaseSpecificationTests
    {
        protected void Assert_IsSatisfiedBy_True<TCandidate>(IValidationSpecification<TCandidate> sut, TCandidate candidate)
        {
            AssertIsSatisfiedBy(sut, candidate, true);
        }

        protected void Assert_IsSatisfiedBy_False<TCandidate>(IValidationSpecification<TCandidate> sut, TCandidate candidate)
        {
            AssertIsSatisfiedBy(sut, candidate, false);
        }

        protected void Assert_IsSatisfiedByValidation_True<TCandidate>(IValidationSpecification<TCandidate> sut, TCandidate candidate, 
            ExpectedSpecificationResult expectedResult)
        {
            AssertIsSatisfiedByValidation(sut, candidate, expectedResult, true);
        }

        protected void Assert_IsSatisfiedByValidation_False<TCandidate>(IValidationSpecification<TCandidate> sut, TCandidate candidate, 
            ExpectedSpecificationResult expectedResult)
        {
            AssertIsSatisfiedByValidation(sut, candidate, expectedResult, false);
        }

        private void AssertIsSatisfiedBy<TCandidate>(IValidationSpecification<TCandidate> sut, TCandidate candidate, bool expectedOverall)
        {
            var overall = sut.IsSatisfiedBy(candidate);

            Assert.Equal(expectedOverall, overall);
        }

        private void AssertIsSatisfiedByValidation<TCandidate>(IValidationSpecification<TCandidate> sut, TCandidate candidate, 
            ExpectedSpecificationResult expectedResult, bool expectedOverall)
        {
            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.Equal(expectedOverall, overall);
            Assert.True(expectedResult.Equals(result));
        }
    }
}
