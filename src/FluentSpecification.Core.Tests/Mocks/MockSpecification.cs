using FluentSpecification.Abstractions.Generic;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal abstract class MockSpecification<T> : ISpecification<T>
    {
        protected readonly bool Result;

        protected MockSpecification(bool result)
        {
            Result = result;
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return Result;
        }

        public static ISpecification<T> Create(bool result)
        {
            return result ? True() : False();
        }

        public static ISpecification<T> True()
        {
            return new TrueMockSpecification<T>();
        }

        public static ISpecification<T> False()
        {
            return new FalseMockSpecification<T>();
        }
    }

    internal abstract class MockSpecification : MockSpecification<object>
    {
        protected MockSpecification(bool result)
            : base(result)
        {
        }

        public new static ISpecification<object> Create(bool result)
        {
            return result ? True() : False();
        }

        public new static ISpecification<object> True()
        {
            return new TrueMockSpecification();
        }

        public new static ISpecification<object> False()
        {
            return new FalseMockSpecification();
        }
    }

    internal class TrueMockSpecification : MockSpecification
    {
        public TrueMockSpecification() : base(true)
        {
        }
    }

    internal class FalseMockSpecification : MockSpecification
    {
        public FalseMockSpecification() : base(false)
        {
        }
    }
}