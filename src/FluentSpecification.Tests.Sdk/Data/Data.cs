using System.Collections.Generic;

namespace FluentSpecification.Tests.Sdk.Data
{
    public abstract class BaseData : IData
    {
        private protected readonly List<TestCaseData> Invalid = new List<TestCaseData>();
        private protected readonly List<TestCaseData> Valid = new List<TestCaseData>();

        public void AddValid(params object[] testCase)
        {
            Valid.Add(new TestCaseData(testCase));
        }

        public void AddInvalid(params object[] testCase)
        {
            Invalid.Add(new TestCaseData(testCase));
        }

        public ITestCaseData[] GetInvalidData()
        {
            return Invalid.ToArray();
        }

        public ITestCaseData[] GetInvalidNegationData()
        {
            return GetValidData();
        }

        public ITestCaseData[] GetValidData()
        {
            return Valid.ToArray();
        }

        public ITestCaseData[] GetValidNegationData()
        {
            return GetInvalidData();
        }
    }
}
