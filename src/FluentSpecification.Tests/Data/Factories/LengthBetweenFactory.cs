using System;
using System.Collections;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class LengthBetweenFactory<T> : NegatableSpecificationFactory<T, LengthBetweenSpecification<T>>
        where T : IEnumerable
    {
        public int MinLength
        {
            get => Get<int>(nameof(MinLength)); 
            private set => Set(nameof(MinLength), value);
        }

        public int MaxLength
        {
            get => Get<int>(nameof(MaxLength)); 
            private set => Set(nameof(MaxLength), value);
        }

        public LengthBetweenFactory(int minLength, int maxLength)
        {
            MinLength = minLength;
            MaxLength = maxLength;
        }

        public override LengthBetweenSpecification<T> CreateSpecification()
        {
            return new LengthBetweenSpecification<T>(MinLength, MaxLength);
        }

        public override Expression<Func<T, bool>> CastToExpression(LengthBetweenSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(LengthBetweenSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(LengthBetweenSpecification<T> specification)
            => specification;
    }

    public class LengthBetweenFactory : DefaultFactoryProxy<int[], LengthBetweenSpecification<int[]>>
    {
        public LengthBetweenFactory()
            : base(new LengthBetweenFactory<int[]>(0, 0))
        {
        }
    }
}
