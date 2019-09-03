using System;
using System.Collections;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class MinLengthSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(MinLengthData))]
            public void ValidCandidate_ReturnTrue<T>(T candidate, int minLength)
                where T : IEnumerable
            {
                var sut = new MinLengthSpecification<T>(minLength);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(MinLengthData))]
            public void InvalidCandidate_ReturnFalse<T>(T candidate, int minLength)
                where T : IEnumerable
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new MinLengthSpecification<T>(minLength);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NullCollectionLinqToEntities_Exception()
            {
                var sut = new MinLengthSpecification<int[]>(0, true);
                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(MinLengthData))]
            public void ValidCandidate_ReturnExpectedResultObject<T>(T candidate, int minLength,
                SpecificationResult expected)
                where T : IEnumerable
            {
                var sut = new MinLengthSpecification<T>(minLength);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(MinLengthData))]
            public void InvalidCandidate_ReturnExpectedResultObject<T>(T candidate, int minLength,
                SpecificationResult expected)
                where T : IEnumerable
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new MinLengthSpecification<T>(minLength);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCollectionLinqToEntities_Exception()
            {
                var sut = new MinLengthSpecification<int[]>(0, true);
                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}