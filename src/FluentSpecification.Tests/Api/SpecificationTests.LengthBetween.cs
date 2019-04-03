using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeLengthBetween_ReturnLengthBetweenSpecification()
        {
            var expected = new LengthBetweenSpecification<string>(0, 0, true);

            var sut = new MockCompositeSpecification<string>().LengthBetween(0, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeLengthBetweenProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new LengthBetweenSpecification<string>(0, 0, true));

            var sut = new MockCompositeSpecification<FakeType>().LengthBetween(
                ft => ft.Second, 0, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeLengthBetweenBetween_ReturnLengthBetweenSpecification()
        {
            var expected = new LengthBetweenSpecification<FakeType>(0, 0, true);

            var sut = Specification.LengthBetween<FakeType>(0, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeLengthBetweenProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new LengthBetweenSpecification<string>(0, 0, true));

            var sut = Specification.LengthBetween<FakeType, string>(
                ft => ft.Second, 0, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}