#tool nuget:?package=Newtonsoft.Json&version=12.0.3

#load nuget:?package=Cake.Recipe&version=3.0.1
#load signing.cake

Environment.SetVariableNames();

DirectoryPath source = "./src";
string owner = "michalkowal";
string title = "FluentSpecification";
string wyamSourceFiles = $"../../{source.FullPath}/**/{{!bin,!obj,!packages,!*.Tests*,}}/**/{{!Annotations,*}}.cs";

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            sourceDirectoryPath: source,
                            title: title,
                            repositoryOwner: owner,
                            repositoryName: title,
							appVeyorAccountName: owner,
							webBaseEditUrl: $"https://github.com/{owner}/{title}/tree/master/docs/input/",
							wyamSourceFiles: wyamSourceFiles,

							shouldCalculateVersion: true,
							shouldRunDotNetCorePack: true,
							shouldPublishGitHub: true,
							shouldGenerateDocumentation: true);

BuildParameters.PrintParameters(Context);

var absoluteSourceDirectory = Context.MakeAbsolute(source);
ToolSettings.SetToolSettings(context: Context,
		testCoverageFilter:
			$"+[{title}*]* -[*.Tests*]* -[*]JetBrains.*");
			
ToolSettings.SetToolPreprocessorDirectives(
    reSharperTools: "#tool nuget:?package=JetBrains.ReSharper.CommandLineTools&version=2019.2.1");
			
// Disable standard build
BuildParameters.Tasks.DotNetCoreRestoreTask
	.WithCriteria(false);
BuildParameters.Tasks.DotNetCoreBuildTask
    .WithCriteria(false);

BuildParameters.IsDotNetCoreBuild = true;
BuildParameters.IsNuGetBuild = false;

// Enable modified .NET Core build with signing
BuildParameters.Tasks.CreateNuGetPackagesTask.IsDependentOn("DotNetCore-Signing-Build");
BuildParameters.Tasks.CreateChocolateyPackagesTask.IsDependentOn("DotNetCore-Signing-Build");
BuildParameters.Tasks.TestTask.IsDependentOn("DotNetCore-Signing-Build");
BuildParameters.Tasks.InspectCodeTask.IsDependentOn("DotNetCore-Signing-Build");
BuildParameters.Tasks.PackageTask.IsDependentOn("Analyze");
BuildParameters.Tasks.PackageTask.IsDependentOn("Test");
BuildParameters.Tasks.PackageTask.IsDependentOn("Create-NuGet-Packages");
BuildParameters.Tasks.PackageTask.IsDependentOn("Create-Chocolatey-Packages");
BuildParameters.Tasks.UploadCodecovReportTask.IsDependentOn("Test");
BuildParameters.Tasks.UploadCoverallsReportTask.IsDependentOn("Test");
BuildParameters.Tasks.ContinuousIntegrationTask.IsDependentOn("Upload-Coverage-Report");

BuildParameters.Tasks.GenerateLocalCoverageReportTask.IsDependentOn("DotNetCore-Test");
BuildParameters.Tasks.TestTask.IsDependentOn("Generate-LocalCoverageReport");
BuildParameters.Tasks.PackageTask.IsDependentOn("DotNetCore-Pack");

RunTarget(BuildParameters.Target);
