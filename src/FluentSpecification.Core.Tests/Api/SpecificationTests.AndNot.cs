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
        public class AndNot
        {
            [Fact]
            public void CorrectSpecification_ReturnAndSpecificationObject()
            {
                var other = MockSpecification.True();
                var sut = MockSpecification.True();

                var result = sut.AndNot(other);

                Assert.NotNull(result);
                Assert.IsType<AndSpecification<object>>(result);
            }

            [Fact]
            public void CorrectSpecification_ReturnAndWithNegatedRight()
            {
                var other = MockSpecification.True();
                var sut = MockSpecification.True();

                var andNot = sut.AndNot(other);
                var fieldInfo = andNot.GetType().BaseType
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

                var exception = Record.Exception(() => ((ISpecification<object>) null).AndNot(other));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class AndNotWithNew
        {
            [Fact]
            public void CorrectSpecification_ReturnAndSpecificationObject()
            {
                var sut = MockSpecification.True();

                var result = sut.AndNot<object, TrueMockSpecification>();

                Assert.NotNull(result);
                Assert.IsType<AndSpecification<object>>(result);
            }

            [Fact]
            public void CorrectSpecification_ReturnAndWithNegatedRight()
            {
                var sut = MockSpecification.True();

                var andNot = sut.AndNot<object, TrueMockSpecification>();
                var fieldInfo = andNot.GetType().BaseType
                    .GetField("_right", BindingFlags.Instance | BindingFlags.NonPublic);
                var result = fieldInfo.GetValue(andNot);

                Assert.NotNull(result);
                Assert.IsType<NotSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() =>
                    ((ISpecification<object>) null).AndNot<object, TrueMockSpecification>());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class AndNotFluentApi
        {
            [Fact]
            public void CorrectSpecification_ReturnProxyObject()
            {
                var sut = MockSpecification.True();

                var result = sut.AndNot();

                Assert.NotNull(result);
                Assert.IsType<AndNotFluentProxy<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() => ((ISpecification<object>) null).AndNot());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}