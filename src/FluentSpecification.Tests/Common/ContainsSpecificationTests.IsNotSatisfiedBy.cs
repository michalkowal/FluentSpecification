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
        public class IsNotSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(ContainsData), AsNegation = true)]
            public void NotContainsElementsValid_ReturnTrue<T, TType>(T candidate, TType expected,
                IEqualityComparer<TType> comparer)
                where T : IEnumerable<TType>
            {
                expected = expected?.ToString() != "null" ? expected : default;
                var sut = new ContainsSpecification<T, TType>(expected, comparer);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(ContainsData), AsNegation = true)]
            public void ContainsElementsValid_ReturnFalse<T, TType>(T candidate, TType expected,
                IEqualityComparer<TType> comparer)
                where T : IEnumerable<TType>
            {
                expected = expected?.ToString() != "null" ? expected : default;
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new ContainsSpecification<T, TType>(expected, comparer);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void ContainsChildTypeElement_ReturnFalse()
            {
                var expected = new ComparableFakeType();
                var candidate = new[] {new FakeType(), expected, null};
                var sut = new ContainsSpecification<FakeType[], FakeType>(expected);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NullCollectionLinqToEntities_Exception()
            {
                var sut = new ContainsSpecification<int[], int>(0, null, true);
                var exception = Record.Exception(() => sut.IsNotSatisfiedBy(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(ContainsData), AsNegation = true)]
            public void NotContainsElementsValid_ReturnExpectedResultObject<T, TType>(T candidate, TType expected,
                IEqualityComparer<TType> comparer, SpecificationResult expResult)
                where T : IEnumerable<TType>
            {
                expected = expected?.ToString() != "null" ? expected : default;
                var sut = new ContainsSpecification<T, TType>(expected, comparer);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(ContainsData), AsNegation = true)]
            public void ContainsElementsValid_ReturnExpectedResultObject<T, TType>(T candidate, TType expected,
                IEqualityComparer<TType> comparer, SpecificationResult expResult)
                where T : IEnumerable<TType>
            {
                expected = expected?.ToString() != "null" ? expected : default;
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new ContainsSpecification<T, TType>(expected, comparer);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Fact]
            public void ContainsChildTypeElement_ReturnExpectedResultObject()
            {
                var expected = new ComparableFakeType();
                var candidate = new[] {new FakeType(), expected, null};
                var expResult = new SpecificationResult(false, "NotContainsSpecification<FakeType[],FakeType>+Failed",
                    new SpecificationInfo(typeof(ContainsSpecification<FakeType[], FakeType>),
                        new Dictionary<string, object>
                        {
                            {"Expected", expected}
                        }, candidate, "Collection contains [Fake(0)]"));
                var sut = new ContainsSpecification<FakeType[], FakeType>(expected);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCollectionLinqToEntities_Exception()
            {
                var sut = new ContainsSpecification<int[], int>(0, null, true);
                var exception = Record.Exception(() => sut.IsNotSatisfiedBy(null, out _));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}