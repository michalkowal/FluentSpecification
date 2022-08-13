using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace FluentSpecification.Tests.Sdk.Data
{
    [PublicAPI]
    public abstract class SpecificationData
    {
        protected const string DateTimeRegexPattern =
            "(([0-9]{1,2}.{1}[0-9]{1,2}.{1}[0-9]{4})|([0-9]{4}.[0-9]{1,2}.[0-9]{1,2})) [0-9]{2}:[0-9]{2}:[0-9]{2}.*";

        private readonly List<SpecificationDataRow> _invalid = new List<SpecificationDataRow>();

        private readonly List<SpecificationDataRow> _valid = new List<SpecificationDataRow>();

        public bool AsNegation { get; set; }

        protected SpecificationDataRow AddValid(params object[] data)
        {
            var row = new SpecificationDataRow(true, data);
            _valid.Add(row);

            return row;
        }

        protected SpecificationDataRow AddInvalid(params object[] data)
        {
            var row = new SpecificationDataRow(false, data);
            _invalid.Add(row);

            return row;
        }

        public IEnumerable<object[]> GetValidData(bool skipResult = true)
        {
            if (!AsNegation)
                return _valid.Select(a => a.GetData(!skipResult));
            return _invalid.Select(a => a.GetData(false, !skipResult));
        }

        public IEnumerable<object[]> GetInvalidData(bool skipResult = true)
        {
            if (!AsNegation)
                return _invalid.Select(a => a.GetData(!skipResult));
            return _valid.Select(a => a.GetData(false, !skipResult));
        }
    }

    [PublicAPI]
    public class SpecificationData<T> : SpecificationData
    {
        public SpecificationDataRow Valid(T p)
        {
            return AddValid(p);
        }

        public SpecificationDataRow Invalid(T p)
        {
            return AddInvalid(p);
        }
    }

    [PublicAPI]
    public class SpecificationData<T1, T2> : SpecificationData
    {
        public SpecificationDataRow Valid(T1 p1, T2 p2)
        {
            return AddValid(p1, p2);
        }

        public SpecificationDataRow Invalid(T1 p1, T2 p2)
        {
            return AddInvalid(p1, p2);
        }
    }

    [PublicAPI]
    public class SpecificationData<T1, T2, T3> : SpecificationData
    {
        public SpecificationDataRow Valid(T1 p1, T2 p2, T3 p3)
        {
            return AddValid(p1, p2, p3);
        }

        public SpecificationDataRow Invalid(T1 p1, T2 p2, T3 p3)
        {
            return AddInvalid(p1, p2, p3);
        }
    }

    [PublicAPI]
    public class SpecificationData<T1, T2, T3, T4> : SpecificationData
    {
        public SpecificationDataRow Valid(T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return AddValid(p1, p2, p3, p4);
        }

        public SpecificationDataRow Invalid(T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return AddInvalid(p1, p2, p3, p4);
        }
    }
}