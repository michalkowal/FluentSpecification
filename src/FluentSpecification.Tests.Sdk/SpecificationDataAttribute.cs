using System;
using System.Reflection;
using FluentSpecification.Tests.Sdk.Data;
using JetBrains.Annotations;
using Xunit.Sdk;

namespace FluentSpecification.Tests.Sdk
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public abstract class SpecificationDataAttribute : DataAttribute
    {
        protected SpecificationDataAttribute(Type @class)
        {
            if (!typeof(SpecificationData).GetTypeInfo().IsAssignableFrom(@class))
                throw new ArgumentException("Incorrect SpecificationData class", nameof(@class));
            Class = @class;
        }

        [PublicAPI] public Type Class { get; }

        [PublicAPI] public bool AsNegation { get; set; }

        protected SpecificationData GetSpecificationData()
        {
            var result = (SpecificationData) Activator.CreateInstance(Class);
            result.AsNegation = AsNegation;

            return result;
        }
    }
}