using System.Collections.Generic;
using FluentSpecification.Tests.Sdk.Data.Validation;

namespace FluentSpecification.Tests.Sdk.Data
{
    public abstract partial class SpecificationData
    {
        protected SpecificationTestCaseDataBuilder<T, SpecificationFactory<T>> AddValidWithResult<T, TResult>(T candidate, SpecificationFactory<T> factory)
            where TResult : IReadOnlyList<ExpectedSpecificationResult>, new()
        {
            return AddValidResult<T, TResult, SpecificationFactory<T>>(AddValid(candidate, factory));
        }

        protected SpecificationTestCaseDataBuilder<T, SpecificationFactory<T>> AddInvalidWithResult<T, TResult>(T candidate, SpecificationFactory<T> factory)
            where TResult : IReadOnlyList<ExpectedSpecificationResult>, new()
        {
            return AddInvalidResult<T, TResult, SpecificationFactory<T>>(AddInvalid(candidate, factory));
        }

        private SpecificationTestCaseDataBuilder<T, TFactory> AddValidResult<T, TResult, TFactory>(SpecificationTestCaseDataBuilder<T, TFactory> builder)
            where TResult : IReadOnlyList<ExpectedSpecificationResult>, new()
            where TFactory : SpecificationFactory<T>
        {
            return AddResult<T, TResult, TFactory>(builder, Valid.Count - 1);
        }

        private SpecificationTestCaseDataBuilder<T, TFactory> AddInvalidResult<T, TResult, TFactory>(SpecificationTestCaseDataBuilder<T, TFactory> builder)
            where TResult : IReadOnlyList<ExpectedSpecificationResult>, new()
            where TFactory : SpecificationFactory<T>
        {
            return AddResult<T, TResult, TFactory>(builder, Invalid.Count - 1);
        }

        private SpecificationTestCaseDataBuilder<T, TFactory> AddResult<T, TResult, TFactory>(SpecificationTestCaseDataBuilder<T, TFactory> builder, int index)
            where TResult : IReadOnlyList<ExpectedSpecificationResult>, new()
            where TFactory : SpecificationFactory<T>
        {
            builder.Result<TResult>(index);
            return builder;
        }
    }
}
