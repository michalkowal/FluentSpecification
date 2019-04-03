using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class AnySpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Theory]
            [CorrectData(typeof(AnyData))]
            public void AnyElementsValid_ReturnTrue<T, TType>(T candidate, Expression<Func<TType, bool>> expression)
                where T : IEnumerable<TType>
            {
                var specification = new MockComplexSpecification<TType>(expression);
                var sut = new AnySpecification<T, TType>(specification);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(AnyData))]
            public void NotAnyElementsValid_ReturnFalse<T, TType>(T candidate, Expression<Func<TType, bool>> expression)
                where T : IEnumerable<TType>
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var specification = new MockComplexSpecification<TType>(expression);
                var sut = new AnySpecification<T, TType>(specification);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NullCollectionLinqToEntities_NoException()
            {
                var specification = MockComplexSpecification<int>.True();
                var sut = new AnySpecification<int[], int>(specification, true);
                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.Null(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Theory]
            [CorrectValidationData(typeof(AnyData))]
            public void AnyElementsValid_ReturnExpectedResultObject<T, TType>(T candidate,
                Expression<Func<TType, bool>> expression, SpecificationResult expected)
                where T : IEnumerable<TType>
            {
                var specification = new MockComplexSpecification<TType>(expression);
                var sut = new AnySpecification<T, TType>(specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Theory]
            [IncorrectValidationData(typeof(AnyData))]
            public void NotAnyElementsValid_ReturnExpectedResultObject<T, TType>(T candidate,
                Expression<Func<TType, bool>> expression, SpecificationResult expected)
                where T : IEnumerable<TType>
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var specification = new MockComplexSpecification<TType>(expression);
                var sut = new AnySpecification<T, TType>(specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer(candidate, new Dictionary<string, object>
                {
                    {"SpecificationForAny", specification},
                    {"Expression", expression}
                }));
            }

            [Fact]
            public void NullCollectionLinqToEntities_NoException()
            {
                var specification = MockComplexSpecification<int>.True();
                var sut = new AnySpecification<int[], int>(specification, true);
                var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

                Assert.Null(exception);
            }
        }
    }
}