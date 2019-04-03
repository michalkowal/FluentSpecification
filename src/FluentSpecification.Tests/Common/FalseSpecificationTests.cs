using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class FalseSpecificationTests
    {
        public class GetExpression
        {
            [Fact]
            public void InvokeInvalidCandidate_ReturnTrue()
            {
                var sut = new FalseSpecification();

                var result = sut.GetExpression().Compile().Invoke(false);

                Assert.True(result);
            }

            [Fact]
            public void InvokeValidCandidate_ReturnFalse()
            {
                var sut = new FalseSpecification();

                var result = sut.GetExpression().Compile().Invoke(true);

                Assert.False(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new FalseSpecification();

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}