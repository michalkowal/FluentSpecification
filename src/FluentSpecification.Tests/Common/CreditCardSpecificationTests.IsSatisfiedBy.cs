using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class CreditCardSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(CreditCardData))]
            public void ValidCandidate_ReturnTrue(string candidate)
            {
                var sut = new CreditCardSpecification();

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(CreditCardData))]
            public void InvalidCandidate_ReturnFalse(string candidate)
            {
                var sut = new CreditCardSpecification();

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(CreditCardData))]
            public void ValidCandidate_ReturnExpectedResultObject(string candidate, SpecificationResult expected)
            {
                var sut = new CreditCardSpecification();

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(CreditCardData))]
            public void InvalidCandidate_ReturnExpectedResultObject(string candidate, SpecificationResult expected)
            {
                var sut = new CreditCardSpecification();

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }
        }
    }
}