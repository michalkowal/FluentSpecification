﻿using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests
{
    public partial class SpecificationAdapterTests
    {
        public class IsSatisfiedBy
        {
            [Fact]
            public void FalseSpecification_ReturnFalse()
            {
                var specification = MockSpecification.False();
                var sut = new SpecificationAdapter<object>(specification);

                var result = sut.IsSatisfiedBy(new object());

                Assert.False(result);
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var specification = MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.Null(exception);
            }

            [Fact]
            public void TrueSpecification_ReturnTrue()
            {
                var specification = MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var result = sut.IsSatisfiedBy(new object());

                Assert.True(result);
            }

            [Fact]
            public void RelatedTypes_NoException()
            {
                var specification = MockSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new SpecificationAdapter<ChildFakeType>(specification);
                    sut.IsSatisfiedBy(new ChildFakeType());
                });

                Assert.Null(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(AdapterData))]
            public void TrueSpecification_ReturnExpectedResultObject(bool isValidable, SpecificationResult expected)
            {
                var dum = new object();
                var specification = isValidable ? MockValidationSpecification.True() : MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var overall = sut.IsSatisfiedBy(dum, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(dum));
            }

            [Theory]
            [IncorrectValidationData(typeof(AdapterData))]
            public void FalseSpecification_ReturnExpectedResultObject(bool isValidable, SpecificationResult expected)
            {
                var dum = new object();
                var specification = isValidable ? MockValidationSpecification.False() : MockSpecification.False();
                var sut = new SpecificationAdapter<object>(specification);

                var overall = sut.IsSatisfiedBy(dum, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(dum));
            }

            [Theory]
            [CorrectData(typeof(AdapterData))]
            public void NullCandidate_NoException(bool isValidable)
            {
                var specification = isValidable ? MockValidationSpecification.True() : MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedTypes_NoException()
            {
                var specification = MockSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new SpecificationAdapter<ChildFakeType>(specification);
                    sut.IsSatisfiedBy(new ChildFakeType(), out _);
                });

                Assert.Null(exception);
            }

            [Fact]
            public void RelatedValidableTypes_NoException()
            {
                var specification = MockValidationSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new SpecificationAdapter<ChildFakeType>(specification);
                    sut.IsSatisfiedBy(new ChildFakeType(), out _);
                });

                Assert.Null(exception);
            }
        }
    }
}