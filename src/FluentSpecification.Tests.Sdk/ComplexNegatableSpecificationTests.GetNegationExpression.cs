using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;
using FluentSpecification.Tests.Sdk.Framework.Negations;
using Xunit;

namespace FluentSpecification.Tests.Sdk
{
    public abstract partial class ComplexNegatableSpecificationTests<T>
    {
        [Theory]
        [Trait("Category", "GetNegationExpression")]
        [CorrectNegationData]
        public void GetNegationExpression_InvokeValidCandidate_ReturnTrue<TCandidate>(SpecificationTestCaseData<TCandidate, NegatableSpecificationFactory<TCandidate>> data)
        {
            var sut = CreateNegatableSpecification(data.Factory);
            Assert_GetNegationExpressionInvoke_True(sut, data.Candidate);
        }

        [Theory]
        [Trait("Category", "GetNegationExpression")]
        [IncorrectNegationData]
        public void GetNegationExpression_InvokeInvalidCandidate_ReturnFalse<TCandidate>(SpecificationTestCaseData<TCandidate, NegatableSpecificationFactory<TCandidate>> data)
        {
            var sut = CreateNegatableSpecification(data.Factory);
            Assert_GetNegationExpressionInvoke_False(sut, data.Candidate);
        }
    }
}
