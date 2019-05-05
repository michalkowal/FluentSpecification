using FluentSpecification.Common;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class NullSpecificationTests
    {
        public class GetNegationExpression
        {
            [Fact]
            public void InvokeNotNullCandidate_ReturnTrue()
            {
                var sut = new NullSpecification<string>();

                var result = sut.GetNegationExpression().Compile().Invoke("");

                Assert.True(result);
            }

            [Fact]
            public void InvokeNullableCandidate_ReturnFalse()
            {
                var sut = new NullSpecification<int?>();

                var result = sut.GetNegationExpression().Compile().Invoke(null);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNullCandidate_ReturnFalse()
            {
                var sut = new NullSpecification<string>();

                var result = sut.GetNegationExpression().Compile().Invoke(null);

                Assert.False(result);
            }

            [Fact]
            public void InvokeValueTypeCandidate_ReturnTrue()
            {
                var sut = new NullSpecification<int>();

                var result = sut.GetNegationExpression().Compile().Invoke(0);

                Assert.True(result);
            }
        }
    }
}