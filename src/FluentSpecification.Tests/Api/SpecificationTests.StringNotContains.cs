using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeStringNotContains_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new ContainsSpecification(" "));

            var sut = new MockCompositeSpecification<string>().NotContains(" ");

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeStringNotContainsProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new ContainsSpecification(" ")));

            var sut = new MockCompositeSpecification<FakeType>().NotContains(
                ft => ft.Second, " ");

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeStringNotContains_ReturnStringNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new ContainsSpecification(" "));

            var sut = Specification.NotContains(" ");

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeStringNotContainsProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new ContainsSpecification(" ")));

            var sut = Specification.NotContains<FakeType>(
                ft => ft.Second, " ");

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}