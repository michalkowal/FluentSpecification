using System;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Sdk.Framework
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CorrectDataAttribute : SpecificationTestCaseDataAttribute
    {
        public CorrectDataAttribute()
        {
        }

        public CorrectDataAttribute(Type @class)
            : base(@class)
        {
        }

        protected override ITestCaseData[] GetTestCaseDataCollection(IData specificationData)
            => specificationData.GetValidData();
    }
}