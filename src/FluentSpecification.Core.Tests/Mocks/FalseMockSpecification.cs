namespace FluentSpecification.Core.Tests.Mocks
{
    internal class FalseMockSpecification<T> : MockSpecification<T>
    {
        public FalseMockSpecification() : base(false)
        {
        }
    }
}