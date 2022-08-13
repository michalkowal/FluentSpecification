﻿using FluentSpecification.Integration.Tests.Data;
using FluentSpecification.Core;
using System;
using Xunit;
using System.Collections.Generic;
using FluentSpecification.Integration.Tests.Logic;

namespace FluentSpecification.Integration.Tests
{
    public class TranslationsIntegrationTests
    {
        private readonly DataFixture _fixture = new DataFixture();

        [Fact]
        public void IncorrectCustomer_ShouldReturnError()
        {
            var sut = Specification
               .Null<Customer, int?>(c => c.CaretakerId)
               .And()
               .NotNull(c => c.CreditCard)
               .And()
               .CreditCard(c => c.CreditCard.CardNumber)
               .And()
               .GreaterThanOrEqual(c => c.CreditCard.ValidityDate, new DateTime(2019, 1, 1))
               .And()
               .NotEmpty(c => c.Items)
               .And()
               .Any(c => c.Items, Specification.False<Item>(i => i.Paid))
               .WithMessage("Invalid customer");

            var candidate = _fixture.Customers[2];
            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.False(overall);
            Assert.Equal(1, result.Errors.Count);
            Assert.Equal("Invalid customer", result.Errors[0]);
        }

        [Fact]
        public void IncorrectCustomer_ShouldReturnAllErrors()
        {
            var childSpec = new CustomerHasNotChildSpecification()
               .WithMessage("Customer cannot have child");
            var creditCardSpec = Specification
               .Null<Customer, CreditCard>(c => c.CreditCard)
               .Or()
               .NotCreditCard(c => c.CreditCard.CardNumber)
               .Or()
               .NotGreaterThanOrEqual(c => c.CreditCard.ValidityDate, new DateTime(2019, 1, 1))
               .Not()   // Negate all
               .WithMessage("Customer should have valid credit card");
            var itemSpec = Specification
               .NotEmpty<Customer, ICollection<Item>>(c => c.Items)
               .And()
               .Any(c => c.Items, Specification.False<Item>(i => i.Paid))
               .WithMessage("Customer shoud have at least one unpaid item");

            var sut = childSpec.And(creditCardSpec).And(itemSpec);

            var candidate = _fixture.Customers[2];
            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.False(overall);
            Assert.Equal(3, result.Errors.Count);
            Assert.Equal("Customer cannot have child", result.Errors[0]);
            Assert.Equal("Customer should have valid credit card", result.Errors[1]);
            Assert.Equal("Customer shoud have at least one unpaid item", result.Errors[2]);
        }

        [Fact]
        public void IncorrectCustomer_ShouldReturnOnlyLastError()
        {
            var sut = new CustomerHasNotChildSpecification()
               .WithMessage("Customer cannot have child")
               .And()
               .NotNull(c => c.CreditCard)
               .And()
               .CreditCard(c => c.CreditCard.CardNumber)
               .And()
               .GreaterThanOrEqual(c => c.CreditCard.ValidityDate, new DateTime(2019, 1, 1))
               .WithMessage("Customer should have valid credit card")
               .And()
               .NotEmpty(c => c.Items)
               .And()
               .Any(c => c.Items, Specification.False<Item>(i => i.Paid))
               .WithMessage("Customer shoud have at least one unpaid item");

            var candidate = _fixture.Customers[2];
            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.False(overall);
            Assert.Equal(1, result.Errors.Count);
            Assert.Equal("Customer shoud have at least one unpaid item", result.Errors[0]);
        }

        [Fact]
        public void CorrectCustomer_ShouldReturnNoError()
        {
            var childSpec = new CustomerHasNotChildSpecification()
               .WithMessage("Customer cannot have child");
            var creditCardSpec = Specification
               .NotNull<Customer, CreditCard>(c => c.CreditCard)
               .And()
               .CreditCard(c => c.CreditCard.CardNumber)
               .And()
               .GreaterThanOrEqual(c => c.CreditCard.ValidityDate, new DateTime(2019, 1, 1))
               .WithMessage("Customer should have valid credit card");
            var itemSpec = Specification
               .NotEmpty<Customer, ICollection<Item>>(c => c.Items)
               .And()
               .Any(c => c.Items, Specification.False<Item>(i => i.Paid))
               .WithMessage("Customer shoud have at least one unpaid item");

            var sut = childSpec.And(creditCardSpec).And(itemSpec);

            var candidate = _fixture.Customers[0];
            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.True(overall);
            Assert.Equal(0, result.Errors.Count);
        }
    }
}
