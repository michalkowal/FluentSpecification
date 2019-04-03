<div class="mermaid">
graph TD;
Install-OpenCover-->Install-ReportGenerator;
Install-ReportGenerator-->DotNetCore-Build;
DotNetCore-Build-->Clean;
DotNetCore-Build-->DotNetCore-Restore;
DotNetCore-Build-->Restore;
Clean-->Show-Info;
Clean-->Print-AppVeyor-Environment-Variables;
</div>
