using System;
using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class IsTypeSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(IsTypeData))]
            public void InvokeValidCandidate_ReturnTrue<T>(T candidate, Type expected)
            {
                var sut = new IsTypeSpecification<T>(expected);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(IsTypeData))]
            public void InvokeInvalidCandidate_ReturnFalse<T>(T candidate, Type expected)
            {
                var sut = new IsTypeSpecification<T>(expected);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new IsTypeSpecification<FakeType>(typeof(object));

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}