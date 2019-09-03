#load nuget:?package=Cake.Recipe&version=1.0.0
#load signing.cake
#load analyzing.cake

Environment.SetVariableNames();

DirectoryPath source = "./src";
string owner = "michalkowal";
string title = "FluentSpecification";
string wyamSourceFiles = $"../../{source.FullPath}/**/{{!bin,!obj,!packages,!*.Tests*,}}/**/{{!Annotations,*}}.cs";

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            sourceDirectoryPath: source,
							solutionDirectoryPath: source,
                            title: title,
                            repositoryOwner: owner,
                            repositoryName: title,
							appVeyorAccountName: owner,
							webBaseEditUrl: $"https://github.com/{owner}/{title}/tree/master/docs/input/",
							wyamSourceFiles: wyamSourceFiles,
							shouldDeployGraphDocumentation: false,
							
                            shouldRunGitVersion: true,
							shouldRunDotNetCorePack: true,
							shouldExecuteGitLink: true,
							shouldPublishMyGet: true,
							shouldPublishChocolatey: true,
							shouldPublishNuGet: true,
							shouldPublishGitHub: true,
							shouldGenerateDocumentation: true);

BuildParameters.PrintParameters(Context);

var absoluteSourceDirectory = Context.MakeAbsolute(source);
ToolSettings.SetToolSettings(context: Context,
		dupFinderExcludePattern:
            new string[]
            {
                $"{absoluteSourceDirectory}/{title}.*Tests*/**/*.cs",
                $"{absoluteSourceDirectory}/**/Annotations.cs"
            },
		testCoverageFilter:
			$"+[{title}*]* -[*.Tests*]* -[*]JetBrains.*");
			
// Disable standard build
BuildParameters.Tasks.DotNetCoreRestoreTask
	.WithCriteria(false);
BuildParameters.Tasks.DotNetCoreBuildTask
    .WithCriteria(false);

BuildParameters.IsDotNetCoreBuild = true;
BuildParameters.IsNuGetBuild = false;

// Enable modified .NET Core build with signing
// Disable standard analyze
// Enable newest ReSharper analyze
BuildParameters.Tasks.CreateNuGetPackagesTask.IsDependentOn("DotNetCore-Signing-Build");
BuildParameters.Tasks.CreateChocolateyPackagesTask.IsDependentOn("DotNetCore-Signing-Build");
BuildParameters.Tasks.TestTask.IsDependentOn("DotNetCore-Signing-Build");
BuildParameters.Tasks.PackageTask.IsDependentOn("ReSharper-Analyze");
BuildParameters.Tasks.PackageTask.IsDependentOn("Test");
BuildParameters.Tasks.PackageTask.IsDependentOn("Create-NuGet-Packages");
BuildParameters.Tasks.PackageTask.IsDependentOn("Create-Chocolatey-Packages");
BuildParameters.Tasks.UploadCodecovReportTask.IsDependentOn("Test");
BuildParameters.Tasks.UploadCoverallsReportTask.IsDependentOn("Test");
BuildParameters.Tasks.AppVeyorTask.IsDependentOn("Upload-Coverage-Report");
BuildParameters.Tasks.AppVeyorTask.IsDependentOn("Publish-Chocolatey-Packages");
BuildParameters.Tasks.InstallReportGeneratorTask.IsDependentOn("DotNetCore-Signing-Build");

BuildParameters.Tasks.TestTask.IsDependentOn("DotNetCore-Test");
BuildParameters.Tasks.InstallOpenCoverTask.IsDependentOn("Install-ReportGenerator");
BuildParameters.Tasks.PackageTask.IsDependentOn("DotNetCore-Pack");

RunTarget(BuildParameters.Target);
