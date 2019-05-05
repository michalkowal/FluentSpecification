using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class TrueSpecificationTests
    {
        public class GetExpression
        {
            [Fact]
            public void InvokeInvalidCandidate_ReturnFalse()
            {
                var sut = new TrueSpecification();

                var result = sut.GetExpression().Compile().Invoke(false);

                Assert.False(result);
            }

            [Fact]
            public void InvokeValidCandidate_ReturnTrue()
            {
                var sut = new TrueSpecification();

                var result = sut.GetExpression().Compile().Invoke(true);

                Assert.True(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new TrueSpecification();

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}