using System;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Sdk.Framework.Negations
{
    [AttributeUsage(AttributeTargets.Method)]
    public class IncorrectNegationData : SpecificationTestCaseDataAttribute
    {
        protected override ITestCaseData[] GetTestCaseDataCollection(IData specificationData)
            => specificationData.GetInvalidNegationData();
    }
}
