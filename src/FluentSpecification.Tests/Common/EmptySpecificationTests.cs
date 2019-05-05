using System;
using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class EmptySpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(EmptyData))]
            public void InvokeEmptyCandidate_ReturnTrue<T>(T candidate)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EmptySpecification<T>();

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EmptyData))]
            public void InvokeNotEmptyCandidate_ReturnFalse<T>(T candidate)
            {
                var sut = new EmptySpecification<T>();

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullable_ReturnFalse()
            {
                var sut = new EmptySpecification<int?>();

                var result = sut.GetExpression().Compile().Invoke(0);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullable_ReturnTrue()
            {
                var sut = new EmptySpecification<int?>();

                var result = sut.GetExpression().Compile().Invoke(null);

                Assert.True(result);
            }

            [Fact]
            public void InvokeNullCollectionLinqToEntities_Exception()
            {
                var sut = new EmptySpecification<int[]>(true);
                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new EmptySpecification<string>();

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}