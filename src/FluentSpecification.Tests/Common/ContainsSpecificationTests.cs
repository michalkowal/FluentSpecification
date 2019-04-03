using System;
using System.Collections.Generic;
using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class ContainsSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(ContainsData))]
            public void InvokeContainsElementsValid_ReturnTrue<T, TType>(T candidate, TType expected,
                IEqualityComparer<TType> comparer)
                where T : IEnumerable<TType>
            {
                expected = expected?.ToString() != "null" ? expected : default(TType);
                var sut = new ContainsSpecification<T, TType>(expected, comparer);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(ContainsData))]
            public void InvokeNotContainsElementsValid_ReturnFalse<T, TType>(T candidate, TType expected,
                IEqualityComparer<TType> comparer)
                where T : IEnumerable<TType>
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new ContainsSpecification<T, TType>(expected, comparer);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeContainsChildTypeElement_ReturnTrue()
            {
                var expected = new ComparableFakeType();
                var candidate = new[] {new FakeType(), expected, null};
                var sut = new ContainsSpecification<FakeType[], FakeType>(expected);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Fact]
            public void InvokeNullCollectionLinqToEntities_Exception()
            {
                var sut = new ContainsSpecification<int[], int>(0, null, true);
                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnBaseExpressionAsAbstractExpression()
            {
                var sut = new ContainsSpecification<string[], string>("");

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}