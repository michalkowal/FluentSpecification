namespace FluentSpecification.Core.Tests.Mocks
{
    internal class FalseMockValidationSpecification<T> : MockValidationSpecification<T>
    {
        public FalseMockValidationSpecification() : base(false)
        {
            TraceMessage = $"FalseMockValidationSpecification[{typeof(T)}]";
        }

        protected override string TraceMessage { get; }
    }
}