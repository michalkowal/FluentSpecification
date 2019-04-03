using System;
using System.Collections.Generic;
using System.Reflection;
using FluentSpecification.Abstractions;
using Xunit;

namespace FluentSpecification.Tests.Mocks
{
    internal class SpecificationComparer : IEqualityComparer<ISpecification>
    {
        private readonly Type _basicSpecificationType = typeof(ISpecification);

        public bool Equals(ISpecification expected, ISpecification other)
        {
            if (ReferenceEquals(expected, other))
                return true;
            Assert.NotNull(expected);
            Assert.NotNull(other);

            var expType = expected.GetType();
            var otType = other.GetType();

            Assert.Equal(expType, otType);

            var fields = GetFields(expType);
            foreach (var field in fields)
            {
                var expValue = field.GetValue(expected);
                var otValue = field.GetValue(other);

                Assert.True(CompareValues(expValue, otValue, field.FieldType));
            }

            return true;
        }

        public int GetHashCode(ISpecification obj)
        {
            return obj.GetHashCode();
        }

        private IEnumerable<FieldInfo> GetFields(Type type)
        {
            return type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
        }

        private bool CompareValues(object expected, object other, Type type)
        {
            if (ReferenceEquals(expected, other))
                return true;
            Assert.NotNull(expected);
            Assert.NotNull(other);

            if (_basicSpecificationType.IsAssignableFrom(type))
            {
                Assert.True(Equals((ISpecification) expected, (ISpecification) other));
                return true;
            }

            if (type == typeof(string) || type.IsValueType)
            {
                Assert.Equal(expected, other);
                return true;
            }

            Assert.Equal(expected.ToString(), other.ToString());
            return true;
        }
    }
}