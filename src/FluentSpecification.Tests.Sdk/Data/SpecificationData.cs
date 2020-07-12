using System;
using System.Collections.Generic;
using System.Linq;
using FluentSpecification.Tests.Sdk.Data.Negations;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Sdk.Data
{
    public abstract partial class SpecificationData : IData
    {
        private readonly Dictionary<Type, IReadOnlyList<ExpectedSpecificationResult>> ResultsCache = 
            new Dictionary<Type, IReadOnlyList<ExpectedSpecificationResult>>();

        private protected readonly List<ISpecificationTestCaseDataBuilder> Invalid = new List<ISpecificationTestCaseDataBuilder>();
        private protected readonly List<ISpecificationTestCaseDataBuilder> Valid = new List<ISpecificationTestCaseDataBuilder>();

        public ITestCaseData[] GetValidData()
        {
            return Valid.Select(a => a.Build()).ToArray();
        }

        public ITestCaseData[] GetInvalidData()
        {
            return Invalid.Select(a => a.Build()).ToArray();
        }

        public ITestCaseData[] GetValidNegationData()
        {
            return Invalid.Select(a => a.BuildNegation()).ToArray();
        }

        public ITestCaseData[] GetInvalidNegationData()
        {
            return Valid.Select(a => a.BuildNegation()).ToArray();
        }

        protected SpecificationTestCaseDataBuilder<T, SpecificationFactory<T>> AddValid<T>(T candidate, SpecificationFactory<T> factory)
        {
            var row = CreateDataBuilder(candidate, factory);
            Valid.Add(row);

            return row;
        }

        protected SpecificationTestCaseDataBuilder<T, SpecificationFactory<T>> AddInvalid<T>(T candidate, SpecificationFactory<T> factory)
        {
            var row = CreateDataBuilder(candidate, factory);
            Invalid.Add(row);

            return row;
        }

        protected SpecificationTestCaseDataBuilder<T, NegatableSpecificationFactory<T>> AddValid<T>(T candidate, NegatableSpecificationFactory<T> factory)
        {
            var row = CreateDataBuilder(candidate, factory);
            Valid.Add(row);

            return row;
        }

        protected SpecificationTestCaseDataBuilder<T, NegatableSpecificationFactory<T>> AddInvalid<T>(T candidate, NegatableSpecificationFactory<T> factory)
        {
            var row = CreateDataBuilder(candidate, factory);
            Invalid.Add(row);

            return row;
        }

        private SpecificationTestCaseDataBuilder<T, TFactory> CreateDataBuilder<T, TFactory>(T candidate, TFactory factory)
            where TFactory : SpecificationFactory<T>
        {
            return new SpecificationTestCaseDataBuilder<T, TFactory>(candidate, factory)
            {
                Cache = ResultsCache
            };
        }
    }
}