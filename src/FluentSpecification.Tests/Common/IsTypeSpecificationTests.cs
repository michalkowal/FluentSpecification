using System;
using System.Diagnostics.CodeAnalysis;
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
    [SpecificationData(typeof(IsTypeData))]
    [SpecificationFactoryData(typeof(IsTypeFactory))]
    public class IsTypeSpecificationTests : ComplexNegatableSpecificationTests<IsTypeSpecificationTests>
    {
        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        [Trait("Category", "Constructor")]
        public void Constructor_NullExpected_Exception()
        {
            var exception = Record.Exception(() => new IsTypeSpecification<FakeType>(null));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }
    }
}