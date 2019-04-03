namespace FluentSpecification.Core.Tests.Mocks
{
    internal class TrueMockValidationSpecification<T> : MockValidationSpecification<T>
    {
        public TrueMockValidationSpecification() : base(true)
        {
            TraceMessage = $"TrueMockValidationSpecification[{typeof(T)}]";
        }

        protected override string TraceMessage { get; }
    }
}