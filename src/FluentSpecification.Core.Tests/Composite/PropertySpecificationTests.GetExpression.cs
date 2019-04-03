using System;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    public partial class PropertySpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(PropertyExpressionData))]
            public void InvokeTrueSpecification_ReturnTrue<T>(FakeType candidate,
                Expression<Func<FakeType, T>> selector)
            {
                var specification = MockSpecification<T>.True();
                var sut = new PropertySpecification<FakeType, T>(selector, specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(PropertyExpressionData))]
            public void InvokeFalseSpecification_ReturnFalse<T>(FakeType candidate,
                Expression<Func<FakeType, T>> selector)
            {
                candidate = candidate.Second != "null" ? candidate : null;
                var specification = MockSpecification<T>.False();
                var sut = new PropertySpecification<FakeType, T>(selector, specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void CorrectSpecification_ReturnExpressionAsAbstractExpression()
            {
                Expression<Func<FakeType, string>> selector = ft => ft.Second;
                var specification = MockSpecification<string>.True();
                var sut = new PropertySpecification<FakeType, string>(selector, specification);

                var expected = sut.GetExpression();
                var result = ((ILinqSpecification) sut).GetExpression();

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CorrectSpecification_ReturnExpressionWithParameterFromSelector()
            {
                Expression<Func<FakeType, string>> selector = ft => ft.Second;
                var specification = MockSpecification<string>.True();
                var sut = new PropertySpecification<FakeType, string>(selector, specification);

                var sutExpression = sut.GetExpression();
                var result = sutExpression.ToString();

                Assert.Matches(@"ft => .*.IsSatisfiedBy\(ft.Second\)", result);
            }

            [Fact]
            public void InvokeNullCandidate_RaiseException()
            {
                Expression<Func<FakeType, string>> selector = ft => ft.Second;
                var specification = MockSpecification<string>.True();
                var sut = new PropertySpecification<FakeType, string>(selector, specification);

                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void InvokeNullSubPropertyValue_RaiseException()
            {
                Expression<Func<FakeType, bool>> selector = ft => ft.Inter.Third;
                var specification = MockSpecification<bool>.True();
                var sut = new PropertySpecification<FakeType, bool>(selector, specification);

                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(new FakeType()));

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }
    }
}