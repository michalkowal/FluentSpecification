using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class CreditCardSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(CreditCardData))]
            public void InvokeValidCandidate_ReturnTrue(string candidate)
            {
                var sut = new CreditCardSpecification();

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(CreditCardData))]
            public void InvokeInvalidCandidate_ReturnFalse(string candidate)
            {
                var sut = new CreditCardSpecification();

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new CreditCardSpecification();

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}