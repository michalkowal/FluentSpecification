using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class EmailSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(EmailData))]
            public void ValidCandidate_ReturnTrue(string candidate)
            {
                var sut = new EmailSpecification();

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EmailData))]
            public void InvalidCandidate_ReturnFalse(string candidate)
            {
                var sut = new EmailSpecification();

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(EmailData))]
            public void ValidCandidate_ReturnExpectedResultObject(string candidate, SpecificationResult expected)
            {
                var sut = new EmailSpecification();

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(EmailData))]
            public void InvalidCandidate_ReturnExpectedResultObject(string candidate, SpecificationResult expected)
            {
                var sut = new EmailSpecification();

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }
        }
    }
}