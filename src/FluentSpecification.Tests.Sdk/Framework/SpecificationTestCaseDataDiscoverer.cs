using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentSpecification.Tests.Sdk.Data;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace FluentSpecification.Tests.Sdk.Framework
{
    public class SpecificationTestCaseDataDiscoverer : IDataDiscoverer
    {
        public IEnumerable<object[]> GetData(IAttributeInfo dataAttribute, IMethodInfo testMethod)
        {
            if (dataAttribute is IReflectionAttributeInfo reflectionAttributeInfo &&
                testMethod is IReflectionMethodInfo reflectionMethodInfo &&
                reflectionAttributeInfo.Attribute is SpecificationTestCaseDataAttribute specificationDataAttribute)
            {
                var testCaseData = specificationDataAttribute.GetTestCaseDataCollection(reflectionMethodInfo.MethodInfo);

                var parametersCount = testMethod.GetParameters().Count();
                var parameter = testMethod.GetParameters().FirstOrDefault();

                var result = testCaseData.Select(data =>
                    data.ToArray().Take(parametersCount).ToArray())
                    .ToArray();

                if (parametersCount == 1 && parameter is IReflectionParameterInfo reflectionParameter)
                {
                    var specificationData = testCaseData
                        .Where(d => d is ISpecificationTestCaseData)
                        .Cast<ISpecificationTestCaseData>();
                    if (specificationData.Any())
                    {
                        if (typeof(ISpecificationTestCaseData).GetTypeInfo()
                            .IsAssignableFrom(reflectionParameter.ParameterInfo.ParameterType))
                        {
                            result = specificationData.Select(data => new object[] {data}).ToArray();
                        }
                        else if (typeof(SpecificationFactory).GetTypeInfo()
                            .IsAssignableFrom(reflectionParameter.ParameterInfo.ParameterType))
                        {
                            result = specificationData.Select(data => new [] {data.GetSpecificationFactory()}).ToArray();
                        }
                    }
                }

                return result;
            }

            return Enumerable.Empty<object[]>();
        }

        public bool SupportsDiscoveryEnumeration(IAttributeInfo dataAttribute, IMethodInfo testMethod)
            => true;
    }
}
