using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    public partial class OrSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(OrData))]
            public void CorrectData_ReturnTrue(bool leftResult, bool rightResult)
            {
                var left = MockSpecification.Create(leftResult);
                var right = MockSpecification.Create(rightResult);
                var sut = new OrSpecification<object>(left, right);

                var result = sut.IsSatisfiedBy(new object());

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(OrData))]
            public void IncorrectData_ReturnFalse(bool leftResult, bool rightResult)
            {
                var left = MockSpecification.Create(leftResult);
                var right = MockSpecification.Create(rightResult);
                var sut = new OrSpecification<object>(left, right);

                var result = sut.IsSatisfiedBy(new object());

                Assert.False(result);
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var left = MockSpecification.True();
                var right = MockSpecification.True();
                var sut = new OrSpecification<object>(left, right);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedTypes_NoException()
            {
                var left = MockSpecification<IEnumerable<char>>.True();
                var right = MockSpecification<ChildFakeType>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new OrSpecification<ChildFakeType>(left, right);
                    sut.IsSatisfiedBy(new ChildFakeType());
                });

                Assert.Null(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(OrData))]
            public void CorrectData_ReturnExpectedResultObject(bool leftResult, bool rightResult,
                SpecificationResult expected)
            {
                var left = MockValidationSpecification.Create(leftResult);
                var right = MockValidationSpecification.Create(rightResult);
                var sut = new OrSpecification<object>(left, right);
                var dum = new object();

                var overall = sut.IsSatisfiedBy(dum, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(dum));
            }

            [Theory]
            [IncorrectValidationData(typeof(OrData))]
            public void IncorrectData_ReturnExpectedResultObject(bool leftResult, bool rightResult,
                SpecificationResult expected)
            {
                var left = MockValidationSpecification.Create(leftResult);
                var right = MockValidationSpecification.Create(rightResult);
                var sut = new OrSpecification<object>(left, right);
                var dum = new object();

                var overall = sut.IsSatisfiedBy(dum, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(dum));
            }

            [Fact]
            public void CompositeRight_GroupingTraceMessage()
            {
                var left = MockValidationSpecification.True();
                var right = new AndSpecification<object>(MockValidationSpecification.True(),
                    MockValidationSpecification.True());
                var sut = new OrSpecification<object>(left, right);

                sut.IsSatisfiedBy(new object(), out var result);

                Assert.Equal(
                    "TrueMockValidationSpecification Or (TrueMockValidationSpecification And TrueMockValidationSpecification)",
                    result.Trace.FullTrace);
                Assert.Equal(
                    "TrueMockValidation Or (TrueMockValidation And TrueMockValidation)",
                    result.Trace.ShortTrace);
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var left = MockValidationSpecification.True();
                var right = MockValidationSpecification.True();
                var sut = new OrSpecification<object>(left, right);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedTypes_NoException()
            {
                var left = MockSpecification<IEnumerable<char>>.True();
                var right = MockSpecification<ChildFakeType>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new OrSpecification<ChildFakeType>(left, right);
                    sut.IsSatisfiedBy(new ChildFakeType(), out _);
                });

                Assert.Null(exception);
            }
        }
    }
}