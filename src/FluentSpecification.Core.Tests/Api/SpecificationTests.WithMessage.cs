using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Tests.Mocks;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Xunit;

namespace FluentSpecification.Core.Tests.Api
{
    public partial class SpecificationTests
    {
        public class WithMessage
        {
            [Fact]
            public void CorrectSpecification_ReturnOrSpecificationObject()
            {
                var sut = MockSpecification.True();

                var withMessage = sut.WithMessage("Message");

                var fieldInfo = withMessage.GetType().GetTypeInfo()
                    .GetField("_baseSpecification", BindingFlags.Instance | BindingFlags.NonPublic);
                var result = fieldInfo.GetValue(withMessage);

                Assert.NotNull(result);
                Assert.IsType<TranslatableSpecification<object>>(result);
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
