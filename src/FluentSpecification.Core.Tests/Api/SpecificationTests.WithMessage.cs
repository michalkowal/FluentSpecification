using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Tests.Mocks;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace FluentSpecification.Core.Tests.Api
{
    public partial class SpecificationTests
    {
        public class WithMessage
        {
            [Fact]
            public void CorrectSpecification_ReturnTrasnlatableSpecificationObject()
            {
                var sut = MockSpecification.True();

                var withMessage = sut.WithMessage("Message");

                Assert.NotNull(withMessage);
                Assert.IsType<TranslatableSpecification<object>>(withMessage);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() => ((ISpecification<object>)null).WithMessage("Message"));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}
