using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeAny_ReturnAnySpecification()
        {
            var specification = MockComplexSpecification<int>.True();
            var expected = new AnySpecification<FakeType, int>(specification, true);

            var sut = Specification.Any<FakeType, int>(specification);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeAnyProperty_ReturnPropertySpecification()
        {
            var specification = MockComplexSpecification<int>.True();
            var expected = new PropertySpecification<FakeType, IEnumerable<int>>(
                ft => ft.Fourth, new AnySpecification<IEnumerable<int>, int>(specification, true));

            var sut = Specification.Any<FakeType, int>(
                ft => ft.Fourth, specification);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeAny_ReturnAnySpecification()
        {
            var specification = MockComplexSpecification<int>.True();
            var expected = new AnySpecification<FakeType, int>(specification, true);

            var sut = new MockCompositeSpecification<FakeType>().Any(specification);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeAnyProperty_ReturnPropertySpecification()
        {
            var specification = MockComplexSpecification<int>.True();
            var expected = new PropertySpecification<FakeType, IEnumerable<int>>(
                ft => ft.Fourth, new AnySpecification<IEnumerable<int>, int>(specification, true));

            var sut = new MockCompositeSpecification<FakeType>().Any(
                ft => ft.Fourth, specification);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}