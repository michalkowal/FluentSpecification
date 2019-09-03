using System;
using System.Collections;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class LengthBetweenSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(LengthBetweenData))]
            public void ValidCandidate_ReturnTrue<T>(T candidate, int minLength, int maxLength)
                where T : IEnumerable
            {
                var sut = new LengthBetweenSpecification<T>(minLength, maxLength);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LengthBetweenData))]
            public void InvalidCandidate_ReturnFalse<T>(T candidate, int minLength, int maxLength)
                where T : IEnumerable
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new LengthBetweenSpecification<T>(minLength, maxLength);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NullCollectionLinqToEntities_Exception()
            {
                var sut = new LengthBetweenSpecification<int[]>(0, 0, true);
                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(LengthBetweenData))]
            public void ValidCandidate_ReturnExpectedResultObject<T>(T candidate, int minLength, int maxLength,
                SpecificationResult expected)
                where T : IEnumerable
            {
                var sut = new LengthBetweenSpecification<T>(minLength, maxLength);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(LengthBetweenData))]
            public void InvalidCandidate_ReturnExpectedResultObject<T>(T candidate, int minLength, int maxLength,
                SpecificationResult expected)
                where T : IEnumerable
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new LengthBetweenSpecification<T>(minLength, maxLength);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCollectionLinqToEntities_Exception()
            {
                var sut = new LengthBetweenSpecification<int[]>(0, 0, true);
                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}