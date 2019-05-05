Description: <i>Entity Framework</i> support description.
Order: 600
---

One of the main goal of *FluentSpecification* is *Linq expressions* support. *FluentSpecification* concentrates on well known ORM - `Entity Framework`.

# EF Core

`EF Core` is fully redesigned relative to `EF 6`. Framework, first of all try to convert whatever he can to SQL, 
then executes query and at the end in memory executes non-convertible parts of expression.  
Thanks to that, many of ideas, not available so far, can be realized on `EF Core` solution. 
All built-in *Specifications* works without problems with `EF Core`. Because, there is no possibility to test all cases, 
some of *Specifications* may not work as expected in some exceptional conditions.  
Good to remember - `EF Core` is still under development and do not cover all `EF 6` functionalities right now.

# EF 6

`EF 6` is mature ORM solution, with many tutorials and big community. Many of *FluentSpecification* ideas is not working correctly with `EF 6` (or works partially), 
because of used components or by accepted architecture. It's because whole expression is converted to proper SQL queries, so only primitives and entities types can be used and also built-in SQL functions.  
In [Built-in Specifications](/FluentSpecification/built-in/) section, every *Specification* contains proper addnotation about `Entity Framework' support 
and restrictions or tips.

## LinqToEntities flag

Few *Specifications* to meet special *LinqToEntities* requirements, provides special behavior for that. This state can be force in constructors or globally - 
by `Specification.LinqToEntities` flag.  

For more information - visit [Usage section](/FluentSpecification/docs/usage/candidate-verification#linqtoentities).