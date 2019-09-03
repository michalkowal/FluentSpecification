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
        public class IsNotSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(EmptyData), AsNegation = true)]
            public void NotEmptyCandidate_ReturnTrue<T>(T candidate)
            {
                var sut = new EmptySpecification<T>();

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EmptyData), AsNegation = true)]
            public void EmptyCandidate_ReturnFalse<T>(T candidate)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EmptySpecification<T>();

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void Nullable_ReturnFalse()
            {
                var sut = new EmptySpecification<int?>();

                var result = sut.IsNotSatisfiedBy(null);

                Assert.False(result);
            }

            [Fact]
            public void Nullable_ReturnTrue()
            {
                var sut = new EmptySpecification<int?>();

                var result = sut.IsNotSatisfiedBy(0);

                Assert.True(result);
            }

            [Fact]
            public void NullCollectionLinqToEntities_Exception()
            {
                var sut = new EmptySpecification<int[]>(true);
                var exception = Record.Exception(() => sut.IsNotSatisfiedBy(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(EmptyData), AsNegation = true)]
            public void NotEmptyCandidate_ReturnExpectedResultObject<T>(T candidate, SpecificationResult expected)
            {
                var sut = new EmptySpecification<T>();

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(EmptyData), AsNegation = true)]
            public void EmptyCandidate_ReturnExpectedResultObject<T>(T candidate, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EmptySpecification<T>();

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }

            [Fact]
            public void EmptyNullable_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult("NotEmptySpecification<Nullable<Int32>>");
                var sut = new EmptySpecification<int?>();

                var overall = sut.IsNotSatisfiedBy(0, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NotEmptyNullable_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(false, "NotEmptySpecification<Nullable<Int32>>+Failed",
                    new SpecificationInfo(typeof(EmptySpecification<int?>), (object) null, "Object is empty"));
                var sut = new EmptySpecification<int?>();

                var overall = sut.IsNotSatisfiedBy(null, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCollectionLinqToEntities_Exception()
            {
                var sut = new EmptySpecification<int[]>(true);
                var exception = Record.Exception(() => sut.IsNotSatisfiedBy(null, out _));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}