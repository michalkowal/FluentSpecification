using FluentSpecification.Abstractions.Validation;
using System.Collections.Generic;
using System.Linq;

namespace FluentSpecification.Core.Utils
{
    internal static class SpecificationResultExtensions
    {
        public static IReadOnlyDictionary<string, object> MergeSpecificationParameters(this SpecificationResult result)
        {
            return result.FailedSpecifications.MergeParameters();
        }

        public static IReadOnlyDictionary<string, object> MergeParameters(this IEnumerable<FailedSpecification> failedSpecifications)
        {
            return failedSpecifications.SelectMany(s => s.Parameters).Merge();
        }

        public static IReadOnlyDictionary<string, object> Merge(this IEnumerable<KeyValuePair<string, object>> dictionary)
        {
            var result = new Dictionary<string, List<object>>();

            foreach (var pair in dictionary)
            {
                if (!result.ContainsKey(pair.Key))
                    result.Add(pair.Key, new List<object>());

                if (!result[pair.Key].Contains(pair.Value))
                    result[pair.Key].Add(pair.Value);
            }

            return result.ToDictionary(r => r.Key, r => GetDictionaryValue(r.Value));
        }

        private static object GetDictionaryValue(List<object> temp)
        {
            return temp.Count > 1 ? temp.ToArray() : temp.First();
        }
    }
}
