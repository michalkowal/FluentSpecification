using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class ContainsSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(ContainsData), AsNegation = true)]
            public void InvokeNotContainsElementsValid_ReturnTrue<T, TType>(T candidate, TType expected,
                IEqualityComparer<TType> comparer)
                where T : IEnumerable<TType>
            {
                expected = expected?.ToString() != "null" ? expected : default(TType);
                var sut = new ContainsSpecification<T, TType>(expected, comparer);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(ContainsData), AsNegation = true)]
            public void InvokeContainsElementsValid_ReturnFalse<T, TType>(T candidate, TType expected,
                IEqualityComparer<TType> comparer)
                where T : IEnumerable<TType>
            {
                expected = expected?.ToString() != "null" ? expected : default(TType);
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new ContainsSpecification<T, TType>(expected, comparer);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeContainsChildTypeElement_ReturnFalse()
            {
                var expected = new ComparableFakeType();
                var candidate = new[] {new FakeType(), expected, null};
                var sut = new ContainsSpecification<FakeType[], FakeType>(expected);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullCollectionLinqToEntities_Exception()
            {
                var sut = new ContainsSpecification<int[], int>(0, null, true);
                var exception = Record.Exception(() => sut.GetNegationExpression().Compile().Invoke(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}