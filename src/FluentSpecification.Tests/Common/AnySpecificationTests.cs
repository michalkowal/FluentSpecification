using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class AnySpecificationTests
    {
        public class Constructor
        {
            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() =>
                    new AnySpecification<int[], int>(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class ExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnExpressionWithParameterFromSelector()
            {
                ISpecification<string> specification = MockComplexSpecification<string>.True();
                var sut = new AnySpecification<string[], string>(specification);

                var expected = sut.GetExpression().ToString();
                var sutExpression = (Expression<Func<string[], bool>>) sut;
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() =>
                    (Expression<Func<string[], bool>>) (AnySpecification<string[], string>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class AbstractExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnExpressionWithParameterFromSelector()
            {
                ISpecification<string> specification = MockComplexSpecification<string>.True();
                var sut = new AnySpecification<string[], string>(specification);

                var expected = sut.GetExpression().ToString();
                var sutExpression = (Expression) sut;
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Expression) (AnySpecification<string[], string>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class FuncOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnIsSatisfiedByFunction()
            {
                ISpecification<string> specification = MockComplexSpecification<string>.True();
                var sut = new AnySpecification<string[], string>(specification);
                Func<string[], bool> expected = sut.IsSatisfiedBy;

                var result = (Func<string[], bool>) sut;

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception =
                    Record.Exception(() => (Func<string[], bool>) (AnySpecification<string[], string>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }
    }
}