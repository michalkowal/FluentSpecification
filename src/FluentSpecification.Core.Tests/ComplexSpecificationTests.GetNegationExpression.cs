using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests
{
    public partial class ComplexSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(ComplexData), AsNegation = true)]
            public void InvokeCorrectData_ReturnTrue<T>(T candidate)
            {
                var sut = new MockCommonSpecification<T>();

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(ComplexData), AsNegation = true)]
            public void InvokeIncorrectData_ReturnFalse<T>(T candidate)
            {
                var sut = new MockCommonSpecification<T>();

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNull_NotRaiseException()
            {
                var sut = new MockCommonSpecification<object>();

                var exception = Record.Exception(() => sut.GetNegationExpression().Compile().Invoke(null));

                Assert.Null(exception);
            }

            [Fact]
            public void InvokeNullable_ReturnTrue()
            {
                var sut = new MockCommonSpecification<int?>();

                var result = sut.GetNegationExpression().Compile().Invoke(0);

                Assert.True(result);
            }
        }
    }
}