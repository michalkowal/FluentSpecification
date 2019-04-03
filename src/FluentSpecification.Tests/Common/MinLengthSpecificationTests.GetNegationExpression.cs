using System;
using System.Collections;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class MinLengthSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(MinLengthData), AsNegation = true)]
            public void InvokeValidCandidate_ReturnTrue<T>(T candidate, int minLength)
                where T : IEnumerable
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new MinLengthSpecification<T>(minLength);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(MinLengthData), AsNegation = true)]
            public void InvokeInvalidCandidate_ReturnFalse<T>(T candidate, int minLength)
                where T : IEnumerable
            {
                var sut = new MinLengthSpecification<T>(minLength);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullCollectionLinqToEntities_Exception()
            {
                var sut = new MinLengthSpecification<int[]>(0, true);
                var exception = Record.Exception(() => sut.GetNegationExpression().Compile().Invoke(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}