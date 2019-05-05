using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeMaxLength_ReturnMaxLengthSpecification()
        {
            var expected = new MaxLengthSpecification<string>(0, true);

            var sut = new MockCompositeSpecification<string>().MaxLength(0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeMaxLengthProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new MaxLengthSpecification<string>(0, true));

            var sut = new MockCompositeSpecification<FakeType>().MaxLength(
                ft => ft.Second, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeMaxLength_ReturnMaxLengthSpecification()
        {
            var expected = new MaxLengthSpecification<FakeType>(0, true);

            var sut = Specification.MaxLength<FakeType>(0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeMaxLengthProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new MaxLengthSpecification<string>(0, true));

            var sut = Specification.MaxLength<FakeType, string>(
                ft => ft.Second, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}