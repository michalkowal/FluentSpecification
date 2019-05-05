using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    public partial class NotSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(NotData))]
            public void CorrectData_ReturnTrue(bool isNegatable)
            {
                var specification = !isNegatable
                    ? MockComplexSpecification.False()
                    : MockNegatableComplexSpecification.False();
                var sut = new NotSpecification<object>(specification);

                var result = sut.IsSatisfiedBy(new object());

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(NotData))]
            public void IncorrectData_ReturnFalse(bool isNegatable)
            {
                var specification = !isNegatable
                    ? MockComplexSpecification.True()
                    : MockNegatableComplexSpecification.True();
                var sut = new NotSpecification<object>(specification);

                var result = sut.IsSatisfiedBy(new object());

                Assert.False(result);
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var specification = MockComplexSpecification.True();
                var sut = new NotSpecification<object>(specification);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedTypes_NoException()
            {
                var specification = MockComplexSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new NotSpecification<ChildFakeType>(specification);
                    sut.IsSatisfiedBy(new ChildFakeType());
                });

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedNegatableTypes_NoException()
            {
                var specification = MockNegatableComplexSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new NotSpecification<ChildFakeType>(specification);
                    sut.IsSatisfiedBy(new ChildFakeType());
                });

                Assert.Null(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(NotData))]
            public void CorrectData_ReturnExpectedResultObject(bool isNegatable, SpecificationResult expected)
            {
                var specification = !isNegatable
                    ? MockComplexSpecification.False()
                    : MockNegatableComplexSpecification.False();
                var sut = new NotSpecification<object>(specification);

                var overall = sut.IsSatisfiedBy(new object(), out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(NotData))]
            public void IncorrectData_ReturnExpectedResultObject(bool isNegatable, SpecificationResult expected)
            {
                var specification = !isNegatable
                    ? MockComplexSpecification.True()
                    : MockNegatableComplexSpecification.True();
                var sut = new NotSpecification<object>(specification);
                var dum = new object();

                var overall = sut.IsSatisfiedBy(dum, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(dum));
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var specification = MockComplexSpecification.True();
                var sut = new NotSpecification<object>(specification);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedTypes_NoException()
            {
                var specification = MockComplexSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new NotSpecification<ChildFakeType>(specification);
                    sut.IsSatisfiedBy(new ChildFakeType(), out _);
                });

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedNegatableTypes_NoException()
            {
                var specification = MockNegatableComplexSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new NotSpecification<ChildFakeType>(specification);
                    sut.IsSatisfiedBy(new ChildFakeType(), out _);
                });

                Assert.Null(exception);
            }
        }
    }
}