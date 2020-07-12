using FluentSpecification.Core.Utils;

namespace FluentSpecification.Tests.Mocks
{
    internal class TrueMockComplexSpecification<T> : MockComplexSpecification<T>
    {
        public TrueMockComplexSpecification() : base(candidate => true)
        {
            TraceMessage = $"TrueMockComplexSpecification[{typeof(T).GetShortName()}]";
        }
    }
}