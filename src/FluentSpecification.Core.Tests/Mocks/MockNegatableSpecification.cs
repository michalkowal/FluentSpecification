using FluentSpecification.Abstractions.Generic;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal abstract class MockNegatableSpecification<T> :
        MockSpecification<T>,
        INegatableSpecification<T>
    {
        protected MockNegatableSpecification(bool result) : base(result)
        {
        }

        public bool IsNotSatisfiedBy(T candidate)
        {
            return !Result;
        }

        public new static ISpecification<T> Create(bool result)
        {
            return result ? True() : False();
        }

        public new static ISpecification<T> True()
        {
            return new TrueMockNegatableSpecification<T>();
        }

        public new static ISpecification<T> False()
        {
            return new FalseMockNegatableSpecification<T>();
        }
    }

    internal abstract class MockNegatableSpecification : MockNegatableSpecification<object>
    {
        protected MockNegatableSpecification(bool result)
            : base(result)
        {
        }

        public new static ISpecification<object> Create(bool result)
        {
            return result ? True() : False();
        }

        public new static ISpecification<object> True()
        {
            return new TrueMockNegatableSpecification();
        }

        public new static ISpecification<object> False()
        {
            return new FalseMockNegatableSpecification();
        }
    }

    internal class TrueMockNegatableSpecification : MockNegatableSpecification
    {
        public TrueMockNegatableSpecification() : base(true)
        {
        }
    }

    internal class FalseMockNegatableSpecification : MockNegatableSpecification
    {
        public FalseMockNegatableSpecification() : base(false)
        {
        }
    }
}