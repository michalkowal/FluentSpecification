using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class GreaterThanNullableData : SpecificationData<int?, int?>
    {
        public GreaterThanNullableData()
        {
            Valid(0, null)
                .Result("GreaterThanSpecification<Nullable<Int32>>")
                .NegationResult("NotGreaterThanSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<int?>), "Object is greater than [null]")
                    .Candidate(0)
                    .AddParameter("GreaterThan", null));

            Invalid(null, 0)
                .NegationResult("NotGreaterThanSpecification<Nullable<Int32>>")
                .Result("GreaterThanSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<int?>), "Object is lower than or equal to [0]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", 0));
            Invalid(null, null)
                .NegationResult("NotGreaterThanSpecification<Nullable<Int32>>")
                .Result("GreaterThanSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(GreaterThanSpecification<int?>),
                        "Object is lower than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("GreaterThan", null));
        }
    }
}