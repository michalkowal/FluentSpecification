using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class StringContainsSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(StringContainsData), AsNegation = true)]
            public void InvokeValidCandidate_ReturnTrue(string candidate, string expected)
            {
                var sut = new ContainsSpecification(expected);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(StringContainsData), AsNegation = true)]
            public void InvokeInvalidCandidate_ReturnFalse(string candidate, string expected)
            {
                var sut = new ContainsSpecification(expected);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }
        }
    }
}