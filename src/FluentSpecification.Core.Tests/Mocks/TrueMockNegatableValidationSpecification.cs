namespace FluentSpecification.Core.Tests.Mocks
{
    internal class TrueMockNegatableValidationSpecification<T> : MockNegatableValidationSpecification<T>
    {
        public TrueMockNegatableValidationSpecification() : base(true)
        {
            TraceMessage = $"TrueMockNegatableValidationSpecification[{typeof(T)}]";
        }

        protected override string TraceMessage { get; }
    }
}