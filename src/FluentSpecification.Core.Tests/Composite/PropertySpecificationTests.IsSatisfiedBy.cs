using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    public partial class PropertySpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(PropertyData))]
            public void TrueSpecification_ReturnTrue<T>(FakeType candidate, Expression<Func<FakeType, T>> selector)
            {
                var specification = MockSpecification<T>.True();
                var sut = new PropertySpecification<FakeType, T>(selector, specification);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(PropertyData))]
            public void FalseSpecification_ReturnFalse<T>(FakeType candidate, Expression<Func<FakeType, T>> selector)
            {
                candidate = candidate.Second != "null" ? candidate : null;
                var specification = MockSpecification<T>.False();
                var sut = new PropertySpecification<FakeType, T>(selector, specification);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void RelatedTypes_NoException()
            {
                var specification = MockSpecification<IEnumerable<char>>.True();
                var exception = Record.Exception(() =>
                {
                    var sut = new PropertySpecification<FakeType, string>(
                        ft => ft.Second, specification);
                    sut.IsSatisfiedBy(new FakeType());
                });

                Assert.Null(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(PropertyData))]
            public void TrueSpecification_ReturnExpectedResultObject<T>(FakeType candidate,
                Expression<Func<FakeType, T>> selector, SpecificationResult expected)
            {
                ISpecification<T> specification = MockComplexSpecification<T>.True();
                var sut = new PropertySpecification<FakeType, T>(selector, specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(
                    parameters: new Dictionary<string, object>
                    {
                        {"PropertySpecification", specification}
                    }));
            }

            [Theory]
            [IncorrectValidationData(typeof(PropertyData))]
            public void FalseSpecification_ReturnExpectedResultObject<T>(FakeType candidate,
                Expression<Func<FakeType, T>> selector, SpecificationResult expected)
            {
                candidate = candidate.Second != "null" ? candidate : null;
                ISpecification<T> specification = MockComplexSpecification<T>.False();
                var sut = new PropertySpecification<FakeType, T>(selector, specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(
                    parameters: new Dictionary<string, object>
                    {
                        {"PropertySpecification", specification}
                    }));
            }

            [Fact]
            public void RelatedTypes_NoException()
            {
                var specification = MockSpecification<IEnumerable<char>>.True();
                var exception = Record.Exception(() =>
                {
                    var sut = new PropertySpecification<FakeType, string>(
                        ft => ft.Second, specification);
                    sut.IsSatisfiedBy(new FakeType(), out _);
                });

                Assert.Null(exception);
            }
        }
    }
}