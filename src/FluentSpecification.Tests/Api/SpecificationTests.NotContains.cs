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
        public void InvokeCompositeNotContains_ReturnNotSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new NotSpecification<FakeType>(
                new ContainsSpecification<FakeType, int>(0, comparer, true));

            var sut = new MockCompositeSpecification<FakeType>().NotContains(0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotContainsProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, IEnumerable<int>>(
                ft => ft.Fourth, new NotSpecification<IEnumerable<int>>(
                    new ContainsSpecification<IEnumerable<int>, int>(0, comparer, true)));

            var sut = new MockCompositeSpecification<FakeType>().NotContains(
                ft => ft.Fourth, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotContains_ReturnNotSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new NotSpecification<FakeType>(
                new ContainsSpecification<FakeType, int>(0, comparer, true));

            var sut = Specification.NotContains<FakeType, int>(0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotContainsProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, IEnumerable<int>>(
                ft => ft.Fourth, new NotSpecification<IEnumerable<int>>(
                    new ContainsSpecification<IEnumerable<int>, int>(0, comparer, true)));

            var sut = Specification.NotContains<FakeType, int>(
                ft => ft.Fourth, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}