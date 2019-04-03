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
    public partial class LengthSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(LengthData))]
            public void InvokeValidCandidate_ReturnTrue<T>(T candidate, int length)
                where T : IEnumerable
            {
                var sut = new LengthSpecification<T>(length);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LengthData))]
            public void InvokeInvalidCandidate_ReturnFalse<T>(T candidate, int length)
                where T : IEnumerable
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new LengthSpecification<T>(length);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullCollectionLinqToEntities_Exception()
            {
                var sut = new LengthSpecification<int[]>(0, true);
                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new LengthSpecification<string>(0);

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}