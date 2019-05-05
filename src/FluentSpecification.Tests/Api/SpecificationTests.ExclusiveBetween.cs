using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeExclusiveBetween_ReturnExclusiveBetweenSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new ExclusiveBetweenSpecification<int>(0, 0, comparer);

            var sut = new MockCompositeSpecification<int>().ExclusiveBetween(0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeExclusiveBetweenProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new ExclusiveBetweenSpecification<int>(0, 0, comparer));

            var sut = new MockCompositeSpecification<FakeType>().ExclusiveBetween(
                ft => ft.First, 0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeExclusiveBetween_ReturnExclusiveBetweenSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new ExclusiveBetweenSpecification<int>(0, 0, comparer);

            var sut = Specification.ExclusiveBetween(0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeExclusiveBetweenProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new ExclusiveBetweenSpecification<int>(0, 0, comparer));

            var sut = Specification.ExclusiveBetween<FakeType, int>(
                ft => ft.First, 0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}