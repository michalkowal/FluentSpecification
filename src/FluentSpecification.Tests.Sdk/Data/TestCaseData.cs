namespace FluentSpecification.Tests.Sdk.Data
{
    public class TestCaseData : ITestCaseData
    {
        private readonly object[] _data;

        public TestCaseData(object[] data)
        {
            _data = data ?? new object[0];
        }

        public object[] ToArray()
        {
            return _data;
        }
    }
}
