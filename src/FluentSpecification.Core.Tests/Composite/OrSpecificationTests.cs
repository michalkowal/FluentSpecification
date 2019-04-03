using System;
using System.Linq.Expressions;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Mocks;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    [UsedImplicitly]
    public partial class OrSpecificationTests
    {
        public class Constructor
        {
            [Fact]
            public void NullLeftSpecification_ArgumentNullException()
            {
                var specification = MockSpecification.True();
                var exception = Record.Exception(() => new OrSpecification<object>(null, specification));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Fact]
            public void NullRightSpecification_ArgumentNullException()
            {
                var specification = MockSpecification.True();
                var exception = Record.Exception(() => new OrSpecification<object>(specification, null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class ExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnOrExpression()
            {
                var left = MockSpecification.True();
                var right = MockSpecification.True();
                var sut = new OrSpecification<object>(left, right);

                var expected = sut.GetExpression();
                var result = (Expression<Func<object, bool>>) sut;

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Expression<Func<object, bool>>) (OrSpecification<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class AbstractExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnOrExpression()
            {
                var left = MockSpecification.True();
                var right = MockSpecification.True();
                var sut = new OrSpecification<object>(left, right);

                var expected = sut.GetExpression();
                var result = (Expression) sut;

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Expression) (OrSpecification<object>) null);

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
                var sut = new OrSpecification<object>(left, right);
                Func<object, bool> expected = sut.IsSatisfiedBy;

                var result = (Func<object, bool>) sut;

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Func<object, bool>) (OrSpecification<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }
        }
    }
}