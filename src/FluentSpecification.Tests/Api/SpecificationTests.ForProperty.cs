using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeForProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(ft => ft.Second,
                MockComplexSpecification<string>.True());

            var sut = new MockCompositeSpecification<FakeType>().ForProperty(
                ft => ft.Second, MockComplexSpecification<string>.True());

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeForProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(ft => ft.Second,
                MockComplexSpecification<string>.True());

            var sut = Specification.ForProperty<FakeType, string>(
                ft => ft.Second, MockComplexSpecification<string>.True());

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}