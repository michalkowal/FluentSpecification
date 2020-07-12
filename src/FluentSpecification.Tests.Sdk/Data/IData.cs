namespace FluentSpecification.Tests.Sdk.Data
{
    public interface IData
    {
        ITestCaseData[] GetValidData();
        ITestCaseData[] GetInvalidData();
        ITestCaseData[] GetValidNegationData();
        ITestCaseData[] GetInvalidNegationData();
    }
}
