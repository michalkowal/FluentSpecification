using FluentSpecification.Abstractions;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests
{
    public partial class ComplexSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(ComplexData))]
            public void InvokeCorrectData_ReturnTrue<T>(T candidate)
            {
                var sut = new MockCommonSpecification<T>();

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(ComplexData))]
            public void InvokeIncorrectData_ReturnFalse<T>(T candidate)
            {
                var sut = new MockCommonSpecification<T>();

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeNull_NotRaiseException()
            {
                var sut = new MockCommonSpecification<object>();

                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.Null(exception);
            }

            [Fact]
            public void InvokeNullable_ReturnFalse()
            {
                var sut = new MockCommonSpecification<int?>();

                var result = sut.GetExpression().Compile().Invoke(0);

                Assert.False(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new MockCommonSpecification<object>();

                var expected = sut.GetExpression();
                var result = ((ILinqSpecification) sut).GetExpression();

                Assert.Equal(expected.ToString(), result.ToString());
            }
        }
    }
}