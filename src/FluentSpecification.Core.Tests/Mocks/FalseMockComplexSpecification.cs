namespace FluentSpecification.Core.Tests.Mocks
{
    internal class FalseMockComplexSpecification<T> : MockComplexSpecification<T>
    {
        public FalseMockComplexSpecification() : base(false)
        {
            TraceMessage = $"FalseMockComplexSpecification[{typeof(T)}]";
        }

        protected override string TraceMessage { get; }
    }
}