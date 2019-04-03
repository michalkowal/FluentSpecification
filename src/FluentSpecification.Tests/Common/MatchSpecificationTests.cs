using System;
using FluentSpecification.Common;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class MatchSpecificationTests
    {
        public class Constructor
        {
            [Theory]
            [InlineData(null)]
            [InlineData("")]
            public void IncorrectPattern_ArgumentException(string pattern)
            {
                var exception = Record.Exception(() =>
                    new MatchSpecification(pattern));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }
        }
    }
}