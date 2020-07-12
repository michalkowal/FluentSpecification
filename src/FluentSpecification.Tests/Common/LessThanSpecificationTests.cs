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
    [SpecificationData(typeof(LessThanData))]
    [SpecificationFactoryData(typeof(LessThanFactory))]
    public class LessThanSpecificationTests : ComplexNegatableSpecificationTests<LessThanSpecificationTests>
    {
        [Fact]
        [Trait("Category", "Constructor")]
        public void Constructor_NotComparableType_Exception()
        {
            var exception = Record.Exception(() => new LessThanSpecification<FakeType>(new FakeType()));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
        }
    }
}