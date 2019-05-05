using System;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class IsTypeSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(IsTypeData))]
            public void ValidCandidate_ReturnTrue<T>(T candidate, Type expected)
            {
                var sut = new IsTypeSpecification<T>(expected);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(IsTypeData))]
            public void InvalidCandidate_ReturnFalse<T>(T candidate, Type expected)
            {
                var sut = new IsTypeSpecification<T>(expected);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(IsTypeData))]
            public void ValidCandidate_ReturnExpectedResultObject<T>(T candidate, Type expected,
                SpecificationResult expResult)
            {
                var sut = new IsTypeSpecification<T>(expected);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(IsTypeData))]
            public void InvalidCandidate_ReturnExpectedResultObject<T>(T candidate, Type expected,
                SpecificationResult expResult)
            {
                var sut = new IsTypeSpecification<T>(expected);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer(candidate));
            }
        }
    }
}