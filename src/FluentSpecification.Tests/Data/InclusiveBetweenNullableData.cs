using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class InclusiveBetweenNullableData : SpecificationData<int?, int?, int?>
    {
        public InclusiveBetweenNullableData()
        {
            Valid(0, null, 1)
                .Result("InclusiveBetweenSpecification<Nullable<Int32>>")
                .NegationResult("NotInclusiveBetweenSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<int?>), "Value is between [null] and [1]")
                    .Candidate(0)
                    .AddParameter("From", null)
                    .AddParameter("To", 1));
            Valid(null, null, 1)
                .Result("InclusiveBetweenSpecification<Nullable<Int32>>")
                .NegationResult("NotInclusiveBetweenSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<int?>), "Value is between [null] and [1]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", 1));
            Valid(null, null, null)
                .Result("InclusiveBetweenSpecification<Nullable<Int32>>")
                .NegationResult("NotInclusiveBetweenSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<int?>),
                        "Value is between [null] and [null]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", null));

            Invalid(null, 0, 1)
                .NegationResult("NotInclusiveBetweenSpecification<Nullable<Int32>>")
                .Result("InclusiveBetweenSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(InclusiveBetweenSpecification<int?>),
                        "Value is not between [0] and [1]")
                    .Candidate(null)
                    .AddParameter("From", 0)
                    .AddParameter("To", 1));
        }
    }
}