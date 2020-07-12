using System.Collections.Generic;
using FluentSpecification.Tests.Sdk.Data.Negations;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Sdk.Data
{
    public abstract partial class SpecificationData
    {
        protected SpecificationTestCaseDataBuilder<T, NegatableSpecificationFactory<T>> AddValidWithResults<T, TResult, TNegationResult>(T candidate, NegatableSpecificationFactory<T> factory)
            where TResult : IReadOnlyList<ExpectedSpecificationResult>, new()
            where TNegationResult : IReadOnlyList<ExpectedSpecificationResult>, new()
        {
            return AddInvalidNegationResult<T, TNegationResult>(AddValidResult<T, TResult, NegatableSpecificationFactory<T>>(AddValid(candidate, factory)));
        }

        protected SpecificationTestCaseDataBuilder<T, NegatableSpecificationFactory<T>> AddInvalidWithResults<T, TResult, TNegationResult>(T candidate, NegatableSpecificationFactory<T> factory)
            where TResult : IReadOnlyList<ExpectedSpecificationResult>, new()
            where TNegationResult : IReadOnlyList<ExpectedSpecificationResult>, new()
        {
            return AddValidNegationResult<T, TNegationResult>(AddInvalidResult<T, TResult, NegatableSpecificationFactory<T>>(AddInvalid(candidate, factory)));
        }

        private SpecificationTestCaseDataBuilder<T, NegatableSpecificationFactory<T>> AddValidNegationResult<T, TNegationResult>(SpecificationTestCaseDataBuilder<T, NegatableSpecificationFactory<T>> builder)
            where TNegationResult : IReadOnlyList<ExpectedSpecificationResult>, new()
        {
            return AddNegationResult<T, TNegationResult>(builder, Invalid.Count - 1);
        }

        private SpecificationTestCaseDataBuilder<T, NegatableSpecificationFactory<T>> AddInvalidNegationResult<T, TNegationResult>(SpecificationTestCaseDataBuilder<T, NegatableSpecificationFactory<T>> builder)
            where TNegationResult : IReadOnlyList<ExpectedSpecificationResult>, new()
        {
            return AddNegationResult<T, TNegationResult>(builder, Valid.Count - 1);
        }

        private SpecificationTestCaseDataBuilder<T, NegatableSpecificationFactory<T>> AddNegationResult<T, TNegationResult>(SpecificationTestCaseDataBuilder<T, NegatableSpecificationFactory<T>> builder, int index)
            where TNegationResult : IReadOnlyList<ExpectedSpecificationResult>, new()
        {
            builder.NegationResult<TNegationResult>(index);
            return builder;
        }
    }
}
