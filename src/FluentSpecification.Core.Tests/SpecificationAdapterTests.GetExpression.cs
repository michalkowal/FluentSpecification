using System;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests
{
    public partial class SpecificationAdapterTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(AdapterData))]
            public void InvokeTrueSpecification_ReturnTrue(bool isLinq)
            {
                var specification = isLinq ? new MockLinqSpecification<object>(obj => true) : MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var result = sut.GetExpression().Compile().Invoke(new object());

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(AdapterData))]
            public void InvokeFalseSpecification_ReturnFalse(bool isLinq)
            {
                var specification =
                    isLinq ? new MockLinqSpecification<object>(obj => false) : MockSpecification.False();
                var sut = new SpecificationAdapter<object>(specification);

                var result = sut.GetExpression().Compile().Invoke(new object());

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(AdapterData))]
            public void InvokeNull_NotRaiseException(bool isLinq)
            {
                var specification = isLinq ? new MockLinqSpecification<object>(obj => true) : MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.Null(exception);
            }

            [Fact]
            public void CorrectLinqSpecification_ReturnBaseExpression()
            {
                Expression<Func<object, bool>> expected = obj => true;
                var specification = new MockLinqSpecification<object>(expected);
                var sut = new SpecificationAdapter<object>(specification);

                var result = sut.GetExpression();

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CorrectSpecification_ReturnIsSatisfiedByExecutionInExpression()
            {
                var specification = MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var expression = sut.GetExpression();
                var result = expression.ToString();

                Assert.Matches(@"candidate => .*\.IsSatisfiedBy\(candidate\)", result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var specification = MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var expected = sut.GetExpression();
                var result = ((ILinqSpecification) sut).GetExpression();

                Assert.Equal(expected.ToString(), result.ToString());
            }
        }
    }
}