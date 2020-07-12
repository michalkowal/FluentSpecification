using System;
using System.Linq.Expressions;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class PropertyData : SpecificationData
    {
        public PropertyData()
        {
            var candidate = new FakeType
            {
                First = 1,
                Second = "2",
                Inter = new InterFakeType()
            };
            var empty = new FakeType();
            var nullFake = new FakeType {Second = "null"};
            var ftSecondSelector = (Expression<Func<FakeType, string>>) (ft => ft.Second);
            var ftThirdSelector = (Expression<Func<FakeType, bool>>) (ft => ft.Inter.Third);

            AddValid(candidate, ftSecondSelector)
                .Result("PropertySpecification<FakeType,String>(TrueMockComplexSpecification[String])",
                    "Property(TrueMockComplex)",
                    c =>
                    {
                        c.Specification(typeof(PropertySpecification<FakeType, string>))
                            .Candidate(candidate)
                            .AddParameter("PropertySelector", ftSecondSelector)
                            .AddParameter("PropertyName", "Second")
                            .AddParameter("PropertySpecification", null);
                        c.Specification(typeof(TrueMockComplexSpecification<string>))
                            .Candidate("2")
                            .AddParameter("Result", true);
                    });
            AddValid(candidate, ftThirdSelector)
                .Result("PropertySpecification<FakeType,Boolean>(TrueMockComplexSpecification[Boolean])",
                    "Property(TrueMockComplex)",
                    c =>
                    {
                        c.Specification(typeof(PropertySpecification<FakeType, bool>))
                            .Candidate(candidate)
                            .AddParameter("PropertySelector", ftThirdSelector)
                            .AddParameter("PropertyName", "Inter.Third")
                            .AddParameter("PropertySpecification", null);
                        c.Specification(typeof(TrueMockComplexSpecification<bool>))
                            .Candidate(false)
                            .AddParameter("Result", true);
                    });
            AddValid(empty, ftSecondSelector)
                .Result("PropertySpecification<FakeType,String>(TrueMockComplexSpecification[String])",
                    "Property(TrueMockComplex)",
                    c =>
                    {
                        c.Specification(typeof(PropertySpecification<FakeType, string>))
                            .Candidate(empty)
                            .AddParameter("PropertySelector", ftSecondSelector)
                            .AddParameter("PropertyName", "Second")
                            .AddParameter("PropertySpecification", null);
                        c.Specification(typeof(TrueMockComplexSpecification<string>))
                            .Candidate(null)
                            .AddParameter("Result", true);
                    });

            AddInvalid(candidate, ftSecondSelector)
                .Result("PropertySpecification<FakeType,String>(FailedFalseMockComplexSpecification[String])+Failed",
                    "Property(FailedFalseMockComplex)+Failed",
                    c =>
                    {
                        c.FailedSpecification(typeof(PropertySpecification<FakeType, string>),
                                "Field 'Second' value is not valid")
                            .Candidate(candidate)
                            .AddParameter("PropertySelector", ftSecondSelector)
                            .AddParameter("PropertyName", "Second")
                            .AddParameter("PropertySpecification", null);
                        c.FailedSpecification(typeof(FalseMockComplexSpecification<string>),
                                "Field 'Second': [MockValidationSpecification is not satisfied]")
                            .Candidate("2")
                            .AddParameter("Result", false);
                    });
            AddInvalid(candidate, ftThirdSelector)
                .Result("PropertySpecification<FakeType,Boolean>(FailedFalseMockComplexSpecification[Boolean])+Failed",
                    "Property(FailedFalseMockComplex)+Failed",
                    c =>
                    {
                        c.FailedSpecification(typeof(PropertySpecification<FakeType, bool>),
                                "Field 'Inter.Third' value is not valid")
                            .Candidate(candidate)
                            .AddParameter("PropertySelector", ftThirdSelector)
                            .AddParameter("PropertyName", "Inter.Third")
                            .AddParameter("PropertySpecification", null);
                        c.FailedSpecification(typeof(FalseMockComplexSpecification<bool>),
                                "Field 'Inter.Third': [MockValidationSpecification is not satisfied]")
                            .Candidate(false)
                            .AddParameter("Result", false);
                    });
            AddInvalid(empty, ftThirdSelector)
                .Result("PropertySpecification<FakeType,Boolean>()+Failed",
                    "Property()+Failed",
                    c =>
                        c.FailedSpecification(typeof(PropertySpecification<FakeType, bool>),
                                "Field 'Inter.Third' value is not valid")
                            .Candidate(empty)
                            .AddParameter("PropertySelector", ftThirdSelector)
                            .AddParameter("PropertyName", "Inter.Third")
                            .AddParameter("PropertySpecification", null));
            AddInvalid(nullFake, ftSecondSelector)
                .Result("PropertySpecification<FakeType,String>()+Failed",
                    "Property()+Failed",
                    c =>
                        c.FailedSpecification(typeof(PropertySpecification<FakeType, string>),
                                "Field 'Second' value is not valid")
                            .Candidate(null)
                            .AddParameter("PropertySelector", ftSecondSelector)
                            .AddParameter("PropertyName", "Second")
                            .AddParameter("PropertySpecification", null));
        }
    }
}