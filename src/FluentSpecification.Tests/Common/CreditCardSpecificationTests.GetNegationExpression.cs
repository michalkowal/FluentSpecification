using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class CreditCardSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(CreditCardData), AsNegation = true)]
            public void InvokeValidCandidate_ReturnTrue(string candidate)
            {
                var sut = new CreditCardSpecification();

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(CreditCardData), AsNegation = true)]
            public void InvokeInvalidCandidate_ReturnFalse(string candidate)
            {
                var sut = new CreditCardSpecification();

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }
        }
    }
}