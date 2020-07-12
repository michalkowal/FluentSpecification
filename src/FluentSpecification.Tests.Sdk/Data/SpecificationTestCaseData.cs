using System.Collections.Generic;

namespace FluentSpecification.Tests.Sdk.Data
{
    public abstract class SpecificationTestCaseData<TCandidate, TFactory> : ISpecificationTestCaseData
        where TFactory : SpecificationFactory<TCandidate>
    {
        public TCandidate Candidate { get; }
        public TFactory Factory { get; }

        protected SpecificationTestCaseData(TCandidate candidate, 
            TFactory factory)
        {
            Candidate = candidate;
            Factory = factory;
        }

        public SpecificationFactory GetSpecificationFactory()
        {
            return Factory;
        }

        public virtual object[] ToArray()
        {
            var result = new List<object>(Factory.Parameters.Values);
            result.Insert(0, Candidate);

            return result.ToArray();
        }
    }
}
