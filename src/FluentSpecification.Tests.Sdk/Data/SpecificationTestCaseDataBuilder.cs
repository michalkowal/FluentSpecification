using System;
using System.Collections.Generic;
using System.Linq;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Sdk.Data
{
    public abstract class SpecificationTestCaseDataBuilder
    {
        public Dictionary<Type, IReadOnlyList<ExpectedSpecificationResult>> Cache
        {
            get;
            set;
        }

        protected ExpectedSpecificationResult GetResultFromCache<T>(int index)
            where T : IReadOnlyList<ExpectedSpecificationResult>, new()
        {
            if (Cache == null)
                return new T()[index];

            if (!Cache.ContainsKey(typeof(T)))
                Cache.Add(typeof(T), new T());

            return Cache[typeof(T)][index];
        }

        protected void ApplyResultParameters<T>(T candidate, SpecificationFactory<T> factory, ExpectedSpecificationInfo info)
        {
            if (info == null)
                return;

            if (info.Candidate == null && candidate != null)
                info.Candidate = candidate;

            var namedParameters = factory
                .Parameters
                .Where(p => info.Parameters.ContainsKey(p.Key) && info.Parameters[p.Key] == null)
                .ToArray();
            foreach (var param in namedParameters)
                info.Parameters[param.Key] = param.Value;
        }

        protected void ApplyResultParameters<T>(T candidate, SpecificationFactory<T> factory, List<ExpectedSpecificationInfo> infos)
        {
            foreach (var info in infos)
            {
                ApplyResultParameters(candidate, factory, info);
            }
        }
    }

    public class SpecificationTestCaseDataBuilder<TCandidate, TFactory> : SpecificationTestCaseDataBuilder,
        ISpecificationTestCaseDataBuilder
        where TFactory : SpecificationFactory<TCandidate>
    {
        protected readonly TCandidate Candidate;
        protected readonly TFactory Factory;

        private ExpectedSpecificationResult _dataResult;
        private ExpectedSpecificationResult _negationDataResult;

        public SpecificationTestCaseDataBuilder(TCandidate candidate, 
            TFactory factory)
        {
            Candidate = candidate;
            Factory = factory;
        }

        public void Result(ExpectedSpecificationResult result)
        {
            _dataResult = result;
        }

        public void Result<T>(int index)
            where T : IReadOnlyList<ExpectedSpecificationResult>, new()
        {
            _dataResult = GetResult<T>(index);
        }

        public void NegationResult(ExpectedSpecificationResult result)
        {
            _negationDataResult = result;
        }

        public void NegationResult<T>(int index)
            where T : IReadOnlyList<ExpectedSpecificationResult>, new()
        {
            _negationDataResult = GetResult<T>(index);
        }

        public ISpecificationTestCaseData Build()
        {
            return new ValidationSpecificationTestCaseData<TCandidate, SpecificationFactory<TCandidate>>(Candidate,
                Factory, _dataResult);
        }

        public ISpecificationTestCaseData BuildNegation()
        {
            return new ValidationSpecificationTestCaseData<TCandidate, TFactory>(Candidate,
                Factory, _negationDataResult);
        }

        protected ExpectedSpecificationResult GetResult<T>(int index)
            where T : IReadOnlyList<ExpectedSpecificationResult>, new()
        {
            var result = GetResultFromCache<T>(index);

            ApplyResultParameters(Candidate, Factory, result.Specifications);
            ApplyResultParameters(Candidate, Factory, result.FailedSpecifications);

            return result;
        }
    }
}