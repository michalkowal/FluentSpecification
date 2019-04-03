using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeTrue_ReturnTrueSpecification()
        {
            var expected = new TrueSpecification();

            var sut = new MockCompositeSpecification<bool>().True();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeTrueProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, bool>(
                ft => ft.Inter.Third, new TrueSpecification());

            var sut = new MockCompositeSpecification<FakeType>().True(
                ft => ft.Inter.Third);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeTrue_ReturnTrueSpecification()
        {
            var expected = new TrueSpecification();

            var sut = Specification.True();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeTrueProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, bool>(
                ft => ft.Inter.Third, new TrueSpecification());

            var sut = Specification.True<FakeType>(
                ft => ft.Inter.Third);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}