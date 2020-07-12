using System;
using System.Collections;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class LengthFactory<T> : NegatableSpecificationFactory<T, LengthSpecification<T>>
        where T : IEnumerable
    {
        public int Length
        {
            get => Get<int>(nameof(Length)); 
            private set => Set(nameof(Length), value);
        }

        public LengthFactory(int length)
        {
            Length = length;
        }

        public override LengthSpecification<T> CreateSpecification()
        {
            return new LengthSpecification<T>(Length);
        }

        public override Expression<Func<T, bool>> CastToExpression(LengthSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(LengthSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(LengthSpecification<T> specification)
            => specification;
    }

    public class LengthFactory : DefaultFactoryProxy<int[], LengthSpecification<int[]>>
    {
        public LengthFactory()
            : base(new LengthFactory<int[]>(0))
        {
        }
    }
}
