using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using FluentSpecification.Core.Tests.Mocks;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Core.Tests
{
    [UsedImplicitly]
    public partial class SpecificationAdapterTests
    {
        public class Constructor
        {
            [Fact]
            public void IComplexSpecification_ArgumentException()
            {
                var exception = Record.Exception(() =>
                    new SpecificationAdapter<object>(
                        MockComplexSpecification.True()));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() => new SpecificationAdapter<object>(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class ExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnIsSatisfiedByExecutionInExpression()
            {
                var specification = MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var expected = sut.GetExpression();
                var result = (Expression<Func<object, bool>>) sut;

                Assert.Equal(expected.ToString(), result.ToString());
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() =>
                    (Expression<Func<object, bool>>) (SpecificationAdapter<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class AbstractExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnIsSatisfiedByExecutionInExpression()
            {
                var specification = MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var expected = sut.GetExpression();
                var result = (Expression) sut;

                Assert.Equal(expected.ToString(), result.ToString());
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Expression) (SpecificationAdapter<object>) null);

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
                var sut = new SpecificationAdapter<object>(specification);
                Func<object, bool> expected = sut.IsSatisfiedBy;

                var result = (Func<object, bool>) sut;

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Func<object, bool>) (SpecificationAdapter<object>) null);

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }
        }
    }
}