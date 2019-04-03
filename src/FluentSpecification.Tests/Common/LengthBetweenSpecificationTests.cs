using System;
using FluentSpecification.Common;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class LengthBetweenSpecificationTests
    {
        public class Constructor
        {
            [Fact]
            public void MinGreaterThanMax_ArgumentException()
            {
                var expression = Record.Exception(() => new LengthBetweenSpecification<string>(5, 1));

                Assert.NotNull(expression);
                Assert.IsType<ArgumentException>(expression);
            }
        }
    }
}