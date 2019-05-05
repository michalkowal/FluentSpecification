namespace FluentSpecification.Core.Tests.Mocks
{
    internal class FalseMockNegatableComplexSpecification<T> : MockNegatableComplexSpecification<T>
    {
        public FalseMockNegatableComplexSpecification() : base(false)
        {
            TraceMessage = $"FalseMockNegatableComplexSpecification[{typeof(T)}]";
        }

        protected override string TraceMessage { get; }
    }
}