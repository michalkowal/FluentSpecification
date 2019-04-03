using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Core.Utils;
using Xunit;

namespace FluentSpecification.Core.Tests.Utils
{
    public partial class TypeExtensionsTests
    {
        public class GetCompareToMethod
        {
            [Fact]
            public void InvalidType_ReturnNull()
            {
                var sut = typeof(FakeType);

                var result = sut.GetCompareToMethod(typeof(FakeType));

                Assert.Null(result);
            }

            [Fact]
            public void ValidType_ReturnMethodInfo()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.GetCompareToMethod(typeof(ComparableFakeType));

                Assert.NotNull(result);
            }
        }

        public class GetGenericCompareToMethod
        {
            [Fact]
            public void InvalidType_ReturnNull()
            {
                var sut = typeof(FakeType);

                var result = sut.GetCompareToMethod<FakeType>();

                Assert.Null(result);
            }

            [Fact]
            public void ValidType_ReturnMethodInfo()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.GetCompareToMethod<ComparableFakeType>();

                Assert.NotNull(result);
            }
        }

        public class GetBaseCompareToMethod
        {
            [Fact]
            public void InvalidType_ReturnNull()
            {
                var sut = typeof(FakeType);

                var result = sut.GetCompareToMethod();

                Assert.Null(result);
            }

            [Fact]
            public void ValidType_ReturnMethodInfo()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.GetCompareToMethod();

                Assert.NotNull(result);
            }
        }
    }
}