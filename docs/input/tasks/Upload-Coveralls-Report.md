<div class="mermaid">
graph TD;
Upload-Coveralls-Report-->Test;
Test-->DotNetCore-Build;
Test-->DotNetCore-Test;
DotNetCore-Test-->Install-OpenCover;
Install-OpenCover-->Install-ReportGenerator;
DotNetCore-Build-->Clean;
DotNetCore-Build-->DotNetCore-Restore;
Clean-->Show-Info;
Clean-->Print-AppVeyor-Environment-Variables;
</div>
