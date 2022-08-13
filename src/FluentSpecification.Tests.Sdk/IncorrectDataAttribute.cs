﻿using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FluentSpecification.Tests.Sdk
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    [PublicAPI]
    public class IncorrectDataAttribute : SpecificationDataAttribute
    {
        public IncorrectDataAttribute(Type @class) :
            base(@class)
        {
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            return GetSpecificationData().GetInvalidData();
        }
    }
}