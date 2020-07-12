using FluentSpecification.Core.Utils;

namespace FluentSpecification.Tests.Mocks
{
    internal class FalseMockComplexSpecification<T> : MockComplexSpecification<T>
    {
        public FalseMockComplexSpecification() : base(candidate => false)
        {
            TraceMessage = $"FalseMockComplexSpecification[{typeof(T).GetShortName()}]";
        }
    }
}