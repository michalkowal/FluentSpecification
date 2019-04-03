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
        public class IsGenericEnumerable
        {
            [Theory]
            [CorrectData(typeof(TypeIsEnumerableData))]
            public void ValidType_ReturnTrue(Type type)
            {
                var result = type.IsGenericEnumerable();

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(TypeIsEnumerableData))]
            public void InvalidType_ReturnFalse(Type type)
            {
                var result = type.IsGenericEnumerable();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).IsGenericEnumerable());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }

        public class GetEnumerableGenericTypeArgument
        {
            [Theory]
            [CorrectData(typeof(TypeEnumerableAttributeData))]
            public void ValidType_ReturnTrue(Type type, Type expected)
            {
                var result = type.GetEnumerableGenericTypeArgument();

                Assert.Equal(expected, result);
            }

            [Theory]
            [IncorrectData(typeof(TypeIsEnumerableData))]
            public void InvalidType_ReturnNull(Type type)
            {
                var result = type.GetEnumerableGenericTypeArgument();

                Assert.Null(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetEnumerableGenericTypeArgument());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }
        }
    }
}