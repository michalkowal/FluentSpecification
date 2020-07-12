using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Sdk;
using FluentSpecification.Tests.Sdk.Framework;
using JetBrains.Annotations;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    [SpecificationData(typeof(FalseData))]
    [SpecificationFactoryData(typeof(FalseFactory))]
    public class FalseSpecificationTests : ComplexSpecificationTests<FalseSpecificationTests>
    {
    }
}