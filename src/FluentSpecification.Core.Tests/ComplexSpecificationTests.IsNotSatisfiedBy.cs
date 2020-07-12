using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests
{
    public partial class ComplexSpecificationTests
    {
        public class IsNotSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(ComplexData), AsNegation = true)]
            public void CorrectData_ReturnTrue<T>(T candidate)
            {
                var sut = new MockCommonSpecification<T>();

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(ComplexData), AsNegation = true)]
            public void IncorrectData_ReturnFalse<T>(T candidate)
            {
                var sut = new MockCommonSpecification<T>();

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void Nullable_ReturnTrue()
            {
                var sut = new MockCommonSpecification<int?>();

                var result = sut.IsNotSatisfiedBy(0);

                Assert.True(result);
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var sut = new MockCommonSpecification<object>();

                var exception = Record.Exception(() => sut.IsNotSatisfiedBy(null));

                Assert.Null(exception);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(ComplexData), AsNegation = true)]
            public void TrueSpecification_ReturnExpectedResultObject<T>(T candidate, SpecificationResult expected)
            {
                var sut = new MockCommonSpecification<T>();

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(ComplexData), AsNegation = true)]
            public void IncorrectData_ReturnExpectedResultObject<T>(T candidate, SpecificationResult expected)
            {
                var sut = new MockCommonSpecification<T>();

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void Nullable_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(true, 
                    new SpecificationTrace("NotMockCommonSpecification<Nullable<Int32>>",
                    "NotMockCommon"),
                    new SpecificationInfo(true, typeof(MockCommonSpecification<int?>), true,
                        0));
                var sut = new MockCommonSpecification<int?>();

                var overall = sut.IsNotSatisfiedBy(0, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var sut = new MockCommonSpecification<object>();

                var exception = Record.Exception(() => sut.IsNotSatisfiedBy(null, out _));

                Assert.Null(exception);
            }
        }
    }
}