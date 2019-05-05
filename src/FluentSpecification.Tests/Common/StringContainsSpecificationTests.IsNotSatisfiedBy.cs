using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class StringContainsSpecificationTests
    {
        public class IsNotSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(StringContainsData), AsNegation = true)]
            public void ValidCandidate_ReturnTrue(string candidate, string expected)
            {
                var sut = new ContainsSpecification(expected);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(StringContainsData), AsNegation = true)]
            public void InvalidCandidate_ReturnFalse(string candidate, string expected)
            {
                var sut = new ContainsSpecification(expected);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(StringContainsData), AsNegation = true)]
            public void ValidCandidate_ReturnExpectedResultObject(string candidate, string expected,
                SpecificationResult expResult)
            {
                var sut = new ContainsSpecification(expected);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(StringContainsData), AsNegation = true)]
            public void InvalidCandidate_ReturnExpectedResultObject(string candidate, string expected,
                SpecificationResult expResult)
            {
                var sut = new ContainsSpecification(expected);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer(candidate));
            }
        }
    }
}