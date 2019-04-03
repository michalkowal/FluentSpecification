using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class GreaterThanOrEqualSpecificationTests
    {
        public class Constructor
        {
            [Fact]
            public void NotComparableType_Exception()
            {
                var exception = Record.Exception(() => new GreaterThanOrEqualSpecification<FakeType>(new FakeType()));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }
        }
    }
}