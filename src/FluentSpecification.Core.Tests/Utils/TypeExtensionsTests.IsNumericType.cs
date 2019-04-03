using System;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Utils;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Utils
{
    public partial class TypeExtensionsTests
    {
        public class IsNumericType
        {
            [Theory]
            [CorrectData(typeof(TypeNumericData))]
            public void NumericType_ReturnTrue(Type sut)
            {
                var result = sut.IsNumericType();

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(TypeNumericData))]
            public void NonNumericType_ReturnFalse(Type sut)
            {
                var result = sut.IsNumericType();

                Assert.False(result);
            }
        }
    }
}