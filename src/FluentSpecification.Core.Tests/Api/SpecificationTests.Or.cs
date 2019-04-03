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
        public class Or
        {
            [Fact]
            public void CorrectSpecification_ReturnOrSpecificationObject()
            {
                var other = MockSpecification.True();
                var sut = MockSpecification.True();

                var result = sut.Or(other);

                Assert.NotNull(result);
                Assert.IsType<OrSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var other = MockSpecification.True();

                var exception = Record.Exception(() => ((ISpecification<object>) null).Or(other));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class OrWithNew
        {
            [Fact]
            public void CorrectSpecification_ReturnOrSpecificationObject()
            {
                var sut = MockSpecification.True();

                var result = sut.Or<object, TrueMockSpecification>();

                Assert.NotNull(result);
                Assert.IsType<OrSpecification<object>>(result);
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

        public class OrFluentApi
        {
            [Fact]
            public void CorrectSpecification_ReturnProxyObject()
            {
                var sut = MockSpecification.True();

                var result = sut.Or();

                Assert.NotNull(result);
                Assert.IsType<OrFluentProxy<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() => ((ISpecification<object>) null).Or());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}