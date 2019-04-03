using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeStringContains_ReturnStringContainsSpecification()
        {
            var expected = new ContainsSpecification(" ");

            var sut = new MockCompositeSpecification<string>().Contains(" ");

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeStringContainsProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new ContainsSpecification(" "));

            var sut = new MockCompositeSpecification<FakeType>().Contains(
                ft => ft.Second, " ");

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeStringContains_ReturnStringContainsSpecification()
        {
            var expected = new ContainsSpecification(" ");

            var sut = Specification.Contains(" ");

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeStringContainsProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new ContainsSpecification(" "));

            var sut = Specification.Contains<FakeType>(
                ft => ft.Second, " ");

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}