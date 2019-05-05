using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FluentSpecification.Core;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Integration.Tests.Data
{
    public class IntegrationData : SpecificationData
    {
        public IntegrationData()
        {
            var spec1 = Specification
                .InclusiveBetween<Customer, int>(c => c.CustomerId, 100, 200)
                .And()
                .Equal(c => c.LastName, "Kowalski")
                .And()
                .True(c => c.IsActive)
                .And(Specification.ForProperty<Customer, string>(c => c.Email, Specification
                    .Email()
                    .And()
                    .MinLength(8)
                    .And()
                    .Match("^.*@email.com$")))
                .And()
                .NotLengthBetween(c => c.Comments, 1, 10)
                .And()
                .ForProperty(c => c.Items, Specification
                    .NotEmpty<ICollection<Item>>()
                    .And()
                    .NotMinLength(10)
                    .And()
                    .IsType(typeof(IEnumerable))
                    .And()
                    .IsNotType(typeof(ReadOnlyCollection<Item>))
                    .And(Specification
                        .Contains<ICollection<Item>, Item>(new Item {ItemId = 1000})
                        .Or()
                        .Any(Specification.Or(Specification
                                .NotContains<Item>(i => i.Name, "Super")
                                .And()
                                .ExclusiveBetween(i => i.Price, 50, 51),
                            Specification
                                .NotMaxLength<Item, string>(i => i.Name, 3)
                                .And()
                                .Cast(i => i.Price, Specification.NotLessThan(1))))))
                .And()
                .NotNull(c => c.CreditCard)
                .And()
                .CreditCard(c => c.CreditCard.CardNumber)
                .And(Specification
                    .GreaterThan<Customer, DateTime>(c => c.CreditCard.ValidityDate, new DateTime(2019, 6, 1))
                    .Or()
                    .LessThanOrEqual(c => c.CreditCard.ValidityDate, new DateTime(2019, 3, 12)))
                .And()
                .Null(c => c.Caretaker);

            var spec2 = Specification
                .NotLessThanOrEqual<Customer, int>(c => c.CustomerId, 100)
                .And()
                .NotEqual(c => c.LastName, "Kowalski")
                .And()
                .False(c => c.IsActive)
                .And()
                .NotMatch(c => c.Email, "@gmail.com")
                .And()
                .Empty(c => c.Items)
                .And()
                .ForProperty(c => c.CreditCard, Specification
                    .NotCreditCard<CreditCard>(cc => cc.CardNumber)
                    .AndNot()
                    .Length(cc => cc.CardNumber, 18)
                    .Not()
                    .Or()
                    .NotExclusiveBetween(cc => cc.ValidityDate, new DateTime(2019, 1, 1), new DateTime(2019, 12, 31)));

            var spec3 = Specification
                .ForProperty<Customer, int>(c => c.CustomerId, Specification
                    .GreaterThanOrEqual(1000)
                    .And()
                    .NotGreaterThanOrEqual(2000))
                .And()
                .NotEmail(c => c.Email)
                .And()
                .LengthBetween(c => c.Comments, 1, 10)
                .And()
                .ForProperty(c => c.Caretaker, Specification
                    .NotNull<Customer>()
                    .And()
                    .NotGreaterThan(ct => ct.CustomerId, 200))
                .And()
                .ForProperty(c => c.Items, Specification
                    .Length<ICollection<Item>>(1)
                    .And()
                    .NotContains(new Item {ItemId = 100})
                    .And()
                    .Any(Specification
                        .Expression<Item>(i => i.Paid && i.Price > 0.0)
                        .And()
                        .NotInclusiveBetween(i => i.ItemId, 60, 80)
                        .And(Specification
                            .And<Item, string>(i => i.Name, Specification
                                    .Contains("Thor"),
                                Specification
                                    .MaxLength<string>(20)))
                        .And()
                        .LessThanOrEqual(i => i.Price, 20.0)));

            AddValid(spec1, 152);
            AddValid(spec2, 174);
            AddValid(spec3, 1000);

            AddInvalid(spec1.Not(), 174, 1000);
            AddInvalid(spec2.Not(), 152, 1000);
            AddInvalid(spec3.Not(), 152, 174);
        }
    }
}