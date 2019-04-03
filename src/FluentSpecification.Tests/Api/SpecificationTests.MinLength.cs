using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeMinLength_ReturnMinLengthSpecification()
        {
            var expected = new MinLengthSpecification<string>(0, true);

            var sut = new MockCompositeSpecification<string>().MinLength(0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeMinLengthProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new MinLengthSpecification<string>(0, true));

            var sut = new MockCompositeSpecification<FakeType>().MinLength(
                ft => ft.Second, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeMinLength_ReturnMinLengthSpecification()
        {
            var expected = new MinLengthSpecification<FakeType>(0, true);

            var sut = Specification.MinLength<FakeType>(0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeMinLengthProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new MinLengthSpecification<string>(0, true));

            var sut = Specification.MinLength<FakeType, string>(
                ft => ft.Second, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}