using System;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class EmptySpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(EmptyData))]
            public void EmptyCandidate_ReturnTrue<T>(T candidate)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new EmptySpecification<T>();

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EmptyData))]
            public void NotEmptyCandidate_ReturnFalse<T>(T candidate)
            {
                var sut = new EmptySpecification<T>();

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void Nullable_ReturnFalse()
            {
                var sut = new EmptySpecification<int?>();

                var result = sut.IsSatisfiedBy(0);

                Assert.False(result);
            }

            [Fact]
            public void Nullable_ReturnTrue()
            {
                var sut = new EmptySpecification<int?>();

                var result = sut.IsSatisfiedBy(null);

                Assert.True(result);
            }

            [Fact]
            public void NullCollectionLinqToEntities_Exception()
            {
                var sut = new EmptySpecification<int[]>(true);
                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(EmptyData))]
            public void EmptyCandidate_ReturnExpectedResultObject<T>(T candidate, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new EmptySpecification<T>();

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(EmptyData))]
            public void NotEmptyCandidate_ReturnExpectedResultObject<T>(T candidate, SpecificationResult expected)
            {
                var sut = new EmptySpecification<T>();

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }

            [Fact]
            public void EmptyNullable_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult("EmptySpecification<Nullable<Int32>>");
                var sut = new EmptySpecification<int?>();

                var overall = sut.IsSatisfiedBy(null, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NotEmptyNullable_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(false, "EmptySpecification<Nullable<Int32>>+Failed",
                    new FailedSpecification(typeof(EmptySpecification<int?>), 0, "Object is not empty"));
                var sut = new EmptySpecification<int?>();

                var overall = sut.IsSatisfiedBy(0, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCollectionLinqToEntities_Exception()
            {
                var sut = new EmptySpecification<int[]>(true);
                var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}