using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Mocks;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    [UsedImplicitly]
    public partial class CastSpecificationTests
    {
        public class Constructor
        {
            [Fact]
            public void NoConversionMethod_InvalidOperationException()
            {
                var specification = MockSpecification<int>.True();
                var exception = Record.Exception(() =>
                    new CastSpecification<FakeType, int>(specification));

                Assert.NotNull(exception);
                Assert.IsType<InvalidOperationException>(exception);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() =>
                    new CastSpecification<FakeType, object>(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class ExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnExpression()
            {
                var specification = MockSpecification<object>.True();
                var sut = new CastSpecification<FakeType, object>(specification);

                var expected = sut.GetExpression();
                var expression = (Expression<Func<FakeType, bool>>) sut;

                Assert.Equal(expected, expression);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() =>
                    (Expression<Func<FakeType, bool>>) (CastSpecification<FakeType, object>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class AbstractExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnExpressionWithParameterFromSelector()
            {
                var specification = MockSpecification<object>.True();
                var sut = new CastSpecification<FakeType, object>(specification);

                var expected = sut.GetExpression();
                var result = (Expression) sut;

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Expression) (CastSpecification<FakeType, object>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class FuncOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnIsSatisfiedByFunction()
            {
                ISpecification<object> specification = MockComplexSpecification<object>.True();
                var sut = new CastSpecification<FakeType, object>(specification);
                Func<FakeType, bool> expected = sut.IsSatisfiedBy;

                var result = (Func<FakeType, bool>) sut;

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception =
                    Record.Exception(() => (Func<FakeType, bool>) (CastSpecification<FakeType, object>) null);

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }
        }
    }
}