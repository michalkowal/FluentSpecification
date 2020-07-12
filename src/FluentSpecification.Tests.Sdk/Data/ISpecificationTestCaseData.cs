namespace FluentSpecification.Tests.Sdk.Data
{
    public interface ISpecificationTestCaseData : ITestCaseData
    {
        SpecificationFactory GetSpecificationFactory();
    }
}
