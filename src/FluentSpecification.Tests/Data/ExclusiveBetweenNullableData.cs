using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class ExclusiveBetweenNullableData : SpecificationData<int?, int?, int?>
    {
        public ExclusiveBetweenNullableData()
        {
            Valid(0, null, 1)
                .Result("ExclusiveBetweenSpecification<Nullable<Int32>>")
                .NegationResult("NotExclusiveBetweenSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<int?>), "Value is between [null] and [1]")
                    .Candidate(0)
                    .AddParameter("From", null)
                    .AddParameter("To", 1));

            Invalid(null, 0, 1)
                .NegationResult("NotExclusiveBetweenSpecification<Nullable<Int32>>")
                .Result("ExclusiveBetweenSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<int?>),
                        "Value is not between [0] and [1]")
                    .Candidate(null)
                    .AddParameter("From", 0)
                    .AddParameter("To", 1));
            Invalid(null, null, 1)
                .NegationResult("NotExclusiveBetweenSpecification<Nullable<Int32>>")
                .Result("ExclusiveBetweenSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<int?>),
                        "Value is not between [null] and [1]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", 1));
            Invalid(null, null, null)
                .NegationResult("NotExclusiveBetweenSpecification<Nullable<Int32>>")
                .Result("ExclusiveBetweenSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(ExclusiveBetweenSpecification<int?>),
                        "Value is not between [null] and [null]")
                    .Candidate(null)
                    .AddParameter("From", null)
                    .AddParameter("To", null));
        }
    }
}