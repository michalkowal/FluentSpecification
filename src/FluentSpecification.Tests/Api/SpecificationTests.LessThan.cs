using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeLessThan_ReturnLessThanSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new LessThanSpecification<int>(0, comparer);

            var sut = new MockCompositeSpecification<int>().LessThan(0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeLessThanProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new LessThanSpecification<int>(0, comparer));

            var sut = new MockCompositeSpecification<FakeType>().LessThan(
                ft => ft.First, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeLessThan_ReturnLessThanSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new LessThanSpecification<int>(0, comparer);

            var sut = Specification.LessThan(0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeLessThanProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new LessThanSpecification<int>(0, comparer));

            var sut = Specification.LessThan<FakeType, int>(
                ft => ft.First, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}