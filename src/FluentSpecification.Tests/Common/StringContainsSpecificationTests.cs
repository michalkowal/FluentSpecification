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
    [SpecificationData(typeof(StringContainsData))]
    [SpecificationFactoryData(typeof(StringContainsFactory))]
    public class StringContainsSpecificationTests : ComplexNegatableSpecificationTests<StringContainsSpecificationTests>
    {
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [Trait("Category", "Constructor")]
        public void Constructor_EmptyExpected_Exception(string expected)
        {
            var exception = Record.Exception(() => new ContainsSpecification(expected));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }
    }
}