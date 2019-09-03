///////////////////////////////////////////////////////////////////////////////
// TASK DEFINITIONS
///////////////////////////////////////////////////////////////////////////////
private const string ReSharper2019Tools = "#tool nuget:?package=JetBrains.ReSharper.CommandLineTools&version=2019.2.1";

Task("ReSharper-DupFinder")
	.IsDependentOn("DotNetCore-Signing-Build")
    .WithCriteria(() => BuildParameters.IsRunningOnWindows)
    .WithCriteria(() => BuildParameters.ShouldRunDupFinder)
    .Does(() => RequireTool(ReSharper2019Tools, () => {
        var settings = new DupFinderSettings() {
            ShowStats = true,
            ShowText = true,
            OutputFile = BuildParameters.Paths.Directories.DupFinderTestResults.CombineWithFilePath("dupfinder.xml"),
            ExcludeCodeRegionsByNameSubstring = new string [] { "DupFinder Exclusion" },
            ThrowExceptionOnFindingDuplicates = ToolSettings.DupFinderThrowExceptionOnFindingDuplicates ?? true
        };

        if(ToolSettings.DupFinderExcludePattern != null)
        {
            settings.ExcludePattern = ToolSettings.DupFinderExcludePattern;
        }

        if(ToolSettings.DupFinderExcludeFilesByStartingCommentSubstring != null)
        {
            settings.ExcludeFilesByStartingCommentSubstring = ToolSettings.DupFinderExcludeFilesByStartingCommentSubstring;
        }

        if(ToolSettings.DupFinderDiscardCost != null)
        {
            settings.DiscardCost = ToolSettings.DupFinderDiscardCost.Value;
        }

        DupFinder(BuildParameters.SolutionFilePath, settings);
    })
)
.ReportError(exception =>
{
    RequireTool(ReSharperReportsTool, () => {
        var outputHtmlFile = BuildParameters.Paths.Directories.DupFinderTestResults.CombineWithFilePath("dupfinder.html");

        Information("Duplicates were found in your codebase, creating HTML report...");
        ReSharperReports(
            BuildParameters.Paths.Directories.DupFinderTestResults.CombineWithFilePath("dupfinder.xml"),
            outputHtmlFile);

        if(BuildParameters.IsRunningOnAppVeyor && FileExists(outputHtmlFile))
        {
            AppVeyor.UploadArtifact(outputHtmlFile);
        }

        if(BuildParameters.IsLocalBuild)
        {
            LaunchDefaultProgram(outputHtmlFile);
        }
    });
});

Task("ReSharper-InspectCode")
	.IsDependentOn("DotNetCore-Signing-Build")
    .WithCriteria(() => BuildParameters.IsRunningOnWindows)
    .WithCriteria(() => BuildParameters.ShouldRunInspectCode)
    .Does<BuildData>(data => RequireTool(ReSharper2019Tools, () => {
        var inspectCodeLogFilePath = BuildParameters.Paths.Directories.InspectCodeTestResults.CombineWithFilePath("inspectcode.xml");

        var settings = new InspectCodeSettings() {
            SolutionWideAnalysis = true,
            OutputFile = inspectCodeLogFilePath
        };

        if(FileExists(BuildParameters.SourceDirectoryPath.CombineWithFilePath(BuildParameters.ResharperSettingsFileName)))
        {
            settings.Profile = BuildParameters.SourceDirectoryPath.CombineWithFilePath(BuildParameters.ResharperSettingsFileName);
        }

        InspectCode(BuildParameters.SolutionFilePath, settings);

        // Parse issues.
        var issues =
            ReadIssues(
                InspectCodeIssuesFromFilePath(inspectCodeLogFilePath),
                data.RepositoryRoot);
        Information("{0} InspectCode issues are found.", issues.Count());
        data.AddIssues(issues);
    })
);

Task("ReSharper-Analyze")
    .IsDependentOn("ReSharper-DupFinder")
    .IsDependentOn("ReSharper-InspectCode")
    .IsDependentOn("CreateIssuesReport");