using System;
using FluentSpecification.Abstractions.Generic;

namespace FluentSpecification.Core.Utils
{
    internal abstract class BaseFluentProxy<T> :
        ICompositeSpecification<T>
    {
        public ISpecification<T> BaseSpecification { get; }

        protected BaseFluentProxy(ISpecification<T> baseSpecification)
        {
            BaseSpecification = baseSpecification ?? throw new ArgumentNullException(nameof(baseSpecification));
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return BaseSpecification.IsSatisfiedBy(candidate);
        }

        public IComplexSpecification<T> Compose(ISpecification<T> other)
        {
            ISpecification<T> spec = other;
            if (other is ICompositeSpecification<T> compositeSpecification)
            {
                spec = compositeSpecification.BaseSpecification;
            }

            return OnCompose(spec);
        }

        protected abstract IComplexSpecification<T> OnCompose(ISpecification<T> other);
    }
}
