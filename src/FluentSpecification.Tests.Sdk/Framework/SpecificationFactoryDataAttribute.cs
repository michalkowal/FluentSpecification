using FluentSpecification.Tests.Sdk.Data;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FluentSpecification.Tests.Sdk.Framework
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class SpecificationFactoryDataAttribute : CustomClassDataAttribute
    {
        public SpecificationFactoryDataAttribute()
        {
        }

        public SpecificationFactoryDataAttribute(Type @class)
            : base(@class)
        {
        }

        protected override void ValidateClass(Type value)
        {
            if (!typeof(SpecificationFactory).GetTypeInfo().IsAssignableFrom(value))
                throw new ArgumentException("Incorrect SpecificationFactory class", nameof(value));
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var f = CreateInstance<SpecificationFactory, SpecificationFactoryDataAttribute>(testMethod);
            yield return new [] { f };
        }
    }
}
