namespace FluentSpecification.Tests.Sdk.Data
{
    public interface ISpecificationTestCaseDataBuilder
    {
        ISpecificationTestCaseData Build();
        ISpecificationTestCaseData BuildNegation();
    }
}
