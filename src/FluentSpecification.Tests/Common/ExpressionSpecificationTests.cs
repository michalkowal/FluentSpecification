using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using FluentSpecification.Common;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class ExpressionSpecificationTests
    {
        public class Constructor
        {
            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullExpression_ArgumentNullException()
            {
                var exception = Record.Exception(() => new ExpressionSpecification<object>(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class ExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnBaseExpression()
            {
                Expression<Func<object, bool>> expected = candidate => true;
                var sut = new ExpressionSpecification<object>(expected);

                var result = (Expression<Func<object, bool>>) sut;

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_ReturnNull()
            {
                var result = (Expression<Func<object, bool>>) (ExpressionSpecification<object>) null;

                Assert.Null(result);
            }
        }

        public class AbstractExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnBaseExpression()
            {
                Expression<Func<object, bool>> expected = candidate => true;
                var sut = new ExpressionSpecification<object>(expected);

                var result = (Expression) sut;

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_ReturnNull()
            {
                var result = (Expression) (ExpressionSpecification<object>) null;

                Assert.Null(result);
            }
        }
    }
}