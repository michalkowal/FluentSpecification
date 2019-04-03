using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class MatchSpecificationTests
    {
        public class GetExpression
        {
            [Fact]
            public void InvokeInvalidCandidate_ReturnFalse()
            {
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var candidate = "2019-02-261";
                var sut = new MatchSpecification(pattern);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullCandidate_ReturnFalse()
            {
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var sut = new MatchSpecification(pattern);

                var result = sut.GetExpression().Compile().Invoke(null);

                Assert.False(result);
            }

            [Fact]
            public void InvokeValidCandidate_ReturnTrue()
            {
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var candidate = "2019-02-26";
                var sut = new MatchSpecification(pattern);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var sut = new MatchSpecification(pattern);

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}