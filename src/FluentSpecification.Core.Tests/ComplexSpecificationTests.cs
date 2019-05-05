using System;
using System.Linq.Expressions;
using FluentSpecification.Core.Tests.Mocks;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Core.Tests
{
    [UsedImplicitly]
    public partial class ComplexSpecificationTests
    {
        public class ExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnExpression()
            {
                var sut = new MockCommonSpecification<object>();

                var expected = sut.GetExpression();
                var result = (Expression<Func<object, bool>>) sut;

                Assert.Equal(expected.ToString(), result.ToString());
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() =>
                    (Expression<Func<object, bool>>) (MockCommonSpecification<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class AbstractExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnExpression()
            {
                var sut = new MockCommonSpecification<object>();

                var expected = sut.GetExpression();
                var result = (Expression) sut;

                Assert.Equal(expected.ToString(), result.ToString());
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Expression) (MockCommonSpecification<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class FuncOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnIsSatisfiedByFunction()
            {
                var sut = new MockCommonSpecification<object>();
                Func<object, bool> expected = sut.IsSatisfiedBy;

                var result = (Func<object, bool>) sut;

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Func<object, bool>) (MockCommonSpecification<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }
    }
}