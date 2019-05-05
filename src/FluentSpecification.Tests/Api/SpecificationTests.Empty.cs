using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeEmpty_ReturnEmptySpecification()
        {
            var expected = new EmptySpecification<string>(true);

            var sut = new MockCompositeSpecification<string>().Empty();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeEmptyProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new EmptySpecification<string>(true));

            var sut = new MockCompositeSpecification<FakeType>().Empty(
                ft => ft.Second);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeEmpty_ReturnEmptySpecification()
        {
            var expected = new EmptySpecification<FakeType>(true);

            var sut = Specification.Empty<FakeType>();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeEmptyProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new EmptySpecification<string>(true));

            var sut = Specification.Empty<FakeType, string>(
                ft => ft.Second);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}