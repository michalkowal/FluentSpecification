namespace FluentSpecification.Core.Tests.Mocks
{
    internal class FalseMockNegatableSpecification<T> : MockNegatableSpecification<T>
    {
        public FalseMockNegatableSpecification() : base(false)
        {
        }
    }
}