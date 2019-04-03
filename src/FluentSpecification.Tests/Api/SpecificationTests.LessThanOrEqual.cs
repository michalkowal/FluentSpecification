using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeLessThanOrEqual_ReturnLessThanOrEqualSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new LessThanOrEqualSpecification<int>(0, comparer);

            var sut = new MockCompositeSpecification<int>().LessThanOrEqual(0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeLessThanOrEqualProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new LessThanOrEqualSpecification<int>(0, comparer));

            var sut = new MockCompositeSpecification<FakeType>().LessThanOrEqual(
                ft => ft.First, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeLessThanOrEqual_ReturnLessThanOrEqualSpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new LessThanOrEqualSpecification<int>(0, comparer);

            var sut = Specification.LessThanOrEqual(0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeLessThanOrEqualProperty_ReturnPropertySpecification()
        {
            var comparer = new FakeIntComparer();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new LessThanOrEqualSpecification<int>(0, comparer));

            var sut = Specification.LessThanOrEqual<FakeType, int>(
                ft => ft.First, 0, comparer);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}