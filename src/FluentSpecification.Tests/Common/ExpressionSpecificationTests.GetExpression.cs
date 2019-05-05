using System;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class ExpressionSpecificationTests
    {
        public class GetExpression
        {
            [Fact]
            public void CorrectSpecification_ReturnBaseExpression()
            {
                Expression<Func<object, bool>> expected = candidate => true;
                var sut = new ExpressionSpecification<object>(expected);

                var result = sut.GetExpression();

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void InvokeFalseExpression_ReturnFalse()
            {
                Expression<Func<object, bool>> expression = candidate => false;
                var sut = new ExpressionSpecification<object>(expression);

                var result = sut.GetExpression().Compile().Invoke(new object());

                Assert.False(result);
            }

            [Fact]
            public void InvokeNull_NotRaiseException()
            {
                Expression<Func<object, bool>> expression = candidate => true;
                var sut = new ExpressionSpecification<object>(expression);

                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.Null(exception);
            }

            [Fact]
            public void InvokeTrueExpression_ReturnTrue()
            {
                Expression<Func<object, bool>> expression = candidate => true;
                var sut = new ExpressionSpecification<object>(expression);

                var result = sut.GetExpression().Compile().Invoke(new object());

                Assert.True(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnBaseExpressionAsAbstractExpression()
            {
                Expression<Func<object, bool>> expected = candidate => true;
                ILinqSpecification sut = new ExpressionSpecification<object>(expected);

                var result = sut.GetExpression();

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }
        }
    }
}