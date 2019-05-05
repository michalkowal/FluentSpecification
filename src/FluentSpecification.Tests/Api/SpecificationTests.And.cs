using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeAnd_ReturnAndSpecification()
        {
            var left = MockComplexSpecification.True();
            var right = MockComplexSpecification.False();
            var expected = new AndSpecification<object>(left, right);

            var sut = Specification.And(left, right);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeAndProperty_ReturnPropertySpecification()
        {
            var left = MockComplexSpecification<int>.True();
            var right = MockComplexSpecification<int>.False();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new AndSpecification<int>(left, right));

            var sut = Specification.And<FakeType, int>(
                ft => ft.First, left, right);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}