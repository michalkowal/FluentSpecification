using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class LessThanSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(LessThanData))]
            public void LessThanCandidate_ReturnTrue<T>(T candidate, T lessThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new LessThanSpecification<T>(lessThan, comparer);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LessThanData))]
            public void NotLessThanCandidate_ReturnFalse<T>(T candidate, T lessThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new LessThanSpecification<T>(lessThan, comparer);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(LessThanNullableData))]
            public void NullableCandidate_ReturnTrue(int? candidate, int? lessThan)
            {
                var sut = new LessThanSpecification<int?>(lessThan);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LessThanNullableData))]
            public void NullableCandidate_ReturnFalse(int? candidate, int? lessThan)
            {
                var sut = new LessThanSpecification<int?>(lessThan);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(LessThanData))]
            public void LessThanCandidate_ReturnExpectedResultObject<T>(T candidate, T lessThan, IComparer<T> comparer,
                SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new LessThanSpecification<T>(lessThan, comparer);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(LessThanData))]
            public void NotLessThanCandidate_ReturnExpectedResultObject<T>(T candidate, T lessThan,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new LessThanSpecification<T>(lessThan, comparer);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }

            [Theory]
            [CorrectValidationData(typeof(LessThanNullableData))]
            public void CorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? lessThan,
                SpecificationResult expected)
            {
                var sut = new LessThanSpecification<int?>(lessThan);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(LessThanNullableData))]
            public void IncorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? lessThan,
                SpecificationResult expected)
            {
                var sut = new LessThanSpecification<int?>(lessThan);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}