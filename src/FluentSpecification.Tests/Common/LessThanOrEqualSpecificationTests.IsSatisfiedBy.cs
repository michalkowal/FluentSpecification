using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class LessThanOrEqualSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(LessThanOrEqualData))]
            public void LessThanOrEqualIntCandidate_ReturnTrue<T>(T candidate, T lessThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new LessThanOrEqualSpecification<T>(lessThan, comparer);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LessThanOrEqualData))]
            public void NotLessThanOrEqualCandidate_ReturnFalse<T>(T candidate, T lessThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new LessThanOrEqualSpecification<T>(lessThan, comparer);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(LessThanOrEqualNullableData))]
            public void NullableCandidate_ReturnTrue(int? candidate, int? lessThan)
            {
                var sut = new LessThanOrEqualSpecification<int?>(lessThan);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LessThanOrEqualNullableData))]
            public void NullableCandidate_ReturnFalse(int? candidate, int? lessThan)
            {
                var sut = new LessThanOrEqualSpecification<int?>(lessThan);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(LessThanOrEqualData))]
            public void LessThanOrEqualIntCandidate_ReturnExpectedResultObject<T>(T candidate, T lessThan,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new LessThanOrEqualSpecification<T>(lessThan, comparer);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(LessThanOrEqualData))]
            public void NotLessThanOrEqualCandidate_ReturnExpectedResultObject<T>(T candidate, T lessThan,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new LessThanOrEqualSpecification<T>(lessThan, comparer);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }

            [Theory]
            [CorrectValidationData(typeof(LessThanOrEqualNullableData))]
            public void CorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? lessThan,
                SpecificationResult expected)
            {
                var sut = new LessThanOrEqualSpecification<int?>(lessThan);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(LessThanOrEqualNullableData))]
            public void IncorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? lessThan,
                SpecificationResult expected)
            {
                var sut = new LessThanOrEqualSpecification<int?>(lessThan);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}