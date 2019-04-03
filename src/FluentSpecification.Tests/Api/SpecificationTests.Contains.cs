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
        public void InvokeCompositeContains_ReturnContainsSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new ContainsSpecification<FakeType, int>(0, comparer, true);

            var sut = new MockCompositeSpecification<FakeType>().Contains(0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeContainsProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, IEnumerable<int>>(
                ft => ft.Fourth, new ContainsSpecification<IEnumerable<int>, int>(0, comparer, true));

            var sut = new MockCompositeSpecification<FakeType>().Contains(
                ft => ft.Fourth, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeContains_ReturnContainsSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new ContainsSpecification<FakeType, int>(0, comparer, true);

            var sut = Specification.Contains<FakeType, int>(0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeContainsProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, IEnumerable<int>>(
                ft => ft.Fourth, new ContainsSpecification<IEnumerable<int>, int>(0, comparer, true));

            var sut = Specification.Contains<FakeType, int>(
                ft => ft.Fourth, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}