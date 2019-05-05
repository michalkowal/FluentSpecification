namespace FluentSpecification.Core.Tests.Mocks
{
    internal class TrueMockComplexSpecification<T> : MockComplexSpecification<T>
    {
        public TrueMockComplexSpecification() : base(true)
        {
            TraceMessage = $"TrueMockComplexSpecification[{typeof(T)}]";
        }

        protected override string TraceMessage { get; }
    }
}