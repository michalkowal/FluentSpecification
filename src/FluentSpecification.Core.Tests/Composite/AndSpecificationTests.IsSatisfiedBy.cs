using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    public partial class AndSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(AndData))]
            public void CorrectData_ReturnTrue(bool leftResult, bool rightResult)
            {
                var left = MockSpecification.Create(leftResult);
                var right = MockSpecification.Create(rightResult);
                var sut = new AndSpecification<object>(left, right);

                var result = sut.IsSatisfiedBy(new object());

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(AndData))]
            public void IncorrectData_ReturnFalse(bool leftResult, bool rightResult)
            {
                var left = MockSpecification.Create(leftResult);
                var right = MockSpecification.Create(rightResult);
                var sut = new AndSpecification<object>(left, right);

                var result = sut.IsSatisfiedBy(new object());

                Assert.False(result);
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var left = MockSpecification.True();
                var right = MockSpecification.True();
                var sut = new AndSpecification<object>(left, right);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.Null(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(AndData))]
            public void CorrectData_ReturnExpectedResultObject(bool leftResult, bool rightResult,
                SpecificationResult expected)
            {
                var left = MockValidationSpecification.Create(leftResult);
                var right = MockValidationSpecification.Create(rightResult);
                var sut = new AndSpecification<object>(left, right);

                var overall = sut.IsSatisfiedBy(new object(), out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(AndData))]
            public void IncorrectData_ReturnExpectedResultObject(bool leftResult, bool rightResult,
                SpecificationResult expected)
            {
                var left = MockValidationSpecification.Create(leftResult);
                var right = MockValidationSpecification.Create(rightResult);
                var sut = new AndSpecification<object>(left, right);
                var dum = new object();

                var overall = sut.IsSatisfiedBy(dum, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(dum));
            }

            [Fact]
            public void CompositeRight_GroupingTraceMessage()
            {
                var left = MockValidationSpecification.True();
                var right = new OrSpecification<object>(MockValidationSpecification.True(),
                    MockValidationSpecification.True());
                var sut = new AndSpecification<object>(left, right);

                sut.IsSatisfiedBy(new object(), out var result);

                Assert.Equal(
                    "TrueMockValidationSpecification And (TrueMockValidationSpecification Or TrueMockValidationSpecification)",
                    result.Trace);
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var left = MockValidationSpecification.True();
                var right = MockValidationSpecification.True();
                var sut = new AndSpecification<object>(left, right);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

                Assert.Null(exception);
            }
        }
    }
}