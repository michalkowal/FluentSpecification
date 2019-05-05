Description: Main concept of <i>Specifications Design Pattern</i> and <i>FluentSpecification</i>.
Order: 100
---

The main idea of *FluentSpecification* is to prepare complex *Specifications* solution for all kinds of business cases - not only for validation but also for queries and repositories.  

# Business Model

*Eric Evans* in his book *Domain-Driven Design* describes *Specifications*, and their impact on *Business Model*:  
> Business rules often do not fit the responsibility of any of the obvious ENTITIES or VALUE OBJECTS,  
> and their variety and combinations can overwhelm the basic meaning of the domain object.  
> But moving the rules out of the domain layer is even worse,  
> since the domain code no longer expresses the model.  
>   
> Logic programming provides the concept of separate, combinable, rule objects called "predicates",  
> but full implementation of this concept with objects is cumbersome.  
> It is also so general that it doesn't communicate intent as much as more specialized designs.  

# Usage

*Eric Evans* recommends, to use *Specifications*:
- To validate an object to see if it fulfills some need or is ready for some purpose
- To select an object from a collection (as in the case of querying for overdue invoices)
- To specify the creation of a new object to fit some need

## Validation

<div class="mermaid abstraction">
    graph BT
        InvoiceSpec["<b>Invoice Specification</b><br/><br/><i>isSatisfiedBy(Invoice) : boolean</i>"]
        DelinquentSpec["<b>Delinquent Invoice Specification</b><br/><br/><i>current date</i>"]-->|extends|InvoiceSpec
        BigSpec["<b>Big Invoice Specification</b><br/><br/><i>threshold amount</i>"]-->|extends|InvoiceSpec
        InvoiceSpec-->|uses|Invoice["<b>Invoice</b><br/><br/><i>amount<br/>due date</i>"]
        Customer["Customer"]-->|* has many|Invoice
</div>

```java
class DelinquentInvoiceSpecification extends
    InvoiceSpecification {
    
    private Date currentDate;
    
    // An instance is used and discarded on a single date
    public DelinquentInvoiceSpecification(Date currentDate) {
        this.currentDate = currentDate;
    }
    
    public boolean isSatisfiedBy(Invoice candidate) {
        int gracePeriod =
        candidate.customer().getPaymentGracePeriod();
        Date firmDeadline =
            DateUtility.addDaysToDate(candidate.dueDate(),
                gracePeriod);
        return currentDate.after(firmDeadline);
    }
}
```
```java
public boolean accountIsDelinquent(Customer customer) {
    Date today = new Date();
    Specification delinquentSpec =
        new DelinquentInvoiceSpecification(today);
        
    Iterator it = customer.getInvoices().iterator();
    while (it.hasNext()) {
        Invoice candidate = (Invoice) it.next();
        if (delinquentSpec.isSatisfiedBy(candidate)) return true;
    }
    
    return false;
}
```

## Querying

```java
public Set selectSatisfying(InvoiceSpecification spec) {
    Set results = new HashSet();
    
    Iterator it = invoices.iterator();
    while (it.hasNext()) {
        Invoice candidate = (Invoice) it.next();
        if (spec.isSatisfiedBy(candidate)) results.add(candidate);
    }
    
    return results;
}
```
```java
Set delinquentInvoices = invoiceRepository.selectSatisfying(
    new DelinquentInvoiceSpecification(currentDate));
```

# Extending Specifications

In next chapters *Eric Evans* proposed: extending *Specifications* in a Declarative Style:

<div class="mermaid abstraction">
    graph BT
        CompositeSpec["<b>Composite Specification</b><br/><br/><i>isSatisfiedBy(Object) : boolean<br/>and(Specification) : Specification<br/>or(Specification) : Specification<br/>not() : Specification</i>"]
        AndSpec["<b>AND Specification</b>"]-->|extends|CompositeSpec
        OrSpec["<b>OR Specification</b>"]-->|extends|CompositeSpec
        NotSpec["<b>NOT Specification</b>"]-->|extends|CompositeSpec
        CompositeSpec-->|uses|AndSpec
        CompositeSpec-->|uses|OrSpec
        CompositeSpec-->|uses|NotSpec
        CompositeSpec-->|implements|Specification["<b>Specification</b><br/><br/><i>isSatisfiedBy(Object) : boolean</i>"]
</div>

## Generic

[Wikipedia](https://en.wikipedia.org/wiki/Specification_pattern#C#_6.0_with_generics) describes next step - generic *Specifications* with strongly typed *candidate*.

```chsarp
public interface ISpecification<T>
{
    bool IsSatisfiedBy(T candidate);
    ISpecification<T> And(ISpecification<T> other);
    ISpecification<T> AndNot(ISpecification<T> other);
    ISpecification<T> Or(ISpecification<T> other);
    ISpecification<T> OrNot(ISpecification<T> other);
    ISpecification<T> Not();
}
```

# FluentSpecification

*FluentSpecification* based on *Specification pattern* described in book *Domain-Driven Design* of *Eric Evans*.  
*Specifications* are generic for strongly typed candidates.  
Ofcourse, described above patterns are not implemented one-to-one. About *FluentSpecification* and how to use it you can read in next chapters.

## Validation

In addition, to the usual *candidate* verification, *FluentSpecification* prepared special *Validation* scenarios with result object, described in next chapters.  
Special result contains error messages, information about executed *Specifications* etc.

## Querying

To handle *querying* functionalities, *FluentSpecification* use *Linq expressions* - expressions building and usage is described in next chapters of this documentation.