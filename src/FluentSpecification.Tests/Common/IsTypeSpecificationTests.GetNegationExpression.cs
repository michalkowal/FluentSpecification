using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class IsTypeSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(IsTypeData), AsNegation = true)]
            public void InvokeValidCandidate_ReturnTrue<T>(T candidate, Type expected)
            {
                var sut = new IsTypeSpecification<T>(expected);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(IsTypeData), AsNegation = true)]
            public void InvokeInvalidCandidate_ReturnFalse<T>(T candidate, Type expected)
            {
                var sut = new IsTypeSpecification<T>(expected);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }
        }
    }
}