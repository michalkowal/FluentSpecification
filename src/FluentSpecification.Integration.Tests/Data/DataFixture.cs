using System;
using System.Linq;

namespace FluentSpecification.Integration.Tests.Data
{
    public class DataFixture
    {
        public DataFixture()
        {
            foreach (var customer in Customers)
            {
                customer.CreditCard =
                    CreditCards.SingleOrDefault(cc => cc.CustomerId == customer.CustomerId);
                if (customer.CaretakerId.HasValue)
                    customer.Caretaker =
                        Customers.Single(c => c.CustomerId == customer.CaretakerId.Value);
                customer.Items = Items.Where(i => i.CustomerId == customer.CustomerId).ToList();
            }

            foreach (var item in Items) item.Customer = Customers.Single(c => c.CustomerId == item.CustomerId);

            foreach (var creditCard in CreditCards)
                creditCard.Customer = Customers.Single(c => c.CustomerId == creditCard.CustomerId);
        }

        public Event[] Events { get; } =
        {
            new Event {Id = 1, Code = "Defqon.1", Name = "Purple Tail", IsArchival = false},
            new Event {Id = 2, Code = "Qlimax", Name = "The Power Of The Mind", IsArchival = false},
            new Event {Id = 3, Code = "Q-Base", Name = "Silver Bullet", IsArchival = false},
            new Event {Id = 4, Code = "In Qontrol", Name = "The Last City On Earth", IsArchival = true},
            new Event
            {
                Id = 5, Code = "Defqon.1 Australia", Name = "All aboard, this is easy for real", IsArchival = false
            },
            new Event {Id = 6, Code = "Decibel", Name = "Party down in the city of light", IsArchival = false},
            new Event {Id = 7, Code = "Hard Bass", Name = "You like the bass?", IsArchival = true},
            new Event {Id = 8, Code = "X-Qlusive", Name = "Explore the miracle", IsArchival = false},
            new Event {Id = 9, Code = "Qountdown", Name = "Put some grace in your face", IsArchival = true},
            new Event
            {
                Id = 100, Code = "Sensation Black", Name = "We interrupt this program to bring you important news",
                IsArchival = true
            }
        };

        public CreditCard[] CreditCards { get; } =
        {
            new CreditCard
            {
                CardNumber = "5500 0000 0000 0004",
                ValidityDate = DateTime.Parse("2019-03-12"),
                CustomerId = 152
            },
            new CreditCard
            {
                CardNumber = "3400 0000 0000 009",
                ValidityDate = DateTime.Parse("2019-02-09"),
                CustomerId = 174
            }
        };

        public Item[] Items { get; } =
        {
            new Item
            {
                ItemId = 2,
                Name = "SuperItem5",
                Price = 50.99,
                Paid = false,
                CustomerId = 152
            },
            new Item
            {
                ItemId = 3,
                Name = "abc",
                Price = 1.5,
                Paid = false,
                CustomerId = 152
            },
            new Item
            {
                ItemId = 12,
                Name = "alterego2000",
                Price = 25,
                Paid = false,
                CustomerId = 152
            },
            new Item
            {
                ItemId = 56,
                Name = "Mighty Thor",
                Price = 19.99,
                Paid = true,
                CustomerId = 1000
            }
        };

        public Customer[] Customers { get; } =
        {
            new Customer
            {
                CustomerId = 152,
                FirstName = "Mark",
                LastName = "Kowalski",
                IsActive = true,
                Email = "mark.kowalski@email.com",
                Comments = null
            },
            new Customer
            {
                CustomerId = 174,
                FirstName = "Dean",
                LastName = "Mean",
                IsActive = false,
                Email = "yarol@porto.com",
                Comments = null
            },
            new Customer
            {
                CustomerId = 1000,
                FirstName = "Adam",
                LastName = "Kowalski",
                IsActive = true,
                Email = null,
                Comments = "Young one",
                CaretakerId = 152
            }
        };
    }
}