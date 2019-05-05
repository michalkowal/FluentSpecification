using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class InclusiveBetweenSpecificationTests
    {
        public class IsNotSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(InclusiveBetweenData), AsNegation = true)]
            public void NotInclusiveBetweenCandidate_ReturnTrue<T>(T candidate, T from, T to, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new InclusiveBetweenSpecification<T>(from, to, comparer);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(InclusiveBetweenData), AsNegation = true)]
            public void InclusiveBetweenCandidate_ReturnFalse<T>(T candidate, T from, T to, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new InclusiveBetweenSpecification<T>(from, to, comparer);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(InclusiveBetweenNullableData), AsNegation = true)]
            public void NullableCandidate_ReturnTrue(int? candidate, int? from, int? to)
            {
                var sut = new InclusiveBetweenSpecification<int?>(from, to);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(InclusiveBetweenNullableData), AsNegation = true)]
            public void NullableCandidate_ReturnFalse(int? candidate, int? from, int? to)
            {
                var sut = new InclusiveBetweenSpecification<int?>(from, to);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(InclusiveBetweenData), AsNegation = true)]
            public void NotInclusiveBetweenCandidate_ReturnExpectedResultObject<T>(T candidate, T from, T to,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new InclusiveBetweenSpecification<T>(from, to, comparer);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(InclusiveBetweenData), AsNegation = true)]
            public void InclusiveBetweenCandidate_ReturnExpectedResultObject<T>(T candidate, T from, T to,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new InclusiveBetweenSpecification<T>(from, to, comparer);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }

            [Theory]
            [CorrectValidationData(typeof(InclusiveBetweenNullableData), AsNegation = true)]
            public void CorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? from, int? to,
                SpecificationResult expected)
            {
                var sut = new InclusiveBetweenSpecification<int?>(from, to);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(InclusiveBetweenNullableData), AsNegation = true)]
            public void IncorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? from, int? to,
                SpecificationResult expected)
            {
                var sut = new InclusiveBetweenSpecification<int?>(from, to);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}