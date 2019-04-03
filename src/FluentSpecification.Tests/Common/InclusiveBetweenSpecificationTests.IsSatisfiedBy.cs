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
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(InclusiveBetweenData))]
            public void InclusiveBetweenCandidate_ReturnTrue<T>(T candidate, T from, T to, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new InclusiveBetweenSpecification<T>(from, to, comparer);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(InclusiveBetweenData))]
            public void NotInclusiveBetweenCandidate_ReturnFalse<T>(T candidate, T from, T to, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new InclusiveBetweenSpecification<T>(from, to, comparer);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(InclusiveBetweenNullableData))]
            public void NullableCandidate_ReturnTrue(int? candidate, int? from, int? to)
            {
                var sut = new InclusiveBetweenSpecification<int?>(from, to);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(InclusiveBetweenNullableData))]
            public void NullableCandidate_ReturnFalse(int? candidate, int? from, int? to)
            {
                var sut = new InclusiveBetweenSpecification<int?>(from, to);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(InclusiveBetweenData))]
            public void InclusiveBetweenCandidate_ReturnExpectedResultObject<T>(T candidate, T from, T to,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new InclusiveBetweenSpecification<T>(from, to, comparer);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(InclusiveBetweenData))]
            public void NotInclusiveBetweenCandidate_ReturnExpectedResultObject<T>(T candidate, T from, T to,
                IComparer<T> comparer, SpecificationResult expected)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new InclusiveBetweenSpecification<T>(from, to, comparer);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate));
            }

            [Theory]
            [CorrectValidationData(typeof(InclusiveBetweenNullableData))]
            public void CorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? from, int? to,
                SpecificationResult expected)
            {
                var sut = new InclusiveBetweenSpecification<int?>(from, to);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(InclusiveBetweenNullableData))]
            public void IncorrectNullableCandidate_ReturnExpectedResultObject(int? candidate, int? from, int? to,
                SpecificationResult expected)
            {
                var sut = new InclusiveBetweenSpecification<int?>(from, to);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}