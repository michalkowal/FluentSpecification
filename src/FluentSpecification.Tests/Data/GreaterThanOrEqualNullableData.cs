using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class GreaterThanOrEqualNullableData : SpecificationData<int?, int?>
    {
        public GreaterThanOrEqualNullableData()
        {
            Valid(0, null)
                .Result("GreaterThanOrEqualSpecification<Nullable<Int32>>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<int?>),
                        "Object is greater than or equal to [null]")
                    .Candidate(0)
                    .AddParameter("GreaterThan", null));
            Valid(null, null)
                .Result("GreaterThanOrEqualSpecification<Nullable<Int32>>")
                .NegationResult("NotGreaterThanOrEqualSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<int?>),
                        "Object is greater than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", null));

            Invalid(null, 0)
                .NegationResult("NotGreaterThanOrEqualSpecification<Nullable<Int32>>")
                .Result("GreaterThanOrEqualSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanOrEqualSpecification<int?>), "Object is lower than [0]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", 0));
        }
    }
}