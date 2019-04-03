<div class="mermaid">
graph TD;
Create-Chocolatey-Packages-->Clean;
Create-Chocolatey-Packages-->DotNetCore-Build;
DotNetCore-Build-->DotNetCore-Restore;
DotNetCore-Build-->Restore;
Clean-->Show-Info;
Clean-->Print-AppVeyor-Environment-Variables;
</div>
