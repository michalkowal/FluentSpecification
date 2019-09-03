using System;
using System.Collections;
using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class MaxLengthSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(MaxLengthData))]
            public void InvokeValidCandidate_ReturnTrue<T>(T candidate, int maxLength)
                where T : IEnumerable
            {
                var sut = new MaxLengthSpecification<T>(maxLength);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(MaxLengthData))]
            public void InvokeInvalidCandidate_ReturnFalse<T>(T candidate, int maxLength)
                where T : IEnumerable
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new MaxLengthSpecification<T>(maxLength);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullCollectionLinqToEntities_Exception()
            {
                var sut = new MaxLengthSpecification<int[]>(0, true);
                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new MaxLengthSpecification<string>(0);

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}