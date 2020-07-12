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
            [Fact]
            public void CorrectData_ReturnTrue()
            {
                var specification = MockComplexSpecification.False();
                var sut = new NotSpecification<object>(specification);

                var result = sut.IsSatisfiedBy(new object());

                Assert.True(result);
            }

            [Fact]
            public void CorrectNegatableData_ReturnTrue()
            {
                var specification = MockNegatableComplexSpecification.False();
                var sut = new NotSpecification<object>(specification);

                var result = sut.IsSatisfiedBy(new object());

                Assert.True(result);
            }

            [Fact]
            public void IncorrectData_ReturnFalse()
            {
                var specification = MockComplexSpecification.True();
                var sut = new NotSpecification<object>(specification);

                var result = sut.IsSatisfiedBy(new object());

                Assert.False(result);
            }

            [Fact]
            public void IncorrectNegatableData_ReturnFalse()
            {
                var specification = MockNegatableComplexSpecification.True();
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
            public void CorrectData_ReturnExpectedResultObject(SpecificationResult expected)
            {
                var specification = MockComplexSpecification.False();
                var sut = new NotSpecification<object>(specification);
                var dum = new object();

                var overall = sut.IsSatisfiedBy(dum, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(dum));
            }

            [Theory]
            [CorrectValidationData(typeof(NotData), AsNegation = true)]
            public void CorrectNegatableData_ReturnExpectedResultObject(SpecificationResult expected)
            {
                var specification = MockNegatableComplexSpecification.False();
                var sut = new NotSpecification<object>(specification);
                var dum = new object();

                var overall = sut.IsSatisfiedBy(dum, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(dum));
            }

            [Theory]
            [IncorrectValidationData(typeof(NotData))]
            public void IncorrectData_ReturnExpectedResultObject(SpecificationResult expected)
            {
                var specification = MockComplexSpecification.True();
                var sut = new NotSpecification<object>(specification);
                var dum = new object();

                var overall = sut.IsSatisfiedBy(dum, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(dum));
            }

            [Theory]
            [IncorrectValidationData(typeof(NotData), AsNegation = true)]
            public void IncorrectNegatableData_ReturnExpectedResultObject(SpecificationResult expected)
            {
                var specification = MockNegatableComplexSpecification.True();
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