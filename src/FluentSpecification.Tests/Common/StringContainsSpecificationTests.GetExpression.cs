using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class StringContainsSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(StringContainsData))]
            public void InvokeValidCandidate_ReturnTrue(string candidate, string expected)
            {
                var sut = new ContainsSpecification(expected);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(StringContainsData))]
            public void InvokeInvalidCandidate_ReturnFalse(string candidate, string expected)
            {
                var sut = new ContainsSpecification(expected);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new ContainsSpecification(" ");

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}