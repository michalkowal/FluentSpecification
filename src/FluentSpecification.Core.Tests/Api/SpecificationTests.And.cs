using System;
using System.Diagnostics.CodeAnalysis;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Core.Utils;
using Xunit;

namespace FluentSpecification.Core.Tests.Api
{
    public partial class SpecificationTests
    {
        public class And
        {
            [Fact]
            public void CorrectSpecification_ReturnAndSpecificationObject()
            {
                var other = MockSpecification.True();
                var sut = MockSpecification.True();

                var result = sut.And(other);

                Assert.NotNull(result);
                Assert.IsType<AndSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var other = MockSpecification.True();

                var exception = Record.Exception(() => ((ISpecification<object>) null).And(other));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class AndWithNew
        {
            [Fact]
            public void CorrectSpecification_ReturnAndSpecificationObject()
            {
                var sut = MockSpecification.True();

                var result = sut.And<object, TrueMockSpecification>();

                Assert.NotNull(result);
                Assert.IsType<AndSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() =>
                    ((ISpecification<object>) null).And<object, TrueMockSpecification>());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class AndFluentApi
        {
            [Fact]
            public void CorrectSpecification_ReturnProxyObject()
            {
                var sut = MockSpecification.True();

                var result = sut.And();

                Assert.NotNull(result);
                Assert.IsType<AndFluentProxy<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() => ((ISpecification<object>) null).And());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}