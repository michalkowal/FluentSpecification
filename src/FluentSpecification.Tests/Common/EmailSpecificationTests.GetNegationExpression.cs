using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class EmailSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(EmailData), AsNegation = true)]
            public void InvokeValidCandidate_ReturnTrue(string candidate)
            {
                var sut = new EmailSpecification();

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EmailData), AsNegation = true)]
            public void InvokeInvalidCandidate_ReturnFalse(string candidate)
            {
                var sut = new EmailSpecification();

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }
        }
    }
}