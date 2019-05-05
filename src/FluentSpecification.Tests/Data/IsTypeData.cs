using System;
using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class IsTypeData : SpecificationData
    {
        public IsTypeData()
        {
            var ft = new ComparableFakeType();

            AddValid("", typeof(string))
                .Result("IsTypeSpecification<String>")
                .NegationResult("NotIsTypeSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(IsTypeSpecification<string>), "Object is type of [String]")
                    .Candidate("")
                    .AddParameter("Expected", typeof(string)));
            AddValid(1, typeof(int))
                .Result("IsTypeSpecification<Int32>")
                .NegationResult("NotIsTypeSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(IsTypeSpecification<int>), "Object is type of [Int32]")
                    .Candidate(1)
                    .AddParameter("Expected", typeof(int)));
            AddValid(ft, typeof(FakeType))
                .Result("IsTypeSpecification<ComparableFakeType>")
                .NegationResult("NotIsTypeSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(IsTypeSpecification<ComparableFakeType>),
                        "Object is type of [FakeType]")
                    .Candidate(ft)
                    .AddParameter("Expected", typeof(FakeType)));
            AddValid(ft, typeof(IComparable<ComparableFakeType>))
                .Result("IsTypeSpecification<ComparableFakeType>")
                .NegationResult("NotIsTypeSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(IsTypeSpecification<ComparableFakeType>),
                        "Object is type of [IComparable<ComparableFakeType>]")
                    .Candidate(ft)
                    .AddParameter("Expected", typeof(IComparable<ComparableFakeType>)));
            AddValid(ft, typeof(IEnumerable<int>))
                .Result("IsTypeSpecification<ComparableFakeType>")
                .NegationResult("NotIsTypeSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(IsTypeSpecification<ComparableFakeType>),
                        "Object is type of [IEnumerable<Int32>]")
                    .Candidate(ft)
                    .AddParameter("Expected", typeof(IEnumerable<int>)));

            AddInvalid("", typeof(int))
                .NegationResult("NotIsTypeSpecification<String>")
                .Result("IsTypeSpecification<String>+Failed", c => c
                    .FailedSpecification(typeof(IsTypeSpecification<string>), "Object is not type of [Int32]")
                    .Candidate("")
                    .AddParameter("Expected", typeof(int)));
            AddInvalid(1, typeof(string))
                .NegationResult("NotIsTypeSpecification<Int32>")
                .Result("IsTypeSpecification<Int32>+Failed", c => c
                    .FailedSpecification(typeof(IsTypeSpecification<int>), "Object is not type of [String]")
                    .Candidate(1)
                    .AddParameter("Expected", typeof(string)));
            AddInvalid(ft, typeof(string))
                .NegationResult("NotIsTypeSpecification<ComparableFakeType>")
                .Result("IsTypeSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(IsTypeSpecification<ComparableFakeType>),
                        "Object is not type of [String]")
                    .Candidate(ft)
                    .AddParameter("Expected", typeof(string)));
            AddInvalid(ft, typeof(EquatableFakeType))
                .NegationResult("NotIsTypeSpecification<ComparableFakeType>")
                .Result("IsTypeSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(IsTypeSpecification<ComparableFakeType>),
                        "Object is not type of [EquatableFakeType]")
                    .Candidate(ft)
                    .AddParameter("Expected", typeof(EquatableFakeType)));
            AddInvalid(ft, typeof(IEquatable<ComparableFakeType>))
                .NegationResult("NotIsTypeSpecification<ComparableFakeType>")
                .Result("IsTypeSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(IsTypeSpecification<ComparableFakeType>),
                        "Object is not type of [IEquatable<ComparableFakeType>]")
                    .Candidate(ft)
                    .AddParameter("Expected", typeof(IEquatable<ComparableFakeType>)));
            AddInvalid(ft, typeof(IComparable<FakeType>))
                .NegationResult("NotIsTypeSpecification<ComparableFakeType>")
                .Result("IsTypeSpecification<ComparableFakeType>+Failed", c => c
                    .FailedSpecification(typeof(IsTypeSpecification<ComparableFakeType>),
                        "Object is not type of [IComparable<FakeType>]")
                    .Candidate("")
                    .AddParameter("Expected", typeof(IComparable<FakeType>)));
        }
    }
}