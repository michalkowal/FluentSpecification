using System.Collections.Generic;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCast_ReturnCastSpecification()
        {
            var specification = MockComplexSpecification<IEnumerable<int>>.True();
            var expected = new CastSpecification<FakeType, IEnumerable<int>>(specification);

            var sut = Specification.Cast<FakeType, IEnumerable<int>>(specification);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCastProperty_ReturnPropertySpecification()
        {
            var specification = MockComplexSpecification<List<int>>.True();
            var expected = new PropertySpecification<FakeType, IEnumerable<int>>(
                ft => ft.Fourth, new CastSpecification<IEnumerable<int>, List<int>>(specification));

            var sut = Specification.Cast<FakeType, IEnumerable<int>, List<int>>(
                ft => ft.Fourth, specification);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeCast_ReturnCastSpecification()
        {
            var specification = MockComplexSpecification<IEnumerable<int>>.True();
            var expected = new CastSpecification<FakeType, IEnumerable<int>>(specification);

            var sut = new MockCompositeSpecification<FakeType>().Cast(specification);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeCastProperty_ReturnPropertySpecification()
        {
            var specification = MockComplexSpecification<List<int>>.True();
            var expected = new PropertySpecification<FakeType, IEnumerable<int>>(
                ft => ft.Fourth, new CastSpecification<IEnumerable<int>, List<int>>(specification));

            var sut = new MockCompositeSpecification<FakeType>().Cast(
                ft => ft.Fourth, specification);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}