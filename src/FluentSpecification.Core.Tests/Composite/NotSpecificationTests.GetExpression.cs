﻿using System.Collections.Generic;
using FluentSpecification.Abstractions;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    public partial class NotSpecificationTests
    {
        public class GetExpression
        {
            [Fact]
            public void InvokeCorrectData_ReturnTrue()
            {
                var specification = MockComplexSpecification.False();

                var sut = new NotSpecification<object>(specification);

                var result = sut.GetExpression().Compile().Invoke(new object());

                Assert.True(result);
            }

            [Fact]
            public void InvokeNegatableCorrectData_ReturnTrue()
            {
                var specification = MockNegatableComplexSpecification.False();

                var sut = new NotSpecification<object>(specification);

                var result = sut.GetExpression().Compile().Invoke(new object());

                Assert.True(result);
            }

            [Fact]
            public void InvokeIncorrectData_ReturnTrue()
            {
                var specification = MockComplexSpecification.True();

                var sut = new NotSpecification<object>(specification);

                var result = sut.GetExpression().Compile().Invoke(new object());

                Assert.False(result);
            }

            [Fact]
            public void InvokeNegatableIncorrectData_ReturnTrue()
            {
                var specification = MockNegatableComplexSpecification.True();

                var sut = new NotSpecification<object>(specification);

                var result = sut.GetExpression().Compile().Invoke(new object());

                Assert.False(result);
            }

            [Fact]
            public void CorrectSpecification_ReturnNegatedExpression()
            {
                var specification = MockSpecification.True();
                var sut = new NotSpecification<object>(specification);

                var expression = sut.GetExpression();
                var result = expression.ToString();

                Assert.Matches(@"candidate => Not\(.*\.IsSatisfiedBy\(candidate\)\)", result);
            }

            [Fact]
            public void InvokeNull_NotRaiseException()
            {
                var specification = MockComplexSpecification.True();
                var sut = new NotSpecification<object>(specification);

                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.Null(exception);
            }

            [Fact]
            public void InvokeRelatedTypes_NoException()
            {
                var specification = MockComplexSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new NotSpecification<ChildFakeType>(specification);
                    sut.GetExpression().Compile().Invoke(new ChildFakeType());
                });

                Assert.Null(exception);
            }

            [Fact]
            public void InvokeRelatedNegatableTypes_NoException()
            {
                var specification = MockNegatableComplexSpecification<IEnumerable<char>>.True();

                var exception = Record.Exception(() =>
                {
                    var sut = new NotSpecification<ChildFakeType>(specification);
                    sut.GetExpression().Compile().Invoke(new ChildFakeType());
                });

                Assert.Null(exception);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnBaseExpressionAsAbstractExpression()
            {
                var specification = MockSpecification.True();
                var sut = new NotSpecification<object>(specification);

                var expected = sut.GetExpression();
                var result = ((ILinqSpecification) sut).GetExpression();

                Assert.Equal(expected, result);
            }
        }
    }
}