namespace FluentSpecification.Core.Tests.Mocks
{
    internal class FalseMockNegatableValidationSpecification<T> : MockNegatableValidationSpecification<T>
    {
        public FalseMockNegatableValidationSpecification() : base(false)
        {
            TraceMessage = $"FalseMockNegatableValidationSpecification[{typeof(T)}]";
        }

        protected override string TraceMessage { get; }
    }
}