using System;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal abstract class MockNegatableComplexSpecification<T> :
        MockNegatableValidationSpecification<T>,
        IComplexSpecification<T>,
        INegatableLinqSpecification<T>
    {
        protected MockNegatableComplexSpecification(bool result) : base(result)
        {
        }

        public Expression<Func<T, bool>> GetExpression()
        {
            return obj => IsSatisfiedBy(obj);
        }

        Expression ILinqSpecification.GetExpression()
        {
            return GetExpression();
        }

        public Expression<Func<T, bool>> GetNegationExpression()
        {
            return obj => IsNotSatisfiedBy(obj);
        }

        public new static IComplexSpecification<T> Create(bool result)
        {
            return result ? True() : False();
        }

        public new static IComplexSpecification<T> True()
        {
            return new TrueMockNegatableComplexSpecification<T>();
        }

        public new static IComplexSpecification<T> False()
        {
            return new FalseMockNegatableComplexSpecification<T>();
        }
    }

    internal abstract class MockNegatableComplexSpecification :
        MockNegatableComplexSpecification<object>
    {
        protected MockNegatableComplexSpecification(bool result) : base(result)
        {
        }

        public new static IComplexSpecification<object> Create(bool result)
        {
            return result ? True() : False();
        }

        public new static IComplexSpecification<object> True()
        {
            return new TrueMockNegatableComplexSpecification();
        }

        public new static IComplexSpecification<object> False()
        {
            return new FalseMockNegatableComplexSpecification();
        }
    }

    internal class TrueMockNegatableComplexSpecification : MockNegatableComplexSpecification
    {
        public TrueMockNegatableComplexSpecification() : base(true)
        {
        }

        protected override SpecificationTrace TraceMessage { get; } = 
            new SpecificationTrace("TrueMockNegatableComplexSpecification",
                "TrueMockNegatableComplex");
    }

    internal class FalseMockNegatableComplexSpecification : MockNegatableComplexSpecification
    {
        public FalseMockNegatableComplexSpecification() : base(false)
        {
        }

        protected override SpecificationTrace TraceMessage { get; } = 
            new SpecificationTrace("FalseMockNegatableComplexSpecification",
                "FalseMockNegatableComplex");
    }
}