using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests
{
    public partial class SpecificationAdapterTests
    {
        public class IsNotSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(AdapterData), AsNegation = true)]
            public void FalseSpecification_ReturnTrue(bool isNegatable)
            {
                var specification = isNegatable ? MockNegatableSpecification.False() : MockSpecification.False();
                var sut = new SpecificationAdapter<object>(specification);

                var result = sut.IsNotSatisfiedBy(new object());

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(AdapterData), AsNegation = true)]
            public void TrueSpecification_ReturnFalse(bool isNegatable)
            {
                var specification = isNegatable ? MockNegatableSpecification.True() : MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var result = sut.IsNotSatisfiedBy(new object());

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(AdapterData), AsNegation = true)]
            public void NullCandidate_NoException(bool isNegatable)
            {
                var specification = isNegatable ? MockNegatableSpecification.True() : MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var exception = Record.Exception(() => sut.IsNotSatisfiedBy(null));

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedTypes_NoException()
            {
                var specification = MockSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new SpecificationAdapter<ChildFakeType>(specification);
                    sut.IsNotSatisfiedBy(new ChildFakeType());
                });

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedNegatableTypes_NoException()
            {
                var specification = MockNegatableSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new SpecificationAdapter<ChildFakeType>(specification);
                    sut.IsNotSatisfiedBy(new ChildFakeType());
                });

                Assert.Null(exception);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(AdapterData), AsNegation = true)]
            public void FalseSpecification_ReturnExpectedResultObject(bool isNegatable, SpecificationResult expected)
            {
                var specification =
                    isNegatable ? MockNegatableValidationSpecification.False() : MockSpecification.False();
                var sut = new SpecificationAdapter<object>(specification);

                var overall = sut.IsNotSatisfiedBy(new object(), out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(AdapterData), AsNegation = true)]
            public void TrueSpecification_ReturnExpectedResultObject(bool isNegatable, SpecificationResult expected)
            {
                var dum = new object();
                var specification =
                    isNegatable ? MockNegatableValidationSpecification.True() : MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var overall = sut.IsNotSatisfiedBy(dum, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(dum));
            }

            [Theory]
            [CorrectData(typeof(AdapterData), AsNegation = true)]
            public void NullCandidate_NoException(bool isNegatable)
            {
                var specification =
                    isNegatable ? MockNegatableValidationSpecification.True() : MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var exception = Record.Exception(() => sut.IsNotSatisfiedBy(null, out _));

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedTypes_NoException()
            {
                var specification = MockSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new SpecificationAdapter<ChildFakeType>(specification);
                    sut.IsNotSatisfiedBy(new ChildFakeType(), out _);
                });

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedNegatableTypes_NoException()
            {
                var specification = MockNegatableValidationSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new SpecificationAdapter<ChildFakeType>(specification);
                    sut.IsNotSatisfiedBy(new ChildFakeType(), out _);
                });

                Assert.Null(exception);
            }
        }
    }
}