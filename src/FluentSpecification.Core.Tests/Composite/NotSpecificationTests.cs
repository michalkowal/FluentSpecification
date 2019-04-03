using System;
using System.Linq.Expressions;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Mocks;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    [UsedImplicitly]
    public partial class NotSpecificationTests
    {
        public class Constructor
        {
            [Fact]
            public void NullSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() => new NotSpecification<object>(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class ExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnNegatedExpression()
            {
                var specification = MockSpecification.True();
                var sut = new NotSpecification<object>(specification);

                var expected = sut.GetExpression();
                var result = (Expression<Func<object, bool>>) sut;

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception =
                    Record.Exception(() => (Expression<Func<object, bool>>) (NotSpecification<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class AbstractExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnNegatedExpression()
            {
                var specification = MockSpecification.True();
                var sut = new NotSpecification<object>(specification);

                var expected = sut.GetExpression();
                var result = (Expression) sut;

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Expression) (NotSpecification<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class FuncOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnIsSatisfiedByFunction()
            {
                var specification = MockSpecification.True();
                var sut = new NotSpecification<object>(specification);
                Func<object, bool> expected = sut.IsSatisfiedBy;

                var result = (Func<object, bool>) sut;

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Func<object, bool>) (NotSpecification<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }
        }
    }
}