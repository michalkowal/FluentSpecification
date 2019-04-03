<div class="mermaid">
graph TD;
Upload-Coverage-Report-->Upload-Coveralls-Report;
Upload-Coverage-Report-->Upload-Codecov-Report;
Upload-Codecov-Report-->Test;
Test-->DotNetCore-Build;
Test-->DotNetCore-Test;
DotNetCore-Test-->Install-OpenCover;
Install-OpenCover-->Install-ReportGenerator;
DotNetCore-Build-->Clean;
DotNetCore-Build-->DotNetCore-Restore;
Clean-->Show-Info;
Clean-->Print-AppVeyor-Environment-Variables;
</div>
