using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests
{
    public partial class ComplexSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(ComplexData))]
            public void CorrectData_ReturnTrue<T>(T candidate)
            {
                var sut = new MockCommonSpecification<T>();

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(ComplexData))]
            public void IncorrectData_ReturnFalse<T>(T candidate)
            {
                var sut = new MockCommonSpecification<T>();

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void Nullable_ReturnFalse()
            {
                var sut = new MockCommonSpecification<int?>();

                var result = sut.IsSatisfiedBy(0);

                Assert.False(result);
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var sut = new MockCommonSpecification<object>();

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.Null(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(ComplexData))]
            public void CorrectData_ReturnExpectedResultObject<T>(T candidate, SpecificationResult expected)
            {
                var sut = new MockCommonSpecification<T>();

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(ComplexData))]
            public void IncorrectData_ReturnExpectedResultObject<T>(T candidate, SpecificationResult expected)
            {
                var sut = new MockCommonSpecification<T>();

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void Nullable_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(false, "MockCommonSpecification<Nullable<Int32>>+Failed",
                    new FailedSpecification(typeof(MockCommonSpecification<int?>), 0, "Not match"));
                var sut = new MockCommonSpecification<int?>();

                var overall = sut.IsSatisfiedBy(0, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var sut = new MockCommonSpecification<object>();

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

                Assert.Null(exception);
            }
        }
    }
}