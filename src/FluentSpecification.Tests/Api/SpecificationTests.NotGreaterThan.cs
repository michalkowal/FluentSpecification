using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotGreaterThan_ReturnNotSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new NotSpecification<int>(
                new GreaterThanSpecification<int>(0, comparer));

            var sut = new MockCompositeSpecification<int>().NotGreaterThan(0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotGreaterThanProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new NotSpecification<int>(
                    new GreaterThanSpecification<int>(0, comparer)));

            var sut = new MockCompositeSpecification<FakeType>().NotGreaterThan(
                ft => ft.First, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotGreaterThan_ReturnNotSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new NotSpecification<int>(
                new GreaterThanSpecification<int>(0, comparer));

            var sut = Specification.NotGreaterThan(0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotGreaterThanProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new NotSpecification<int>(
                    new GreaterThanSpecification<int>(0, comparer)));

            var sut = Specification.NotGreaterThan<FakeType, int>(
                ft => ft.First, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}