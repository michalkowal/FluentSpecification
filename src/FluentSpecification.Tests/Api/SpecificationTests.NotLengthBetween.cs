using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotLengthBetween_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new LengthBetweenSpecification<string>(0, 0, true));

            var sut = new MockCompositeSpecification<string>().NotLengthBetween(0, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotLengthBetweenProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new LengthBetweenSpecification<string>(0, 0, true)));

            var sut = new MockCompositeSpecification<FakeType>().NotLengthBetween(
                ft => ft.Second, 0, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotLengthBetween_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new LengthBetweenSpecification<string>(0, 0, true));

            var sut = Specification.NotLengthBetween<string>(0, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotLengthBetweenProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new LengthBetweenSpecification<string>(0, 0, true)));

            var sut = Specification.NotLengthBetween<FakeType, string>(
                ft => ft.Second, 0, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}