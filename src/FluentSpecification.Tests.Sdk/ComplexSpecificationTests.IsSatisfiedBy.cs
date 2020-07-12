using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Validation;
using FluentSpecification.Tests.Sdk.Framework;
using Xunit;

namespace FluentSpecification.Tests.Sdk
{
    public abstract partial class ComplexSpecificationTests<T>
    {
        [Theory]
        [Trait("Category", "IsSatisfiedBy")]
        [CorrectData]
        public void IsSatisfiedBy_ValidCandidate_ReturnTrue<TCandidate>(SpecificationTestCaseData<TCandidate, SpecificationFactory<TCandidate>> data)
        {
            var sut = CreateSpecification(data.Factory);
            Assert_IsSatisfiedBy_True(sut, data.Candidate);
        }

        [Theory]
        [Trait("Category", "IsSatisfiedBy")]
        [IncorrectData]
        public void IsSatisfiedBy_InvalidCandidate_ReturnFalse<TCandidate>(SpecificationTestCaseData<TCandidate, SpecificationFactory<TCandidate>> data)
        {
            var sut = CreateSpecification(data.Factory);
            Assert_IsSatisfiedBy_False(sut, data.Candidate);
        }

        [Theory]
        [Trait("Category", "IsSatisfiedBy")]
        [CorrectData]
        public void IsSatisfiedBy_ValidCandidate_ReturnExpectedResultObject<TCandidate>(ValidationSpecificationTestCaseData<TCandidate, SpecificationFactory<TCandidate>> data)
        {
            var sut = CreateSpecification(data.Factory);
            Assert_IsSatisfiedByValidation_True(sut, data.Candidate, data.ExpectedResult);
        }

        [Theory]
        [Trait("Category", "IsSatisfiedBy")]
        [IncorrectData]
        public void IsSatisfiedBy_InvalidCandidate_ReturnExpectedResultObject<TCandidate>(ValidationSpecificationTestCaseData<TCandidate, SpecificationFactory<TCandidate>> data)
        {
            var sut = CreateSpecification(data.Factory);
            Assert_IsSatisfiedByValidation_False(sut, data.Candidate, data.ExpectedResult);
        }
    }
}
