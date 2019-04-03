using System;
using FluentSpecification.Common;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class StringContainsSpecificationTests
    {
        public class Constructor
        {
            [Theory]
            [InlineData("")]
            [InlineData(null)]
            public void EmptyExpected_Exception(string expected)
            {
                var exception = Record.Exception(() => new ContainsSpecification(expected));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}