using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotLessThanOrEqual_ReturnNotSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new NotSpecification<int>(
                new LessThanOrEqualSpecification<int>(0, comparer));

            var sut = new MockCompositeSpecification<int>().NotLessThanOrEqual(0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotLessThanOrEqualProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new NotSpecification<int>(
                    new LessThanOrEqualSpecification<int>(0, comparer)));

            var sut = new MockCompositeSpecification<FakeType>().NotLessThanOrEqual(
                ft => ft.First, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotLessThanOrEqual_ReturnNotSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new NotSpecification<int>(
                new LessThanOrEqualSpecification<int>(0, comparer));

            var sut = Specification.NotLessThanOrEqual(0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotLessThanOrEqualProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new NotSpecification<int>(
                    new LessThanOrEqualSpecification<int>(0, comparer)));

            var sut = Specification.NotLessThanOrEqual<FakeType, int>(
                ft => ft.First, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}