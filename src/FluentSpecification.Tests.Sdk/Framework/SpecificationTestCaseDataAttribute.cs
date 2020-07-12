using FluentSpecification.Tests.Sdk.Data;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace FluentSpecification.Tests.Sdk.Framework
{
    [DataDiscoverer("FluentSpecification.Tests.Sdk.Framework.SpecificationTestCaseDataDiscoverer", "FluentSpecification.Tests.Sdk")]
    public abstract class SpecificationTestCaseDataAttribute : SpecificationDataAttribute
    {
        protected SpecificationTestCaseDataAttribute(Type @class)
            : base(@class)
        {
        }

        protected SpecificationTestCaseDataAttribute()
        {
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var testCaseDataCollection = GetTestCaseDataCollection(testMethod);

            foreach (var testData in testCaseDataCollection)
            {
                yield return testData.ToArray();
            }
        }

        public ITestCaseData[] GetTestCaseDataCollection(MethodInfo testMethod)
        {
            var specData = CreateInstance<IData, SpecificationDataAttribute>(testMethod);
            return GetTestCaseDataCollection(specData);
        }

        protected abstract ITestCaseData[] GetTestCaseDataCollection(IData specificationData);
    }
}
