using System;
using System.Diagnostics.CodeAnalysis;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Core.Utils;
using Xunit;

namespace FluentSpecification.Core.Tests.Utils
{
    public partial class TypeExtensionsTests
    {
        public class GetEqualityOperator
        {
            [Fact]
            public void InvalidType_ReturnNull()
            {
                var sut = typeof(FakeType);

                var result = sut.GetEqualityOperator();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetEqualityOperator());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnMethodInfo()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.GetEqualityOperator();

                Assert.NotNull(result);
            }
        }

        public class GetInequalityOperator
        {
            [Fact]
            public void InvalidType_ReturnNull()
            {
                var sut = typeof(FakeType);

                var result = sut.GetInequalityOperator();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetInequalityOperator());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnMethodInfo()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.GetInequalityOperator();

                Assert.NotNull(result);
            }
        }

        public class GetLessThanOperator
        {
            [Fact]
            public void InvalidType_ReturnNull()
            {
                var sut = typeof(FakeType);

                var result = sut.GetLessThanOperator();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetLessThanOperator());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnMethodInfo()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.GetLessThanOperator();

                Assert.NotNull(result);
            }
        }

        public class GetLessThanOrEqualOperator
        {
            [Fact]
            public void InvalidType_ReturnNull()
            {
                var sut = typeof(FakeType);

                var result = sut.GetLessThanOrEqualOperator();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetLessThanOrEqualOperator());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnMethodInfo()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.GetLessThanOrEqualOperator();

                Assert.NotNull(result);
            }
        }

        public class GetGreaterThanOperator
        {
            [Fact]
            public void InvalidType_ReturnNull()
            {
                var sut = typeof(FakeType);

                var result = sut.GetGreaterThanOperator();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetGreaterThanOperator());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnMethodInfo()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.GetGreaterThanOperator();

                Assert.NotNull(result);
            }
        }

        public class GetGreaterThanOrEqualOperator
        {
            [Fact]
            public void InvalidType_ReturnNull()
            {
                var sut = typeof(FakeType);

                var result = sut.GetGreaterThanOrEqualOperator();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetGreaterThanOrEqualOperator());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnMethodInfo()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.GetGreaterThanOrEqualOperator();

                Assert.NotNull(result);
            }
        }
    }
}