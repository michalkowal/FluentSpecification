using System;
using System.Linq.Expressions;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests
{
    public partial class SpecificationAdapterTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(AdapterData), AsNegation = true)]
            public void InvokeFalseSpecification_ReturnTrue(bool isNegatable)
            {
                var specification = isNegatable
                    ? new MockLinqSpecification<object>(obj => false, obj => true)
                    : MockSpecification.False();
                var sut = new SpecificationAdapter<object>(specification);

                var result = sut.GetNegationExpression().Compile().Invoke(new object());

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(AdapterData), AsNegation = true)]
            public void InvokeFalseSpecification_ReturnFalse(bool isNegatable)
            {
                var specification = isNegatable
                    ? new MockLinqSpecification<object>(obj => true, obj => false)
                    : MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var result = sut.GetNegationExpression().Compile().Invoke(new object());

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(AdapterData), AsNegation = true)]
            public void InvokeNull_NotRaiseException(bool isNegatable)
            {
                var specification = isNegatable
                    ? new MockLinqSpecification<object>(obj => true, obj => false)
                    : MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var exception = Record.Exception(() => sut.GetNegationExpression().Compile().Invoke(null));

                Assert.Null(exception);
            }

            [Fact]
            public void CorrectLinqSpecification_ReturnBaseNegationExpression()
            {
                Expression<Func<object, bool>> expected = obj => false;
                var specification = new MockLinqSpecification<object>(obj => true, expected);
                var sut = new SpecificationAdapter<object>(specification);

                var result = sut.GetNegationExpression();

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CorrectNegatableSpecification_ReturnIsNotSatisfiedByExecutionInExpression()
            {
                var specification = MockNegatableSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var expression = sut.GetNegationExpression();
                var result = expression.ToString();

                Assert.Matches(@"candidate => .*.IsNotSatisfiedBy\(candidate\)", result);
            }

            [Fact]
            public void CorrectSpecification_ReturnIsSatisfiedByNegationExecutionInExpression()
            {
                var specification = MockSpecification.True();
                var sut = new SpecificationAdapter<object>(specification);

                var expression = sut.GetNegationExpression();
                var result = expression.ToString();

                Assert.Matches(@"candidate => Not\(.*\.IsSatisfiedBy\(candidate\)\)", result);
            }
        }
    }
}