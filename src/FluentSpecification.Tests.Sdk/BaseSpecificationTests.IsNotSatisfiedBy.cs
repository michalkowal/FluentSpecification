using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Tests.Sdk.Data.Validation;
using Xunit;

namespace FluentSpecification.Tests.Sdk
{
    public partial class BaseSpecificationTests
    {
        protected void Assert_IsNotSatisfiedBy_True<TCandidate>(INegatableValidationSpecification<TCandidate> sut, TCandidate candidate)
        {
            AssertIsNotSatisfiedBy(sut, candidate, true);
        }

        protected void Assert_IsNotSatisfiedBy_False<TCandidate>(INegatableValidationSpecification<TCandidate> sut, TCandidate candidate)
        {
            AssertIsNotSatisfiedBy(sut, candidate, false);
        }

        protected void Assert_IsNotSatisfiedByValidation_True<TCandidate>(INegatableValidationSpecification<TCandidate> sut, TCandidate candidate, 
            ExpectedSpecificationResult expectedResult)
        {
            AssertIsNotSatisfiedByValidation(sut, candidate, expectedResult, true);
        }

        protected void Assert_IsNotSatisfiedByValidation_False<TCandidate>(INegatableValidationSpecification<TCandidate> sut, TCandidate candidate, 
            ExpectedSpecificationResult expectedResult)
        {
            AssertIsNotSatisfiedByValidation(sut, candidate, expectedResult, false);
        }

        private void AssertIsNotSatisfiedBy<TCandidate>(INegatableValidationSpecification<TCandidate> sut, TCandidate candidate, bool expectedOverall)
        {
            var overall = sut.IsNotSatisfiedBy(candidate);

            Assert.Equal(expectedOverall, overall);
        }

        private void AssertIsNotSatisfiedByValidation<TCandidate>(INegatableValidationSpecification<TCandidate> sut, TCandidate candidate, 
            ExpectedSpecificationResult expectedResult, bool expectedOverall)
        {
            var overall = sut.IsNotSatisfiedBy(candidate, out var result);

            Assert.Equal(expectedOverall, overall);
            Assert.True(expectedResult.Equals(result));
        }
    }
}
