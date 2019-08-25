using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class GreaterThanSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(GreaterThanData))]
            public void GreaterThanCandidate_ReturnTrue<T>(T candidate, T greaterThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new GreaterThanSpecification<T>(greaterThan, comparer);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(GreaterThanData))]
            public void NotGreaterThanCandidate_ReturnFalse<T>(T candidate, T greaterThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new GreaterThanSpecification<T>(greaterThan, comparer);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(GreaterThanNullableData))]
            public void NullableCandidate_ReturnTrue(int? candidate, int? greaterThan)
            {
                var sut = new GreaterThanSpecification<int?>(greaterThan);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(GreaterThanNullableData))]
            public void NullableCandidate_ReturnFalse(int? candidate, int? greaterThan)
            {
                var sut = new GreaterThanSpecification<int?>(greaterThan);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(GreaterThanData))]
            public void GreaterThanIntCandidate_ReturnExpectedResultObject<T>(T candidate, T greaterThan,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new GreaterThanSpecification<T>(greaterThan, comparer);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(GreaterThanData))]
            public void NotGreaterThanCandidate_ReturnExpectedResultObject<T>(T candidate, T greaterThan,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new GreaterThanSpecification<T>(greaterThan, comparer);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }

            [Theory]
            [CorrectValidationData(typeof(GreaterThanNullableData))]
            public void CorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? greaterThan,
                SpecificationResult expected)
            {
                var sut = new GreaterThanSpecification<int?>(greaterThan);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(GreaterThanNullableData))]
            public void IncorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? greaterThan,
                SpecificationResult expected)
            {
                var sut = new GreaterThanSpecification<int?>(greaterThan);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}