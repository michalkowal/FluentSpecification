namespace FluentSpecification.Core.Tests.Mocks
{
    internal class TrueMockNegatableComplexSpecification<T> : MockNegatableComplexSpecification<T>
    {
        public TrueMockNegatableComplexSpecification() : base(true)
        {
            TraceMessage = $"TrueMockNegatableComplexSpecification[{typeof(T)}]";
        }

        protected override string TraceMessage { get; }
    }
}