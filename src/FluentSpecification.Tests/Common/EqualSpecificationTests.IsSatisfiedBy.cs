using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class EqualSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(EqualData))]
            public void EqualCandidate_ReturnTrue<T>(T candidate, T expected, IEqualityComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EqualSpecification<T>(expected, comparer);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EqualData))]
            public void NotEqualCandidate_ReturnFalse<T>(T candidate, T expected, IEqualityComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EqualSpecification<T>(expected, comparer);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(EqualNullableData))]
            public void NullableCandidate_ReturnTrue(int? candidate, int? expected)
            {
                var sut = new EqualSpecification<int?>(expected);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EqualNullableData))]
            public void NullableCandidate_ReturnFalse(int? candidate, int? expected)
            {
                var sut = new EqualSpecification<int?>(expected);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(EqualData))]
            public void EqualCandidate_ReturnExpectedResultObject<T>(T candidate, T expected,
                IEqualityComparer<T> comparer, SpecificationResult expResult)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EqualSpecification<T>(expected, comparer);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(EqualData))]
            public void NotEqualCandidate_ReturnExpectedResultObject<T>(T candidate, T expected,
                IEqualityComparer<T> comparer, SpecificationResult expResult)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EqualSpecification<T>(expected, comparer);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Theory]
            [CorrectValidationData(typeof(EqualNullableData))]
            public void CorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? expected,
                SpecificationResult expResult)
            {
                var sut = new EqualSpecification<int?>(expected);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(EqualNullableData))]
            public void IncorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? expected,
                SpecificationResult expResult)
            {
                var sut = new EqualSpecification<int?>(expected);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }
        }
    }
}