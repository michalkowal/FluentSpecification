using System;
using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;

namespace FluentSpecification.Tests.Sdk.Data
{
    public class FailedSpecificationDataRow
    {
        private readonly string[] _errors;
        private readonly Dictionary<string, object> _parameters = new Dictionary<string, object>();
        private readonly Type _specType;
        private object _candidate;

        public FailedSpecificationDataRow(Type specificationType, string[] errors)
        {
            _specType = specificationType;
            _errors = errors;
        }

        public FailedSpecificationDataRow Candidate(object candidate)
        {
            _candidate = candidate;
            return this;
        }

        public FailedSpecificationDataRow AddParameter(string key, object value)
        {
            _parameters.Add(key, value);
            return this;
        }

        public SpecificationInfo CreateFailedSpecification()
        {
            return new SpecificationInfo(_specType, _parameters, _candidate, _errors);
        }
    }
}