namespace FluentSpecification.Core.Tests.Mocks
{
    internal class TrueMockNegatableSpecification<T> : MockNegatableSpecification<T>
    {
        public TrueMockNegatableSpecification() : base(true)
        {
        }
    }
}