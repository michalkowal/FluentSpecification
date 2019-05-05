using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    [UsedImplicitly]
    public partial class PropertySpecificationTests
    {
        public class Constructor
        {
            [Theory]
            [IncorrectData(typeof(PropertySelectorData))]
            public void IncorrectSelectorExpression_ArgumentException<T>(Expression<Func<FakeType, T>> selector)
            {
                var specification = MockSpecification<T>.True();
                var exception = Record.Exception(() =>
                    new PropertySpecification<FakeType, T>(selector, specification));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelector_ArgumentNullException()
            {
                var specification = MockSpecification<string>.True();
                var exception = Record.Exception(() =>
                    new PropertySpecification<FakeType, string>(null, specification));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSpecification_ArgumentNullException()
            {
                Expression<Func<FakeType, string>> selector = ft => ft.Second;
                var exception = Record.Exception(() =>
                    new PropertySpecification<FakeType, string>(selector, null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class ExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnExpression()
            {
                Expression<Func<FakeType, string>> selector = ft => ft.Second;
                var specification = MockSpecification<string>.True();
                var sut = new PropertySpecification<FakeType, string>(selector, specification);

                var expected = sut.GetExpression();
                var expression = (Expression<Func<FakeType, bool>>) sut;

                Assert.Equal(expected, expression);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() =>
                    (Expression<Func<FakeType, bool>>) (PropertySpecification<FakeType, string>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class AbstractExpressionOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnExpressionWithParameterFromSelector()
            {
                Expression<Func<FakeType, string>> selector = ft => ft.Second;
                var specification = MockSpecification<string>.True();
                var sut = new PropertySpecification<FakeType, string>(selector, specification);

                var expected = sut.GetExpression();
                var result = (Expression) sut;

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() => (Expression) (PropertySpecification<FakeType, string>) null);

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class FuncOperator
        {
            [Fact]
            public void CastCorrectSpecification_ReturnIsSatisfiedByFunction()
            {
                Expression<Func<FakeType, string>> selector = ft => ft.Second;
                ISpecification<string> specification = MockComplexSpecification<string>.True();
                var sut = new PropertySpecification<FakeType, string>(selector, specification);
                Func<FakeType, bool> expected = sut.IsSatisfiedBy;

                var result = (Func<FakeType, bool>) sut;

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void CastNull_Exception()
            {
                var exception = Record.Exception(() =>
                    (Func<FakeType, bool>) (PropertySpecification<FakeType, string>) null);

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }
        }
    }
}