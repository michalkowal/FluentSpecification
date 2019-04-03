<div class="mermaid">
graph TD;
Analyze-->DupFinder;
Analyze-->InspectCode;
Analyze-->CreateIssuesReport;
CreateIssuesReport-->DotNetCore-Build;
DotNetCore-Build-->Clean;
DotNetCore-Build-->DotNetCore-Restore;
Clean-->Show-Info;
Clean-->Print-AppVeyor-Environment-Variables;
</div>
