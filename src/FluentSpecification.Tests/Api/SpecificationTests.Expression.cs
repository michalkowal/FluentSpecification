using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeExpression_ReturnExpressionSpecification()
        {
            var expected = new ExpressionSpecification<int>(ft => true);

            var sut = new MockCompositeSpecification<int>().Expression(ft => true);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeExpressionProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new ExpressionSpecification<int>(ft => true));

            var sut = new MockCompositeSpecification<FakeType>().Expression(
                ft => ft.First, ft => true);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeExpression_ReturnExpressionSpecification()
        {
            var expected = new ExpressionSpecification<FakeType>(ft => true);

            var sut = Specification.Expression<FakeType>(ft => true);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeExpressionProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new ExpressionSpecification<int>(ft => true));

            var sut = Specification.Expression<FakeType, int>(
                ft => ft.First, ft => true);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}