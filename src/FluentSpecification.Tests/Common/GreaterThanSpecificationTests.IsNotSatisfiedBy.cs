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
        public class IsNotSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(GreaterThanData), AsNegation = true)]
            public void NotGreaterThanIntCandidate_ReturnTrue<T>(T candidate, T greaterThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new GreaterThanSpecification<T>(greaterThan, comparer);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(GreaterThanData), AsNegation = true)]
            public void GreaterThanCandidate_ReturnFalse<T>(T candidate, T greaterThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new GreaterThanSpecification<T>(greaterThan, comparer);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(GreaterThanNullableData), AsNegation = true)]
            public void NullableCandidate_ReturnTrue(int? candidate, int? greaterThan)
            {
                var sut = new GreaterThanSpecification<int?>(greaterThan);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(GreaterThanNullableData), AsNegation = true)]
            public void NullableCandidate_ReturnFalse(int? candidate, int? greaterThan)
            {
                var sut = new GreaterThanSpecification<int?>(greaterThan);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(GreaterThanData), AsNegation = true)]
            public void NotGreaterThanIntCandidate_ReturnExpectedResultObject<T>(T candidate, T greaterThan,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new GreaterThanSpecification<T>(greaterThan, comparer);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(GreaterThanData), AsNegation = true)]
            public void GreaterThanCandidate_ReturnExpectedResultObject<T>(T candidate, T greaterThan,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new GreaterThanSpecification<T>(greaterThan, comparer);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }

            [Theory]
            [CorrectValidationData(typeof(GreaterThanNullableData), AsNegation = true)]
            public void CorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? greaterThan,
                SpecificationResult expected)
            {
                var sut = new GreaterThanSpecification<int?>(greaterThan);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(GreaterThanNullableData), AsNegation = true)]
            public void IncorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? greaterThan,
                SpecificationResult expected)
            {
                var sut = new GreaterThanSpecification<int?>(greaterThan);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}