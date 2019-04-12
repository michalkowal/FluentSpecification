using System;
using System.Collections.Generic;
using FluentSpecification.Abstractions;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    public partial class CastSpecificationTests
    {
        public class GetExpression
        {
            [Fact]
            public void CorrectSpecification_ReturnExpressionAsAbstractExpression()
            {
                var specification = MockSpecification<object>.True();
                var sut = new CastSpecification<FakeType, object>(specification);

                var expected = sut.GetExpression();
                var result = ((ILinqSpecification) sut).GetExpression();

                Assert.Equal(expected, result);
            }

            [Fact]
            public void CorrectSpecification_ReturnExpressionWithParameterFromSelector()
            {
                var specification = MockSpecification<object>.True();
                var sut = new CastSpecification<FakeType, object>(specification);

                var sutExpression = sut.GetExpression();
                var result = sutExpression.ToString();

                Assert.Matches(@"candidate => .*\.IsSatisfiedBy\(Convert\(candidate.*\)\)", result);
            }

            [Fact]
            public void InvokeCastFromBaseType_ReturnTrue()
            {
                FakeType candidate = new ChildFakeType();
                var specification = MockSpecification<ChildFakeType>.True();
                var sut = new CastSpecification<FakeType, ChildFakeType>(specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Fact]
            public void InvokeCastFromInterfaceType_ReturnTrue()
            {
                IEnumerable<char> candidate = new FakeType();
                var specification = MockSpecification<FakeType>.True();
                var sut = new CastSpecification<IEnumerable<char>, FakeType>(specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Fact]
            public void InvokeCastFromObject_ReturnTrue()
            {
                var candidate = 0;
                var specification = MockSpecification<object>.True();
                var sut = new CastSpecification<int, object>(specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Fact]
            public void InvokeCastToBaseType_ReturnTrue()
            {
                var candidate = new ChildFakeType();
                var specification = MockSpecification<FakeType>.True();
                var sut = new CastSpecification<ChildFakeType, FakeType>(specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Fact]
            public void InvokeCastToInterfaceType_ReturnTrue()
            {
                var candidate = new FakeType();
                var specification = MockSpecification<IEnumerable<char>>.True();
                var sut = new CastSpecification<FakeType, IEnumerable<char>>(specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Fact]
            public void InvokeCastToObject_ReturnTrue()
            {
                var candidate = 0;
                var specification = MockSpecification<object>.True();
                var sut = new CastSpecification<int, object>(specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Fact]
            public void InvokeFalseSpecification_ReturnFalse()
            {
                var candidate = 0;
                var specification = MockSpecification<object>.False();
                var sut = new CastSpecification<int, object>(specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvokeInvalidTypeCandidate_CastException()
            {
                var specification = MockSpecification<List<int>>.True();
                var sut = new CastSpecification<IEnumerable<int>, List<int>>(specification);

                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(new int[0]));

                Assert.NotNull(exception);
                Assert.IsType<InvalidCastException>(exception);
            }

            [Fact]
            public void InvokeNullCandidate_NoException()
            {
                var specification = MockSpecification<FakeType>.True();
                var sut = new CastSpecification<object, FakeType>(specification);

                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.Null(exception);
            }
        }
    }
}