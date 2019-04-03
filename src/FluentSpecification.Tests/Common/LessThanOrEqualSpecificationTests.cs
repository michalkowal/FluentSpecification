using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class LessThanOrEqualSpecificationTests
    {
        public class Constructor
        {
            [Fact]
            public void NotComparableType_Exception()
            {
                var exception = Record.Exception(() => new LessThanOrEqualSpecification<FakeType>(new FakeType()));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }
        }
    }
}