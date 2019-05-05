using FluentSpecification.Core.Validation;

namespace FluentSpecification.Tests.Mocks
{
    internal class FalseMockComplexSpecification<T> : MockComplexSpecification<T>
    {
        public FalseMockComplexSpecification() : base(candidate => false)
        {
            TraceMessage = $"FalseMockComplexSpecification[{SpecificationResultGenerator.GetTypeShortName(typeof(T))}]";
        }
    }
}