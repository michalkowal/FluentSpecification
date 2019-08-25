using System;
using System.Collections;
using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class LengthBetweenSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(LengthBetweenData))]
            public void InvokeValidCandidate_ReturnTrue<T>(T candidate, int minLength, int maxLength)
                where T : IEnumerable
            {
                var sut = new LengthBetweenSpecification<T>(minLength, maxLength);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LengthBetweenData))]
            public void InvokeInvalidCandidate_ReturnFalse<T>(T candidate, int minLength, int maxLength)
                where T : IEnumerable
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new LengthBetweenSpecification<T>(minLength, maxLength);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullCollectionLinqToEntities_Exception()
            {
                var sut = new LengthBetweenSpecification<int[]>(0, 0, true);
                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new LengthBetweenSpecification<string>(0, 0);

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}