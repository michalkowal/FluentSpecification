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
        public void InvokeAll_ReturnAllSpecification()
        {
            var specification = MockComplexSpecification<int>.True();
            var expected = new AllSpecification<FakeType, int>(specification, true);

            var sut = Specification.All<FakeType, int>(specification);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeAllProperty_ReturnPropertySpecification()
        {
            var specification = MockComplexSpecification<int>.True();
            var expected = new PropertySpecification<FakeType, IEnumerable<int>>(
                ft => ft.Fourth, new AllSpecification<IEnumerable<int>, int>(specification, true));

            var sut = Specification.All<FakeType, int>(
                ft => ft.Fourth, specification);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeAll_ReturnAllSpecification()
        {
            var specification = MockComplexSpecification<int>.True();
            var expected = new AllSpecification<FakeType, int>(specification, true);

            var sut = new MockCompositeSpecification<FakeType>().All(specification);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeAllProperty_ReturnPropertySpecification()
        {
            var specification = MockComplexSpecification<int>.True();
            var expected = new PropertySpecification<FakeType, IEnumerable<int>>(
                ft => ft.Fourth, new AllSpecification<IEnumerable<int>, int>(specification, true));

            var sut = new MockCompositeSpecification<FakeType>().All(
                ft => ft.Fourth, specification);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}