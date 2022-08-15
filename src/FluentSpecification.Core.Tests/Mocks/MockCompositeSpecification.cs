using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Composite;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal abstract class MockCompositeSpecification<T> : CompositeSpecification<T>
    {
        public class InternalSpecification : MockValidationSpecification<T>
        {
            private readonly int _externalParam;

            public InternalSpecification(bool result, int externalParam) : base(result)
            {
                _externalParam = externalParam;
            }

            protected override string TraceMessage => "MockCompositeInternalSpecification";

            protected override IReadOnlyDictionary<string, object> GetParameters()
            {
                var result = base.GetParameters().ToDictionary(kv => kv.Key, kv => kv.Value);
                result.Add("External", _externalParam);

                return result;
            }
        }

        protected readonly bool Result;

        protected MockCompositeSpecification(bool result, int leftParam, int rightParam)
            : base(new InternalSpecification(result, leftParam), new InternalSpecification(result, rightParam), Expression.AndAlso)
        {
            Result = result;
        }

        protected override string TraceMessageConnector => "Mock";

        protected override bool Merge(bool left, bool right)
        {
            return Result;
        }

        public static IComplexSpecification<T> Create(bool result, int leftParam = 0, int rightParam = 0)
        {
            return result ? True(leftParam, rightParam) : False(leftParam, rightParam);
        }

        public static IComplexSpecification<T> True(int leftParam = 0, int rightParam = 0)
        {
            return new TrueMockCompositeSpecification<T>(leftParam, rightParam);
        }

        public static IComplexSpecification<T> False(int leftParam = 0, int rightParam = 0)
        {
            return new FalseMockCompositeSpecification<T>(leftParam, rightParam);
        }
    }

    internal class TrueMockCompositeSpecification<T> : MockCompositeSpecification<T>
    {
        public TrueMockCompositeSpecification(int leftParam, int rightParam)
            : base(true, leftParam, rightParam)
        {
        }
    }

    internal class FalseMockCompositeSpecification<T> : MockCompositeSpecification<T>
    {
        public FalseMockCompositeSpecification(int leftParam, int rightParam)
            : base(false, leftParam, rightParam)
        {
        }
    }

    internal abstract class MockCompositeSpecification : MockCompositeSpecification<object>
    {
        protected MockCompositeSpecification(bool result, int leftParam, int rightParam)
            : base(result, leftParam, rightParam)
        {
        }

        public new static IComplexSpecification<object> Create(bool result, int leftParam = 0, int rightParam = 0)
        {
            return result ? True(leftParam, rightParam) : False(leftParam, rightParam);
        }

        public new static IComplexSpecification<object> True(int leftParam = 0, int rightParam = 0)
        {
            return new TrueMockCompositeSpecification(leftParam, rightParam);
        }

        public new static IComplexSpecification<object> False(int leftParam = 0, int rightParam = 0)
        {
            return new FalseMockCompositeSpecification(leftParam, rightParam);
        }
    }

    internal class TrueMockCompositeSpecification : MockCompositeSpecification
    {
        public TrueMockCompositeSpecification(int leftParam, int rightParam)
            : base(true, leftParam, rightParam)
        {
        }
    }

    internal class FalseMockCompositeSpecification : MockCompositeSpecification
    {
        public FalseMockCompositeSpecification(int leftParam, int rightParam)
            : base(false, leftParam, rightParam)
        {
        }
    }
}
