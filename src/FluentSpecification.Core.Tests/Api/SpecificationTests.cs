using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Mocks;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Core.Tests.Api
{
    [UsedImplicitly]
    public partial class SpecificationTests
    {
        public class AsPredicate
        {
            [Fact]
            public void CorrectSpecification_ReturnIsSatisfiedByFunction()
            {
                var sut = MockSpecification.True();
                Func<object, bool> expected = sut.IsSatisfiedBy;

                var result = sut.AsPredicate();

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSpecification_Exception()
            {
                var exception = Record.Exception(() => ((ISpecification<object>) null).AsPredicate());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class AsExpression
        {
            [Fact]
            public void ILinqSpecification_ReturnBaseExpression()
            {
                Expression<Func<object, bool>> expected = candidate => true;
                ISpecification<object> sut = new MockLinqSpecification<object>(expected);

                var result = sut.AsExpression();

                Assert.NotNull(result);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void ISpecification_ReturnIsSatisfiedByExecutionInExpression()
            {
                var sut = MockSpecification.True();

                var expression = sut.AsExpression();
                var result = expression.ToString();

                Assert.Matches(@"candidate => .*\.IsSatisfiedBy\(candidate\)", result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSpecification_Exception()
            {
                var exception = Record.Exception(() => ((ISpecification<object>) null).AsExpression());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class AsComplexSpecification
        {
            [Fact]
            public void IComplexSpecification_ReturnSelf()
            {
                ISpecification<object> sut = MockComplexSpecification.True();

                var result = sut.AsComplexSpecification();

                Assert.Equal(sut, result);
            }

            [Fact]
            public void ISpecification_ReturnNewSpecificationAdapterObject()
            {
                var sut = MockSpecification.True();

                var result = sut.AsComplexSpecification();

                Assert.NotNull(result);
                Assert.NotEqual(sut, result);
                Assert.IsType<SpecificationAdapter<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSpecification_Exception()
            {
                var exception = Record.Exception(() => ((ISpecification<object>) null).AsComplexSpecification());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class Not
        {
            [Fact]
            public void CorrectSpecification_ReturnNotSpecificationObject()
            {
                var sut = MockSpecification.True();

                var result = sut.Not();

                Assert.NotNull(result);
                Assert.IsType<NotSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() => ((ISpecification<object>) null).Not());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}