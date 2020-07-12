using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;
using FluentSpecification.Tests.Sdk.Data.Validation;
using FluentSpecification.Tests.Sdk.Framework.Negations;
using Xunit;

namespace FluentSpecification.Tests.Sdk
{
    public abstract partial class ComplexNegatableSpecificationTests<T>
    {
        [Theory]
        [Trait("Category", "IsNotSatisfiedBy")]
        [CorrectNegationData]
        public void IsNotSatisfiedBy_ValidCandidate_ReturnTrue<TCandidate>(SpecificationTestCaseData<TCandidate, NegatableSpecificationFactory<TCandidate>> data)
        {
            var sut = CreateNegatableSpecification(data.Factory);
            Assert_IsNotSatisfiedBy_True(sut, data.Candidate);
        }

        [Theory]
        [Trait("Category", "IsNotSatisfiedBy")]
        [IncorrectNegationData]
        public void IsNotSatisfiedBy_InvalidCandidate_ReturnFalse<TCandidate>(SpecificationTestCaseData<TCandidate, NegatableSpecificationFactory<TCandidate>> data)
        {
            var sut = CreateNegatableSpecification(data.Factory);
            Assert_IsNotSatisfiedBy_False(sut, data.Candidate);
        }

        [Theory]
        [Trait("Category", "IsNotSatisfiedBy")]
        [CorrectNegationData]
        public void IsNotSatisfiedBy_ValidCandidate_ReturnExpectedResultObject<TCandidate>(ValidationSpecificationTestCaseData<TCandidate, NegatableSpecificationFactory<TCandidate>> data)
        {
            var sut = CreateNegatableSpecification(data.Factory);
            Assert_IsNotSatisfiedByValidation_True(sut, data.Candidate, data.ExpectedResult);
        }

        [Theory]
        [Trait("Category", "IsNotSatisfiedBy")]
        [IncorrectNegationData]
        public void IsNotSatisfiedBy_InvalidCandidate_ReturnExpectedResultObject<TCandidate>(ValidationSpecificationTestCaseData<TCandidate, NegatableSpecificationFactory<TCandidate>> data)
        {
            var sut = CreateNegatableSpecification(data.Factory);
            Assert_IsNotSatisfiedByValidation_False(sut, data.Candidate, data.ExpectedResult);
        }
    }
}
