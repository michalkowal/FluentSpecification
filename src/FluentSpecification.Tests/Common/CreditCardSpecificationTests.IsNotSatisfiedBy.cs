using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class CreditCardSpecificationTests
    {
        public class IsNotSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(CreditCardData), AsNegation = true)]
            public void ValidCandidate_ReturnTrue(string candidate)
            {
                var sut = new CreditCardSpecification();

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(CreditCardData), AsNegation = true)]
            public void InvalidCandidate_ReturnFalse(string candidate)
            {
                var sut = new CreditCardSpecification();

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(CreditCardData), AsNegation = true)]
            public void ValidCandidate_ReturnExpectedResultObject(string candidate, SpecificationResult expected)
            {
                var sut = new CreditCardSpecification();

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(CreditCardData), AsNegation = true)]
            public void InvalidCandidate_ReturnExpectedResultObject(string candidate, SpecificationResult expected)
            {
                var sut = new CreditCardSpecification();

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }
        }
    }
}