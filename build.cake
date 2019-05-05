#load nuget:https://www.myget.org/F/cake-contrib/api/v2?package=Cake.Recipe&prerelease

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
			
BuildParameters.Tasks.DotNetCoreRestoreTask
	.WithCriteria(false);
BuildParameters.Tasks.DotNetCoreBuildTask
    .IsDependentOn("Restore");

Build.RunDotNetCore();
