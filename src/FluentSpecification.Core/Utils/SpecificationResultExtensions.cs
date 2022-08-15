using FluentSpecification.Abstractions.Validation;
using System.Collections.Generic;
using System.Linq;

namespace FluentSpecification.Core.Utils
{
    /// <summary>
    ///     Extensions methods for <see cref="SpecificationResult" />.
    /// </summary>
    internal static class SpecificationResultExtensions
    {
        /// <summary>
        ///     Merge parameters from FailedSpecifications collections into one Dictionary
        /// </summary>
        /// <param name="result">Result object</param>
        /// <returns>Merged parameters</returns>
        public static IReadOnlyDictionary<string, object> MergeSpecificationParameters(this SpecificationResult result)
        {
            return result.FailedSpecifications.MergeParameters();
        }

        /// <summary>
        ///     Merge parameters from FailedSpecifications collections into one Dictionary
        /// </summary>
        /// <param name="failedSpecifications">Failed specifications collection</param>
        /// <returns>Merged parameters</returns>
        private static IReadOnlyDictionary<string, object> MergeParameters(this IEnumerable<FailedSpecification> failedSpecifications)
        {
            return failedSpecifications.SelectMany(s => s.Parameters).Merge();
        }

        /// <summary>
        ///     Merge parameters from multiple collections into single dictionary.
        ///     If there is more than one unique value for key, then values are packed into array.
        /// </summary>
        /// <param name="dictionary">Collection with parameters dictionary</param>
        /// <returns>Merged parameters</returns>
        private static IReadOnlyDictionary<string, object> Merge(this IEnumerable<KeyValuePair<string, object>> dictionary)
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
