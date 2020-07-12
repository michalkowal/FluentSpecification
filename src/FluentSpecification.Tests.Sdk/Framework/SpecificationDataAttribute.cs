using System;
using System.Collections.Generic;
using System.Reflection;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Sdk.Framework
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SpecificationDataAttribute : CustomClassDataAttribute
    {
        public SpecificationDataAttribute(Type @class)
            : base(@class)
        {
        }

        protected SpecificationDataAttribute()
        {
        }

        protected override void ValidateClass(Type value)
        {
            if (!typeof(IData).GetTypeInfo().IsAssignableFrom(value))
                throw new ArgumentException("Incorrect IData class", nameof(value));
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { CreateInstance<IData, SpecificationDataAttribute>(testMethod) };
        }
    }
}