using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class ExpressionSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Fact]
            public void FalseExpression_ReturnFalse()
            {
                Expression<Func<object, bool>> expression = candidate => false;
                var sut = new ExpressionSpecification<object>(expression);

                var result = sut.IsSatisfiedBy(new object());

                Assert.False(result);
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                Expression<Func<object, bool>> expression = candidate => true;
                var sut = new ExpressionSpecification<object>(expression);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.Null(exception);
            }

            [Fact]
            public void TrueExpression_ReturnTrue()
            {
                Expression<Func<object, bool>> expression = candidate => true;
                var sut = new ExpressionSpecification<object>(expression);

                var result = sut.IsSatisfiedBy(new object());

                Assert.True(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Fact]
            public void FalseExpression_ReturnExpectedResultObject()
            {
                var dum = new object();
                Expression<Func<object, bool>> expression = candidate => false;
                var expected = new SpecificationResult(false, "ExpressionSpecification<Object>+Failed",
                    new SpecificationInfo(typeof(ExpressionSpecification<object>), new Dictionary<string, object>
                    {
                        {"Expression", expression}
                    }, dum, "Specification doesn't meet expression: [candidate => False]"));
                var sut = new ExpressionSpecification<object>(expression);

                var overall = sut.IsSatisfiedBy(dum, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                Expression<Func<object, bool>> expression = candidate => true;
                var sut = new ExpressionSpecification<object>(expression);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

                Assert.Null(exception);
            }

            [Fact]
            public void TrueExpression_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult("ExpressionSpecification<Object>");
                Expression<Func<object, bool>> expression = candidate => true;
                var sut = new ExpressionSpecification<object>(expression);

                var overall = sut.IsSatisfiedBy(new object(), out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}