using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Sdk;
using FluentSpecification.Tests.Sdk.Framework;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    [SpecificationData(typeof(MatchData))]
    [SpecificationFactoryData(typeof(MatchFactory))]
    public class MatchSpecificationTests : ComplexNegatableSpecificationTests<MatchSpecificationTests>
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [Trait("Category", "Constructor")]
        public void Constructor_IncorrectPattern_ArgumentException(string pattern)
        {
            var exception = Record.Exception(() =>
                new MatchSpecification(pattern));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
        }
    }
}