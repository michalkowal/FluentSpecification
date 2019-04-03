<div class="mermaid">
graph TD;
Create-NuGet-Packages-->Clean;
Create-NuGet-Packages-->DotNetCore-Build;
DotNetCore-Build-->DotNetCore-Restore;
Clean-->Show-Info;
Clean-->Print-AppVeyor-Environment-Variables;
</div>
