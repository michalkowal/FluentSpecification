using System;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Sdk.Framework
{
    [AttributeUsage(AttributeTargets.Method)]
    public class IncorrectDataAttribute : SpecificationTestCaseDataAttribute
    {
        public IncorrectDataAttribute()
        {
        }

        public IncorrectDataAttribute(Type @class)
            : base(@class)
        {
        }

        protected override ITestCaseData[] GetTestCaseDataCollection(IData specificationData)
            => specificationData.GetInvalidData();
    }
}