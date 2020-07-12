using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Framework;
using Xunit;

namespace FluentSpecification.Tests.Sdk
{
    public abstract partial class ComplexSpecificationTests<T>
    {
        [Theory]
        [Trait("Category", "GetExpression")]
        [CorrectData]
        public void GetExpression_InvokeValidCandidate_ReturnTrue<TCandidate>(SpecificationTestCaseData<TCandidate, SpecificationFactory<TCandidate>> data)
        {
            var sut = CreateSpecification(data.Factory);
            Assert_GetExpressionInvoke_True(sut, data.Candidate);
        }

        [Theory]
        [Trait("Category", "GetExpression")]
        [IncorrectData]
        public void GetExpression_InvokeInvalidCandidate_ReturnFalse<TCandidate>(SpecificationTestCaseData<TCandidate, SpecificationFactory<TCandidate>> data)
        {
            var sut = CreateSpecification(data.Factory);
            Assert_GetExpressionInvoke_False(sut, data.Candidate);
        }

        [Theory]
        [Trait("Category", "GetExpression")]
        [SpecificationFactoryData]
        public void GetExpression_NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression<TCandidate>(SpecificationFactory<TCandidate> factory)
        {
            var sut = CreateSpecification(factory);
            Assert_GetExpression_EqualsBaseExpression(sut);
        }
    }
}
