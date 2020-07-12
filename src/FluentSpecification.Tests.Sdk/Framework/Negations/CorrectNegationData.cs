using System;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Sdk.Framework.Negations
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CorrectNegationData : SpecificationTestCaseDataAttribute
    {
        protected override ITestCaseData[] GetTestCaseDataCollection(IData specificationData)
            => specificationData.GetValidNegationData();
    }
}
