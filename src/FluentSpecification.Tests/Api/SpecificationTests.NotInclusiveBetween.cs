using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotInclusiveBetween_ReturnNotSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new NotSpecification<int>(
                new InclusiveBetweenSpecification<int>(0, 0, comparer));

            var sut = new MockCompositeSpecification<int>().NotInclusiveBetween(0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotInclusiveBetweenProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new NotSpecification<int>(
                    new InclusiveBetweenSpecification<int>(0, 0, comparer)));

            var sut = new MockCompositeSpecification<FakeType>().NotInclusiveBetween(
                ft => ft.First, 0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotInclusiveBetween_ReturnNotSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new NotSpecification<int>(
                new InclusiveBetweenSpecification<int>(0, 0, comparer));

            var sut = Specification.NotInclusiveBetween(0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotInclusiveBetweenProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new NotSpecification<int>(
                    new InclusiveBetweenSpecification<int>(0, 0, comparer)));

            var sut = Specification.NotInclusiveBetween<FakeType, int>(
                ft => ft.First, 0, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}