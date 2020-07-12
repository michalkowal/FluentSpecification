using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Sdk;
using FluentSpecification.Tests.Sdk.Framework;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    [SpecificationData(typeof(ExpressionData))]
    [SpecificationFactoryData(typeof(ExpressionFactory))]
    public class ExpressionSpecificationTests : ComplexSpecificationTests<ExpressionSpecificationTests>
    {
        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        [Trait("Category", "Constructor")]
        public void Constructor_NullExpression_ArgumentNullException()
        {
            var exception = Record.Exception(() => new ExpressionSpecification<object>(null));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact]
        [Trait("Category", "GetExpression")]
        public void GetExpression_CorrectSpecification_ReturnBaseExpression()
        {
            Expression<Func<object, bool>> expected = candidate => true;
            var sut = new ExpressionSpecification<object>(expected);

            var result = sut.GetExpression();

            Assert.NotNull(result);
            Assert.Equal(expected, result);
        }

        [Fact]
        [Trait("Category", "GetExpression")]
        public void GetExpression_InvokeNull_NotRaiseException()
        {
            Expression<Func<object, bool>> expression = candidate => true;
            var sut = new ExpressionSpecification<object>(expression);

            var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

            Assert.Null(exception);
        }

        [Fact]
        [Trait("Category", "IsSatisfiedBy")]
        public void IsSatisfiedBy_NullCandidate_NoException()
        {
            Expression<Func<object, bool>> expression = candidate => true;
            var sut = new ExpressionSpecification<object>(expression);

            var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

            Assert.Null(exception);
        }

        [Fact]
        [Trait("Category", "IsSatisfiedBy")]
        public void IsSatisfiedByValidation_NullCandidate_NoException()
        {
            Expression<Func<object, bool>> expression = candidate => true;
            var sut = new ExpressionSpecification<object>(expression);

            var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

            Assert.Null(exception);
        }
    }
}