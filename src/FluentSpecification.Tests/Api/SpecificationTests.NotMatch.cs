using System.Text.RegularExpressions;
using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotMatch_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new MatchSpecification("pattern", RegexOptions.IgnoreCase));

            var sut = new MockCompositeSpecification<string>().NotMatch("pattern", RegexOptions.IgnoreCase);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotMatchProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new MatchSpecification("pattern", RegexOptions.IgnoreCase)));

            var sut = new MockCompositeSpecification<FakeType>().NotMatch(
                ft => ft.Second, "pattern", RegexOptions.IgnoreCase);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotMatch_ReturnStringNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new MatchSpecification("pattern", RegexOptions.IgnoreCase));

            var sut = Specification.NotMatch("pattern", RegexOptions.IgnoreCase);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotMatchProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new MatchSpecification("pattern", RegexOptions.IgnoreCase)));

            var sut = Specification.NotMatch<FakeType>(
                ft => ft.Second, "pattern", RegexOptions.IgnoreCase);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}