using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class EmptySpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(EmptyData), AsNegation = true)]
            public void InvokeNotEmptyCandidate_ReturnTrue<T>(T candidate)
            {
                var sut = new EmptySpecification<T>();

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EmptyData), AsNegation = true)]
            public void InvokeEmptyCandidate_ReturnFalse<T>(T candidate)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EmptySpecification<T>();

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullable_ReturnFalse()
            {
                var sut = new EmptySpecification<int?>();

                var result = sut.GetNegationExpression().Compile().Invoke(null);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullable_ReturnTrue()
            {
                var sut = new EmptySpecification<int?>();

                var result = sut.GetNegationExpression().Compile().Invoke(0);

                Assert.True(result);
            }

            [Fact]
            public void InvokeNullCollectionLinqToEntities_Exception()
            {
                var sut = new EmptySpecification<int[]>(true);
                var exception = Record.Exception(() => sut.GetNegationExpression().Compile().Invoke(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}