using FluentSpecification.Abstractions;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    public partial class AndSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(AndData))]
            public void InvokeCorrectData_ReturnTrue(bool leftResult, bool rightResult)
            {
                var left = MockComplexSpecification.Create(leftResult);
                var right = MockComplexSpecification.Create(rightResult);
                var sut = new AndSpecification<object>(left, right);

                var result = sut.GetExpression().Compile().Invoke(new object());

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(AndData))]
            public void InvokeIncorrectData_ReturnFalse(bool leftResult, bool rightResult)
            {
                var left = MockComplexSpecification.Create(leftResult);
                var right = MockComplexSpecification.Create(rightResult);
                var sut = new AndSpecification<object>(left, right);

                var result = sut.GetExpression().Compile().Invoke(new object());

                Assert.False(result);
            }

            [Fact]
            public void CorrectSpecifications_ReturnAndExpression()
            {
                var left = MockSpecification.True();
                var right = MockSpecification.True();
                var sut = new AndSpecification<object>(left, right);

                var expression = sut.GetExpression();
                var result = expression.ToString();

                Assert.Matches(@"candidate => \(.*.IsSatisfiedBy\(candidate\) AndAlso .*.IsSatisfiedBy\(candidate\)\)",
                    result);
            }

            [Fact]
            public void DifferentTypesSpecifications_ReplaceCandidateParameterToObjInExpression()
            {
                var left = MockComplexSpecification.True();
                var right = MockSpecification.True();
                var sut = new AndSpecification<object>(left, right);

                var expression = sut.GetExpression();
                var result = expression.ToString();

                Assert.Matches(
                    @"obj => \(value\(FluentSpecification.Core.Tests.Mocks.TrueMockComplexSpecification\).IsSatisfiedBy\(obj\) AndAlso .*.IsSatisfiedBy\(obj\)\)",
                    result);
            }

            [Fact]
            public void InvokeNull_NotRaiseException()
            {
                var left = MockComplexSpecification.True();
                var right = MockComplexSpecification.True();
                var sut = new AndSpecification<object>(left, right);

                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.Null(exception);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var left = MockSpecification.True();
                var right = MockSpecification.True();
                var sut = new AndSpecification<object>(left, right);

                var expected = sut.GetExpression();
                var result = ((ILinqSpecification) sut).GetExpression();

                Assert.Equal(expected, result);
            }
        }
    }
}