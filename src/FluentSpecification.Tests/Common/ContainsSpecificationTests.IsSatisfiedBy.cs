using System;
using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class ContainsSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(ContainsData))]
            public void ContainsElementsValid_ReturnTrue<T, TType>(T candidate, TType expected,
                IEqualityComparer<TType> comparer)
                where T : IEnumerable<TType>
            {
                expected = expected?.ToString() != "null" ? expected : default;
                var sut = new ContainsSpecification<T, TType>(expected, comparer);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(ContainsData))]
            public void NotContainsElementsValid_ReturnFalse<T, TType>(T candidate, TType expected,
                IEqualityComparer<TType> comparer)
                where T : IEnumerable<TType>
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new ContainsSpecification<T, TType>(expected, comparer);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void ContainsChildTypeElement_ReturnTrue()
            {
                var expected = new ComparableFakeType();
                var candidate = new[] {new FakeType(), expected, null};
                var sut = new ContainsSpecification<FakeType[], FakeType>(expected);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Fact]
            public void NullCollectionLinqToEntities_Exception()
            {
                var sut = new ContainsSpecification<int[], int>(0, null, true);
                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(ContainsData))]
            public void ContainsElementsValid_ReturnExpectedResultObject<T, TType>(T candidate, TType expected,
                IEqualityComparer<TType> comparer, SpecificationResult expResult)
                where T : IEnumerable<TType>
            {
                expected = expected?.ToString() != "null" ? expected : default;
                var sut = new ContainsSpecification<T, TType>(expected, comparer);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(ContainsData))]
            public void NotContainsElementsValid_ReturnExpectedResultObject<T, TType>(T candidate, TType expected,
                IEqualityComparer<TType> comparer, SpecificationResult expResult)
                where T : IEnumerable<TType>
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new ContainsSpecification<T, TType>(expected, comparer);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Fact]
            public void ContainsChildTypeElement_ReturnExpectedResultObject()
            {
                var expResult = new SpecificationResult("ContainsSpecification<FakeType[],FakeType>");
                var expected = new ComparableFakeType();
                var candidate = new[] {new FakeType(), expected, null};
                var sut = new ContainsSpecification<FakeType[], FakeType>(expected);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCollectionLinqToEntities_Exception()
            {
                var sut = new ContainsSpecification<int[], int>(0, null, true);
                var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}