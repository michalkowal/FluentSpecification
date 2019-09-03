﻿using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class LessThanOrEqualSpecificationTests
    {
        public class IsNotSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(LessThanOrEqualData), AsNegation = true)]
            public void NotLessThanOrEqualIntCandidate_ReturnTrue<T>(T candidate, T lessThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new LessThanOrEqualSpecification<T>(lessThan, comparer);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LessThanOrEqualData), AsNegation = true)]
            public void LessThanOrEqualCandidate_ReturnFalse<T>(T candidate, T lessThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new LessThanOrEqualSpecification<T>(lessThan, comparer);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(LessThanOrEqualNullableData), AsNegation = true)]
            public void NullableCandidate_ReturnTrue(int? candidate, int? lessThan)
            {
                var sut = new LessThanOrEqualSpecification<int?>(lessThan);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LessThanOrEqualNullableData), AsNegation = true)]
            public void NullableCandidate_ReturnFalse(int? candidate, int? lessThan)
            {
                var sut = new LessThanOrEqualSpecification<int?>(lessThan);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(LessThanOrEqualData), AsNegation = true)]
            public void NotLessThanOrEqualIntCandidate_ReturnExpectedResultObject<T>(T candidate, T lessThan,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new LessThanOrEqualSpecification<T>(lessThan, comparer);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(LessThanOrEqualData), AsNegation = true)]
            public void LessThanOrEqualCandidate_ReturnExpectedResultObject<T>(T candidate, T lessThan,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new LessThanOrEqualSpecification<T>(lessThan, comparer);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }

            [Theory]
            [CorrectValidationData(typeof(LessThanOrEqualNullableData), AsNegation = true)]
            public void CorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? lessThan,
                SpecificationResult expected)
            {
                var sut = new LessThanOrEqualSpecification<int?>(lessThan);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(LessThanOrEqualNullableData), AsNegation = true)]
            public void IncorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? lessThan,
                SpecificationResult expected)
            {
                var sut = new LessThanOrEqualSpecification<int?>(lessThan);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}