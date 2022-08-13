using System;
using System.Collections.Generic;
using System.Linq;
using FluentSpecification.Abstractions.Generic;
using JetBrains.Annotations;

namespace FluentSpecification.Abstractions.Validation
{
    /// <summary>
    ///     Contains summary of validation scenarios.
    ///     See <see cref="IValidationSpecification{T}" /> and <see cref="INegatableValidationSpecification{T}" />.
    /// </summary>
    /// <remarks>Contains information about <c>Specifications</c> chain and validation errors.</remarks>
    [PublicAPI]
    public class SpecificationResult
    {
        /// <summary>
        ///     Create "empty" result for successful single <c>Specification</c>.
        /// </summary>
        [PublicAPI]
        public SpecificationResult() :
            this(null)
        {
        }


        /// <summary>
        ///     Create "empty" result with trace, for successful single <c>Specification</c>.
        /// </summary>
        /// <param name="trace">
        ///     <para>Trace message.</para>
        ///     <para>Should contains short identifier of executed <c>Specifications</c> and relation between them.</para>
        /// </param>
        [PublicAPI]
        public SpecificationResult([CanBeNull] string trace) :
            this(1, true, trace)
        {
        }

        /// <summary>
        ///     Create result for single <c>Specification</c>.
        /// </summary>
        /// <param name="overallResult">Overall result returned by <c>IsSatisfiedBy</c> or <c>IsNotSatisfiedBy</c> method.</param>
        /// <param name="failedSpecifications">
        ///     <para>List of failed <c>Specifications</c>.</para>
        ///     <para>For definition of "failed" see <see cref="FailedSpecification" />.</para>
        /// </param>
        [PublicAPI]
        public SpecificationResult(bool overallResult,
            [CanBeNull] [ItemNotNull] params FailedSpecification[] failedSpecifications) :
            this(overallResult, (string)null, failedSpecifications)
        {
        }

        [PublicAPI]
        public SpecificationResult(bool overallResult, [CanBeNull][ItemNotNull] string[] errors,
            [CanBeNull][ItemNotNull] params FailedSpecification[] failedSpecifications) :
            this(overallResult, errors, null, failedSpecifications)
        {
        }

        /// <summary>
        ///     Create result with trace, for single <c>Specification</c>.
        /// </summary>
        /// <param name="overallResult">Overall result returned by <c>IsSatisfiedBy</c> or <c>IsNotSatisfiedBy</c> method.</param>
        /// <param name="trace">
        ///     <para>Trace message.</para>
        ///     <para>Should contains short identifier of executed <c>Specifications</c> and relation between them.</para>
        /// </param>
        /// <param name="failedSpecifications">
        ///     <para>List of failed <c>Specifications</c>.</para>
        ///     <para>For definition of "failed" see <see cref="FailedSpecification" />.</para>
        /// </param>
        [PublicAPI]
        public SpecificationResult(bool overallResult, [CanBeNull] string trace,
            [CanBeNull] [ItemNotNull] params FailedSpecification[] failedSpecifications) :
            this(1, overallResult, trace, failedSpecifications)
        {
        }

        [PublicAPI]
        public SpecificationResult(bool overallResult,
            [CanBeNull][ItemNotNull] string[] errors, [CanBeNull] string trace,
            [CanBeNull][ItemNotNull] params FailedSpecification[] failedSpecifications) :
            this(1, overallResult, errors, trace, failedSpecifications)
        {
        }

        /// <summary>
        ///     Create result for combined multiple <c>Specifications</c>.
        /// </summary>
        /// <param name="totalSpecificationsCount">Count of all executed <c>Specifications</c> in chain.</param>
        /// <param name="overallResult">Overall result returned by <c>IsSatisfiedBy</c> or <c>IsNotSatisfiedBy</c> method.</param>
        /// <param name="trace">
        ///     <para>Trace message.</para>
        ///     <para>Should contains short identifier of executed <c>Specifications</c> and relation between them.</para>
        /// </param>
        /// <param name="failedSpecifications">
        ///     <para>List of failed <c>Specifications</c>.</para>
        ///     <para>For definition of "failed" see <see cref="FailedSpecification" />.</para>
        /// </param>
        [PublicAPI]
        public SpecificationResult(int totalSpecificationsCount, bool overallResult, string trace,
            params FailedSpecification[] failedSpecifications)
            : this(totalSpecificationsCount, overallResult, null, trace, failedSpecifications)
        {
        }

        [PublicAPI]
        public SpecificationResult(int totalSpecificationsCount, bool overallResult,
            string[] errors, string trace,
            params FailedSpecification[] failedSpecifications)
        {
            TotalSpecificationsCount = totalSpecificationsCount;
            OverallResult = overallResult;
            FailedSpecifications = failedSpecifications ?? new FailedSpecification[0];
            Trace = trace;
            Errors = (errors?.Any() ?? false) ?
                errors :
                FailedSpecifications.SelectMany(fs => fs.Errors).ToArray();
        }

        /// <summary>
        ///     Count of all executed <c>Specifications</c> in chain.
        /// </summary>
        [PublicAPI]
        public int TotalSpecificationsCount { get; }

        /// <summary>
        ///     Overall result returned by <c>IsSatisfiedBy</c> or <c>IsNotSatisfiedBy</c> method.
        /// </summary>
        [PublicAPI]
        public bool OverallResult { get; }

        /// <summary>
        ///     List of failed <c>Specifications</c>.
        /// </summary>
        /// <remarks>For definition of "failed" see <see cref="FailedSpecification" />.</remarks>
        [PublicAPI]
        [NotNull]
        public IReadOnlyList<FailedSpecification> FailedSpecifications { get; }

        /// <summary>
        ///     Trace message.
        /// </summary>
        /// <remarks>
        ///     Excellent for debugging <c>Specifications</c> chain behavior from left to right.
        /// </remarks>
        /// <value>Should contains short identifier of executed <c>Specifications</c> and relation between them.</value>
        [PublicAPI]
        [CanBeNull]
        public string Trace { get; }

        /// <summary>
        ///     All failed <c>Specifications</c> errors.
        /// </summary>
        [PublicAPI]
        [NotNull]
        public IReadOnlyList<string> Errors { get; }

        /// <summary>
        ///     Count of failed <c>Specifications</c>.
        /// </summary>
        [PublicAPI]
        public int FailedSpecificationsCount => FailedSpecifications.Count;

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>All <c>Specifications</c> errors combined into one string.</returns>
        public override string ToString()
        {
            var result = string.Join(Environment.NewLine, Errors);
            return result;
        }
    }
}