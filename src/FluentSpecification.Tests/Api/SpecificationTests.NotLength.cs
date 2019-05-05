using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotLength_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new LengthSpecification<string>(0, true));

            var sut = new MockCompositeSpecification<string>().NotLength(0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotLengthProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new LengthSpecification<string>(0, true)));

            var sut = new MockCompositeSpecification<FakeType>().NotLength(
                ft => ft.Second, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotLength_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new LengthSpecification<string>(0, true));

            var sut = Specification.NotLength<string>(0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotLengthProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new LengthSpecification<string>(0, true)));

            var sut = Specification.NotLength<FakeType, string>(
                ft => ft.Second, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}