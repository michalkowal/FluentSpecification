using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotExclusiveBetween_ReturnNotSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new NotSpecification<int>(
                new ExclusiveBetweenSpecification<int>(0, 0, comparer));

            var sut = new MockCompositeSpecification<int>().NotExclusiveBetween(0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotExclusiveBetweenProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new NotSpecification<int>(
                    new ExclusiveBetweenSpecification<int>(0, 0, comparer)));

            var sut = new MockCompositeSpecification<FakeType>().NotExclusiveBetween(
                ft => ft.First, 0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotExclusiveBetween_ReturnNotSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new NotSpecification<int>(
                new ExclusiveBetweenSpecification<int>(0, 0, comparer));

            var sut = Specification.NotExclusiveBetween(0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotExclusiveBetweenProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new NotSpecification<int>(
                    new ExclusiveBetweenSpecification<int>(0, 0, comparer)));

            var sut = Specification.NotExclusiveBetween<FakeType, int>(
                ft => ft.First, 0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}