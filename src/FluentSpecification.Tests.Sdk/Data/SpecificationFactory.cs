using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;

namespace FluentSpecification.Tests.Sdk.Data
{
    public abstract class SpecificationFactory
    {
        private readonly Dictionary<string, object> _parameters = new Dictionary<string, object>();

        public IReadOnlyDictionary<string, object> Parameters => _parameters;

        protected T Get<T>(string key) 
        {
            return _parameters.ContainsKey(key) && _parameters[key] is T param ? param : default;
        }

        protected void Set<T>(string key, T value)
        {
            if (_parameters.ContainsKey(key))
            {
                _parameters[key] = value;
            }
            else
            {
                _parameters.Add(key, value);
            }
        }
    }

    public abstract class SpecificationFactory<TCandidate> : SpecificationFactory
    {
        public abstract IComplexSpecification<TCandidate> Create();
    }

    public abstract class SpecificationFactory<TCandidate, TSpecification> : SpecificationFactory<TCandidate>,
        IComplexSpecificationFactory<TCandidate, TSpecification>
        where TSpecification : class, IComplexSpecification<TCandidate>
    {
        public abstract TSpecification CreateSpecification();

        public abstract Expression<Func<TCandidate, bool>> CastToExpression(TSpecification specification);
        public abstract Expression CastToAbstractExpression(TSpecification specification);
        public abstract Func<TCandidate, bool> CastToFunc(TSpecification specification);

        public override IComplexSpecification<TCandidate> Create()
        {
            return CreateSpecification();
        }
    }
}
