using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeInclusiveBetween_ReturnInclusiveBetweenSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new InclusiveBetweenSpecification<int>(0, 0, comparer);

            var sut = new MockCompositeSpecification<int>().InclusiveBetween(0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeInclusiveBetweenProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new InclusiveBetweenSpecification<int>(0, 0, comparer));

            var sut = new MockCompositeSpecification<FakeType>().InclusiveBetween(
                ft => ft.First, 0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeInclusiveBetween_ReturnInclusiveBetweenSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new InclusiveBetweenSpecification<int>(0, 0, comparer);

            var sut = Specification.InclusiveBetween(0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeInclusiveBetweenProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new InclusiveBetweenSpecification<int>(0, 0, comparer));

            var sut = Specification.InclusiveBetween<FakeType, int>(
                ft => ft.First, 0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}