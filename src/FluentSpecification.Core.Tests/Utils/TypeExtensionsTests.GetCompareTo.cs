using System;
using System.Diagnostics.CodeAnalysis;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Core.Utils;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Utils
{
    public partial class TypeExtensionsTests
    {
        public class GetCompareToMethod
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnNull(Type sut)
            {
                var result = sut.GetCompareToMethod(typeof(FakeType));

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelf_Exception()
            {
                var exception = Record.Exception(() => ((Type)null).GetCompareToMethod(typeof(FakeType)));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var sut = typeof(FakeType);

                var exception = Record.Exception(() => sut.GetCompareToMethod(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnMethodInfo(Type sut)
            {
                var result = sut.GetCompareToMethod(typeof(ComparableFakeType));

                Assert.NotNull(result);
            }
        }

        public class GetGenericCompareToMethod
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnNull(Type sut)
            {
                var result = sut.GetCompareToMethod<FakeType>();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelf_Exception()
            {
                var exception = Record.Exception(() => ((Type)null).GetCompareToMethod<FakeType>());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnMethodInfo(Type sut)
            {
                var result = sut.GetCompareToMethod<ComparableFakeType>();

                Assert.NotNull(result);
            }
        }

        public class GetBaseCompareToMethod
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnNull(Type sut)
            {
                var result = sut.GetCompareToMethod();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelf_Exception()
            {
                var exception = Record.Exception(() => ((Type)null).GetCompareToMethod());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnMethodInfo(Type sut)
            {
                var result = sut.GetCompareToMethod();

                Assert.NotNull(result);
            }
        }
    }
}