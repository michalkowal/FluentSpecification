using System;
using System.Collections;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class MaxLengthFactory<T> : NegatableSpecificationFactory<T, MaxLengthSpecification<T>>
        where T : IEnumerable
    {
        public int MaxLength
        {
            get => Get<int>(nameof(MaxLength)); 
            private set => Set(nameof(MaxLength), value);
        }

        public MaxLengthFactory(int maxLength)
        {
            MaxLength = maxLength;
        }

        public override MaxLengthSpecification<T> CreateSpecification()
        {
            return new MaxLengthSpecification<T>(MaxLength);
        }

        public override Expression<Func<T, bool>> CastToExpression(MaxLengthSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(MaxLengthSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(MaxLengthSpecification<T> specification)
            => specification;
    }

    public class MaxLengthFactory : DefaultFactoryProxy<int[], MaxLengthSpecification<int[]>>
    {
        public MaxLengthFactory()
            : base(new MaxLengthFactory<int[]>(0))
        {
        }
    }
}
