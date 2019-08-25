using System;
using System.Collections;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class LengthBetweenSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(LengthBetweenData), AsNegation = true)]
            public void InvokeValidCandidate_ReturnTrue<T>(T candidate, int minLength, int maxLength)
                where T : IEnumerable
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new LengthBetweenSpecification<T>(minLength, maxLength);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LengthBetweenData), AsNegation = true)]
            public void InvokeInvalidCandidate_ReturnFalse<T>(T candidate, int minLength, int maxLength)
                where T : IEnumerable
            {
                var sut = new LengthBetweenSpecification<T>(minLength, maxLength);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullCollectionLinqToEntities_Exception()
            {
                var sut = new LengthBetweenSpecification<int[]>(0, 0, true);
                var exception = Record.Exception(() => sut.GetNegationExpression().Compile().Invoke(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}