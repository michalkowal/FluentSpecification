namespace FluentSpecification.Core.Tests.Mocks
{
    internal class TrueMockSpecification<T> : MockSpecification<T>
    {
        public TrueMockSpecification() : base(true)
        {
        }
    }
}