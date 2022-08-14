using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using System;
using System.Collections.Generic;
using Xunit;

namespace FluentSpecification.Core.Tests
{
    public partial class TranslatableSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Fact]
            public void FalseSpecification_ReturnFalse()
            {
                var specification = MockSpecification.False();
                var sut = new TranslatableSpecification<object>(specification, "Message");

                var result = sut.IsSatisfiedBy(new object());

                Assert.False(result);
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var specification = MockSpecification.True();
                var sut = new TranslatableSpecification<object>(specification, "Message");

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.Null(exception);
            }

            [Fact]
            public void TrueSpecification_ReturnTrue()
            {
                var specification = MockSpecification.True();
                var sut = new TranslatableSpecification<object>(specification, "Message");

                var result = sut.IsSatisfiedBy(new object());

                Assert.True(result);
            }

            [Fact]
            public void RelatedTypes_NoException()
            {
                var specification = MockSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new TranslatableSpecification<ChildFakeType>(specification, "Message");
                    sut.IsSatisfiedBy(new ChildFakeType());
                });

                Assert.Null(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(TranslatableData))]
            public void TrueSpecification_ReturnExpectedResultObject(string message, SpecificationResult expected)
            {
                var specification = MockValidationSpecification.True();
                var sut = new TranslatableSpecification<object>(specification, message);

                var overall = sut.IsSatisfiedBy(new object(), out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(TranslatableData))]
            public void FalseSpecification_ReturnExpectedResultObject(string message, SpecificationResult expected)
            {
                var dum = new object();
                var specification = MockValidationSpecification.False();
                var sut = new TranslatableSpecification<object>(specification, message);

                var overall = sut.IsSatisfiedBy(dum, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(dum));
            }

            [Theory]
            [IncorrectValidationData(typeof(TranslatableWithFactoryData))]
            public void FalseSpecificationWithMessageFactory_ReturnExpectedResultObject(int candidate, Func<int, string> messageFactory, SpecificationResult expected)
            {
                var specification = MockValidationSpecification<int>.False();
                var sut = new TranslatableSpecification<int>(specification, messageFactory);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }

            [Theory]
            [IncorrectValidationData(typeof(TranslatableWithFactoryAndParametersData))]
            public void FalseSpecificationWithMessageFactoryAndParameters_ReturnExpectedResultObject(int candidate,
                Func<int, IReadOnlyDictionary<string, object>, string> messageFactory, SpecificationResult expected)
            {
                var specification = MockValidationSpecification<int>.False();
                var sut = new TranslatableSpecification<int>(specification, messageFactory);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }

            [Theory]
            [CorrectValidationData(typeof(TranslatableCompositeData))]
            public void TrueCompositeSpecification_ReturnExpectedResultObject(string message, SpecificationResult expected)
            {
                var specification = MockCompositeSpecification.True();
                var sut = new TranslatableSpecification<object>(specification, message);

                var overall = sut.IsSatisfiedBy(new object(), out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(TranslatableCompositeData))]
            public void FalseCompositeSpecification_ReturnExpectedResultObject(string message, SpecificationResult expected)
            {
                var dum = new object();
                var specification = MockCompositeSpecification.False();
                var sut = new TranslatableSpecification<object>(specification, message);

                var overall = sut.IsSatisfiedBy(dum, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(dum));
            }

            [Theory]
            [CorrectData(typeof(TranslatableData))]
            public void NullCandidate_NoException(string message)
            {
                var specification = MockValidationSpecification.True();
                var sut = new TranslatableSpecification<object>(specification, message);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedTypes_NoException()
            {
                var specification = MockValidationSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new TranslatableSpecification<ChildFakeType>(specification, "Message");
                    sut.IsSatisfiedBy(new ChildFakeType(), out _);
                });

                Assert.Null(exception);
            }
        }
    }
}
