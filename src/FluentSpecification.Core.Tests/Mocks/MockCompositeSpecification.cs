using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Composite;
using System.Linq.Expressions;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal abstract class MockCompositeSpecification<T> : CompositeSpecification<T>
    {
        protected readonly bool Result;

        protected MockCompositeSpecification(bool result) 
            : base(CreateBaseSpecification(result), CreateBaseSpecification(result), Expression.AndAlso)
        {
            Result = result;
        }

        protected override string TraceMessageConnector => "Mock";

        protected override bool Merge(bool left, bool right)
        {
            return Result;
        }

        public static IComplexSpecification<T> Create(bool result)
        {
            return result ? True() : False();
        }

        public static IComplexSpecification<T> True()
        {
            return new TrueMockCompositeSpecification<T>();
        }

        public static IComplexSpecification<T> False()
        {
            return new FalseMockCompositeSpecification<T>();
        }

        private static IValidationSpecification<T> CreateBaseSpecification(bool result)
        {
            return MockValidationSpecification<T>.Create(result);
        }
    }

    internal class TrueMockCompositeSpecification<T> : MockCompositeSpecification<T>
    {
        public TrueMockCompositeSpecification() : base(true)
        {
        }
    }

    internal class FalseMockCompositeSpecification<T> : MockCompositeSpecification<T>
    {
        public FalseMockCompositeSpecification() : base(false)
        {
        }
    }

    internal abstract class MockCompositeSpecification : MockCompositeSpecification<object>
    {
        protected MockCompositeSpecification(bool result)
            : base(result)
        {
        }

        public static new IComplexSpecification<object> Create(bool result)
        {
            return result ? True() : False();
        }

        public static new IComplexSpecification<object> True()
        {
            return new TrueMockCompositeSpecification();
        }

        public static new IComplexSpecification<object> False()
        {
            return new FalseMockCompositeSpecification();
        }
    }

    internal class TrueMockCompositeSpecification : MockCompositeSpecification
    {
        public TrueMockCompositeSpecification() : base(true)
        {
        }
    }

    internal class FalseMockCompositeSpecification : MockCompositeSpecification
    {
        public FalseMockCompositeSpecification() : base(false)
        {
        }
    }
}
