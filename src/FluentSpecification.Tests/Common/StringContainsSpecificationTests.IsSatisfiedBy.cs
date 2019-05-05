using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class StringContainsSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(StringContainsData))]
            public void ValidCandidate_ReturnTrue(string candidate, string expected)
            {
                var sut = new ContainsSpecification(expected);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(StringContainsData))]
            public void InvalidCandidate_ReturnFalse(string candidate, string expected)
            {
                var sut = new ContainsSpecification(expected);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(StringContainsData))]
            public void ValidCandidate_ReturnExpectedResultObject(string candidate, string expected,
                SpecificationResult expResult)
            {
                var sut = new ContainsSpecification(expected);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(StringContainsData))]
            public void InvalidCandidate_ReturnExpectedResultObject(string candidate, string expected,
                SpecificationResult expResult)
            {
                var sut = new ContainsSpecification(expected);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer(candidate));
            }
        }
    }
}