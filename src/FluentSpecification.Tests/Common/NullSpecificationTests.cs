using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class NullSpecificationTests
    {
        public class GetExpression
        {
            [Fact]
            public void InvokeNotNullCandidate_ReturnFalse()
            {
                var sut = new NullSpecification<string>();

                var result = sut.GetExpression().Compile().Invoke("");

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullableCandidate_ReturnTrue()
            {
                var sut = new NullSpecification<int?>();

                var result = sut.GetExpression().Compile().Invoke(null);

                Assert.True(result);
            }

            [Fact]
            public void InvokeNullCandidate_ReturnTrue()
            {
                var sut = new NullSpecification<string>();

                var result = sut.GetExpression().Compile().Invoke(null);

                Assert.True(result);
            }

            [Fact]
            public void InvokeValueTypeCandidate_ReturnFalse()
            {
                var sut = new NullSpecification<int>();

                var result = sut.GetExpression().Compile().Invoke(0);

                Assert.False(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new NullSpecification<string>();

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}