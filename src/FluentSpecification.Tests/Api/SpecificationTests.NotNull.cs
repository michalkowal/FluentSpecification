using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotNull_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new NullSpecification<string>());

            var sut = new MockCompositeSpecification<string>().NotNull();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotNullProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new NullSpecification<string>()));

            var sut = new MockCompositeSpecification<FakeType>().NotNull(
                ft => ft.Second);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotNull_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new NullSpecification<string>());

            var sut = Specification.NotNull<string>();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotNullProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new NullSpecification<string>()));

            var sut = Specification.NotNull<FakeType, string>(
                ft => ft.Second);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}