using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FluentSpecification.Tests.Sdk
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    [PublicAPI]
    public class CorrectDataAttribute : SpecificationDataAttribute
    {
        public CorrectDataAttribute(Type @class) :
            base(@class)
        {
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            return GetSpecificationData().GetValidData();
        }
    }
}