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
        public class IsNotSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(EqualData), AsNegation = true)]
            public void NotEqualCandidate_ReturnTrue<T>(T candidate, T expected, IEqualityComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EqualSpecification<T>(expected, comparer);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EqualData), AsNegation = true)]
            public void EqualCandidate_ReturnFalse<T>(T candidate, T expected, IEqualityComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EqualSpecification<T>(expected, comparer);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(EqualNullableData), AsNegation = true)]
            public void NullableCandidate_ReturnTrue(int? candidate, int? expected)
            {
                var sut = new EqualSpecification<int?>(expected);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EqualNullableData), AsNegation = true)]
            public void NullableCandidate_ReturnFalse(int? candidate, int? expected)
            {
                var sut = new EqualSpecification<int?>(expected);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(EqualData), AsNegation = true)]
            public void NotEqualCandidate_ReturnExpectedResultObject<T>(T candidate, T expected,
                IEqualityComparer<T> comparer, SpecificationResult expResult)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EqualSpecification<T>(expected, comparer);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(EqualData), AsNegation = true)]
            public void EqualCandidate_ReturnExpectedResultObject<T>(T candidate, T expected,
                IEqualityComparer<T> comparer, SpecificationResult expResult)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EqualSpecification<T>(expected, comparer);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Theory]
            [CorrectValidationData(typeof(EqualNullableData), AsNegation = true)]
            public void CorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? expected,
                SpecificationResult expResult)
            {
                var sut = new EqualSpecification<int?>(expected);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(EqualNullableData), AsNegation = true)]
            public void IncorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? expected,
                SpecificationResult expResult)
            {
                var sut = new EqualSpecification<int?>(expected);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expResult, result, new SpecificationResultComparer());
            }
        }
    }
}