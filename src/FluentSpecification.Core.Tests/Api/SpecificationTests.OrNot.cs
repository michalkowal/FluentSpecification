using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Core.Utils;
using Xunit;

namespace FluentSpecification.Core.Tests.Api
{
    public partial class SpecificationTests
    {
        public class OrNot
        {
            [Fact]
            public void CorrectSpecification_ReturnOrSpecificationObject()
            {
                var other = MockSpecification.True();
                var sut = MockSpecification.True();

                var result = sut.OrNot(other);

                Assert.NotNull(result);
                Assert.IsType<OrSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
            public void CorrectSpecification_ReturnOrWithNegatedRight()
            {
                var other = MockSpecification.True();
                var sut = MockSpecification.True();

                var andNot = sut.OrNot(other);
                var fieldInfo = andNot.GetType().GetTypeInfo().BaseType
                    .GetField("_right", BindingFlags.Instance | BindingFlags.NonPublic);
                var result = fieldInfo.GetValue(andNot);

                Assert.NotNull(result);
                Assert.IsType<NotSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var other = MockSpecification.True();

                var exception = Record.Exception(() => ((ISpecification<object>) null).OrNot(other));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class OrNotWithNew
        {
            [Fact]
            public void CorrectSpecification_ReturnOrSpecificationObject()
            {
                var sut = MockSpecification.True();

                var result = sut.OrNot<object, TrueMockSpecification>();

                Assert.NotNull(result);
                Assert.IsType<OrSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
            public void CorrectSpecification_ReturnOrWithNegatedRight()
            {
                var sut = MockSpecification.True();

                var andNot = sut.OrNot<object, TrueMockSpecification>();
                var fieldInfo = andNot.GetType().GetTypeInfo().BaseType
                    .GetField("_right", BindingFlags.Instance | BindingFlags.NonPublic);
                var result = fieldInfo.GetValue(andNot);

                Assert.NotNull(result);
                Assert.IsType<NotSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception =
                    Record.Exception(() => ((ISpecification<object>) null).Or<object, TrueMockSpecification>());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class OrNotFluentApi
        {
            [Fact]
            public void CorrectSpecification_ReturnProxyObject()
            {
                var sut = MockSpecification.True();

                var result = sut.OrNot();

                Assert.NotNull(result);
                Assert.IsType<OrNotFluentProxy<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() => ((ISpecification<object>) null).OrNot());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}