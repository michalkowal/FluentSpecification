using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Framework;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    [SpecificationData(typeof(ExclusiveBetweenData))]
    [SpecificationFactoryData(typeof(ExclusiveBetweenFactory))]
    public class ExclusiveBetweenSpecificationTests : ComplexNegatableSpecificationTests<ExclusiveBetweenSpecificationTests>
    {
        [Theory]
        [IncorrectData(typeof(ExclusiveBetweenConstructorData))]
        [Trait("Category", "Constructor")]
        public void Constructor_FromGreaterThanTo_ArgumentException<T>(SpecificationFactory<T> factory)
        {
            var exception = Record.Exception(() => factory.Create());

            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
        }

        [Fact]
        [Trait("Category", "Constructor")]
        public void Constructor_NotComparableType_Exception()
        {
            var exception = Record.Exception(() =>
                new ExclusiveBetweenSpecification<FakeType>(new FakeType(), new FakeType()));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentException>(exception);
        }
    }
}