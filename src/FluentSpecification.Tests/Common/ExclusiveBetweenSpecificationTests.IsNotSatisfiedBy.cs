using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class ExclusiveBetweenSpecificationTests
    {
        public class IsNotSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(ExclusiveBetweenData), AsNegation = true)]
            public void NotExclusiveBetweenCandidate_ReturnTrue<T>(T candidate, T from, T to, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new ExclusiveBetweenSpecification<T>(from, to, comparer);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(ExclusiveBetweenData), AsNegation = true)]
            public void ExclusiveBetweenCandidate_ReturnFalse<T>(T candidate, T from, T to, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new ExclusiveBetweenSpecification<T>(from, to, comparer);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(ExclusiveBetweenNullableData), AsNegation = true)]
            public void NullableCandidate_ReturnTrue(int? candidate, int? from, int? to)
            {
                var sut = new ExclusiveBetweenSpecification<int?>(from, to);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(ExclusiveBetweenNullableData), AsNegation = true)]
            public void NullableCandidate_ReturnFalse(int? candidate, int? from, int? to)
            {
                var sut = new ExclusiveBetweenSpecification<int?>(from, to);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(ExclusiveBetweenData), AsNegation = true)]
            public void NotExclusiveBetweenCandidate_ReturnExpectedResultObject<T>(T candidate, T from, T to,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new ExclusiveBetweenSpecification<T>(from, to, comparer);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(ExclusiveBetweenData), AsNegation = true)]
            public void ExclusiveBetweenCandidate_ReturnExpectedResultObject<T>(T candidate, T from, T to,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new ExclusiveBetweenSpecification<T>(from, to, comparer);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }

            [Theory]
            [CorrectValidationData(typeof(ExclusiveBetweenNullableData), AsNegation = true)]
            public void CorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? from, int? to,
                SpecificationResult expected)
            {
                var sut = new ExclusiveBetweenSpecification<int?>(from, to);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(ExclusiveBetweenNullableData), AsNegation = true)]
            public void IncorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? from, int? to,
                SpecificationResult expected)
            {
                var sut = new ExclusiveBetweenSpecification<int?>(from, to);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}