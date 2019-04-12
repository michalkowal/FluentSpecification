using System;
using System.Diagnostics.CodeAnalysis;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Utils;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Utils
{
    public partial class TypeExtensionsTests
    {
        public class GetEqualityOperator
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnNull(Type sut)
            {
                var result = sut.GetEqualityOperator();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetEqualityOperator());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnMethodInfo(Type sut)
            {
                var result = sut.GetEqualityOperator();

                Assert.NotNull(result);
            }
        }

        public class GetInequalityOperator
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnNull(Type sut)
            {
                var result = sut.GetInequalityOperator();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetInequalityOperator());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnMethodInfo(Type sut)
            {
                var result = sut.GetInequalityOperator();

                Assert.NotNull(result);
            }
        }

        public class GetLessThanOperator
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnNull(Type sut)
            {
                var result = sut.GetLessThanOperator();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetLessThanOperator());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnMethodInfo(Type sut)
            {
                var result = sut.GetLessThanOperator();

                Assert.NotNull(result);
            }
        }

        public class GetLessThanOrEqualOperator
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnNull(Type sut)
            {
                var result = sut.GetLessThanOrEqualOperator();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetLessThanOrEqualOperator());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnMethodInfo(Type sut)
            {
                var result = sut.GetLessThanOrEqualOperator();

                Assert.NotNull(result);
            }
        }

        public class GetGreaterThanOperator
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnNull(Type sut)
            {
                var result = sut.GetGreaterThanOperator();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetGreaterThanOperator());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnMethodInfo(Type sut)
            {
                var result = sut.GetGreaterThanOperator();

                Assert.NotNull(result);
            }
        }

        public class GetGreaterThanOrEqualOperator
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnNull(Type sut)
            {
                var result = sut.GetGreaterThanOrEqualOperator();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetGreaterThanOrEqualOperator());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnMethodInfo(Type sut)
            {
                var result = sut.GetGreaterThanOrEqualOperator();

                Assert.NotNull(result);
            }
        }
    }
}