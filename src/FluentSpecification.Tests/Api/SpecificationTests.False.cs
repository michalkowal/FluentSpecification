using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeFalse_ReturnFalseSpecification()
        {
            var expected = new FalseSpecification();

            var sut = new MockCompositeSpecification<bool>().False();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeFalseProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, bool>(
                ft => ft.Inter.Third, new FalseSpecification());

            var sut = new MockCompositeSpecification<FakeType>().False(
                ft => ft.Inter.Third);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeFalse_ReturnFalseSpecification()
        {
            var expected = new FalseSpecification();

            var sut = Specification.False();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeFalseProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, bool>(
                ft => ft.Inter.Third, new FalseSpecification());

            var sut = Specification.False<FakeType>(
                ft => ft.Inter.Third);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}