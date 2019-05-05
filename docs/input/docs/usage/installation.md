Description: Where <i>FluentSpecification</i> can be found and how to install it.
Order: 100
---

*FluentSpecification* is available via *NuGet*.  

<div class="mermaid">
	graph TD
		subgraph NuGet
			FluentSpecification
			subgraph 
				FluentSpecification.Core
				subgraph 
					FluentSpecification.Abstractions
				end
			end
		end
</div>

Main package is `FluentSpecification` and contains `FluentSpecification.Core` and `FluentSpecification.Abstractions`.  
If needed, *Core* and *Abstractions* can be install separately, also by *NuGet*.  
More information about packages content can be found in [Concept section](/FluentSpecification/docs/concept).

# .NET Core

```
dotnet add package FluentSpecification
```

# NuGet

```
nuget install FluentSpecification
```

## Package Manager (Visual Studio)

```
Install-Package FluentSpecification
```

# Local reference

Latest NuGet packages, can be downloaded also from [GitHub releases](https://github.com/michalkowal/FluentSpecification/releases/latest) page.  
NuGet package is normal *ZIP* package and contains all binaries for `.NET Core` and `.NET Framework`.  
These binaries can be referenced directly in your project.