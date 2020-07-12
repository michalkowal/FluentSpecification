using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using FluentSpecification.Tests.Sdk.Framework;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    [SpecificationData(typeof(GreaterThanOrEqualData))]
    [SpecificationFactoryData(typeof(GreaterThanOrEqualFactory))]
    public class GreaterThanOrEqualSpecificationTests : ComplexNegatableSpecificationTests<GreaterThanOrEqualSpecificationTests>
    {
        [Fact]
        [Trait("Category", "Constructor")]
        public void Constructor_NotComparableType_Exception()
        {
            var exception = Record.Exception(() => new GreaterThanOrEqualSpecification<FakeType>(new FakeType()));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
        }
    }
}