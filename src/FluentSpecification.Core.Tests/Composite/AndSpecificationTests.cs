using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Mocks;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    [UsedImplicitly]
    public partial class AndSpecificationTests
    {
        public class Constructor
        {
            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullLeftSpecification_ArgumentNullException()
            {
                var specification = MockSpecification.True();
                var exception = Record.Exception(() => new AndSpecification<object>(null, specification));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullRightSpecification_ArgumentNullException()
            {
                var specification = MockSpecification.True();
                var exception = Record.Exception(() => new AndSpecification<object>(specification, null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class ExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnAndExpression()
            {
                var left = MockSpecification.True();
                var right = MockSpecification.True();
                var sut = new AndSpecification<object>(left, right);

                var expected = sut.GetExpression();
                var result = (Expression<Func<object, bool>>) sut;

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception =
                    Record.Exception(() => (Expression<Func<object, bool>>) (AndSpecification<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class AbstractExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnAndExpression()
            {
                var left = MockSpecification.True();
                var right = MockSpecification.True();
                var sut = new AndSpecification<object>(left, right);

                var expected = sut.GetExpression();
                var result = (Expression) sut;

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Expression) (AndSpecification<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class FuncOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnIsSatisfiedByFunction()
            {
                var left = MockSpecification.True();
                var right = MockSpecification.True();
                var sut = new AndSpecification<object>(left, right);
                Func<object, bool> expected = sut.IsSatisfiedBy;

                var result = (Func<object, bool>) sut;

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Func<object, bool>) (AndSpecification<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }
        }
    }
}