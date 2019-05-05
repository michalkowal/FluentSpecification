using System;
using System.Diagnostics.CodeAnalysis;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class IsTypeSpecificationTests
    {
        public class Constructor
        {
            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullExpected_Exception()
            {
                var exception = Record.Exception(() => new IsTypeSpecification<FakeType>(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}