using FluentSpecification.Core.Tests.Mocks;
using JetBrains.Annotations;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace FluentSpecification.Core.Tests
{
    [UsedImplicitly]
    public partial class TranslatableSpecificationTests
    {
        public class Constructor
        {
            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() =>
                    new TranslatableSpecification<object>(null, "Custom error message"));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [InlineData(null)]
            [InlineData("")]
            public void IncorrectMessage_ArgumentException(string message)
            {
                var exception = Record.Exception(() =>
                    new TranslatableSpecification<object>(new MockCommonSpecification<object>(), message));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }
        }
    }
}
