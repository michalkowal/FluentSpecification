using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotEmpty_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new EmptySpecification<string>(true));

            var sut = new MockCompositeSpecification<string>().NotEmpty();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotEmptyProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new EmptySpecification<string>(true)));

            var sut = new MockCompositeSpecification<FakeType>().NotEmpty(
                ft => ft.Second);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotEmpty_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new EmptySpecification<string>(true));

            var sut = Specification.NotEmpty<string>();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotEmptyProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new EmptySpecification<string>(true)));

            var sut = Specification.NotEmpty<FakeType, string>(
                ft => ft.Second);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}