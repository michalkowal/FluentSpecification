using FluentSpecification.Abstractions;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    public partial class NotSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(NotData))]
            public void InvokeCorrectData_ReturnTrue(bool isNegatable)
            {
                var specification = !isNegatable
                    ? MockComplexSpecification.False()
                    : MockNegatableComplexSpecification.False();

                var sut = new NotSpecification<object>(specification);

                var result = sut.GetExpression().Compile().Invoke(new object());

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(NotData))]
            public void InvokeIncorrectData_ReturnTrue(bool isNegatable)
            {
                var specification = !isNegatable
                    ? MockComplexSpecification.True()
                    : MockNegatableComplexSpecification.True();

                var sut = new NotSpecification<object>(specification);

                var result = sut.GetExpression().Compile().Invoke(new object());

                Assert.False(result);
            }

            [Fact]
            public void CorrectSpecification_ReturnNegatedExpression()
            {
                var specification = MockSpecification.True();
                var sut = new NotSpecification<object>(specification);

                var expression = sut.GetExpression();
                var result = expression.ToString();

                Assert.Matches(@"candidate => Not\(.*.IsSatisfiedBy\(candidate\)\)", result);
            }

            [Fact]
            public void InvokeNull_NotRaiseException()
            {
                var specification = MockComplexSpecification.True();
                var sut = new NotSpecification<object>(specification);

                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.Null(exception);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnBaseExpressionAsAbstractExpression()
            {
                var specification = MockSpecification.True();
                var sut = new NotSpecification<object>(specification);

                var expected = sut.GetExpression();
                var result = ((ILinqSpecification) sut).GetExpression();

                Assert.Equal(expected, result);
            }
        }
    }
}