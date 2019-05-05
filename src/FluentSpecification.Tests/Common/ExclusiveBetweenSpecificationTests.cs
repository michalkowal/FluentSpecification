using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class ExclusiveBetweenSpecificationTests
    {
        public class Constructor
        {
            [Theory]
            [IncorrectData(typeof(ExclusiveBetweenConstructorData))]
            public void FromGreaterThanTo_ArgumentException<T>(T from, T to)
            {
                var exception = Record.Exception(() => new ExclusiveBetweenSpecification<T>(from, to));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }

            [Fact]
            public void NotComparableType_Exception()
            {
                var exception = Record.Exception(() =>
                    new ExclusiveBetweenSpecification<FakeType>(new FakeType(), new FakeType()));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentException>(exception);
            }
        }
    }
}