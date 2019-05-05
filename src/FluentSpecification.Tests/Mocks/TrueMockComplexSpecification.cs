using FluentSpecification.Core.Validation;

namespace FluentSpecification.Tests.Mocks
{
    internal class TrueMockComplexSpecification<T> : MockComplexSpecification<T>
    {
        public TrueMockComplexSpecification() : base(candidate => true)
        {
            TraceMessage = $"TrueMockComplexSpecification[{SpecificationResultGenerator.GetTypeShortName(typeof(T))}]";
        }
    }
}