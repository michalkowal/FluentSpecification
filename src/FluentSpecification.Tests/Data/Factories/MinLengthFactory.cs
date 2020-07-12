using System;
using System.Collections;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class MinLengthFactory<T> : NegatableSpecificationFactory<T, MinLengthSpecification<T>>
        where T : IEnumerable
    {
        public int MinLength
        {
            get => Get<int>(nameof(MinLength)); 
            private set => Set(nameof(MinLength), value);
        }

        public MinLengthFactory(int minLength)
        {
            MinLength = minLength;
        }

        public override MinLengthSpecification<T> CreateSpecification()
        {
            return new MinLengthSpecification<T>(MinLength);
        }

        public override Expression<Func<T, bool>> CastToExpression(MinLengthSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(MinLengthSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(MinLengthSpecification<T> specification)
            => specification;
    }

    public class MinLengthFactory : DefaultFactoryProxy<int[], MinLengthSpecification<int[]>>
    {
        public MinLengthFactory()
            : base(new MinLengthFactory<int[]>(0))
        {
        }
    }
}
