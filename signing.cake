#tool nuget:?package=secure-file&version=1.0.31

string secret = EnvironmentVariable("SIGN_SECRET");
FilePath encryptedKey = MakeAbsolute(new FilePath("./src/FluentSpecification.snk.enc"));
FilePath decryptedKey = MakeAbsolute(new FilePath("./src/FluentSpecification.snk"));

Task("Decrypt-Key")
	.WithCriteria(() => !string.IsNullOrEmpty(secret))
	.WithCriteria(() => FileExists(encryptedKey))
	.Does(() =>
	{
		FilePath path = Context.Tools.Resolve("secure-file.exe");
		StartProcess(path, new ProcessSettings {
			Arguments = new ProcessArgumentBuilder()
				.Append("-decrypt")
				.AppendQuoted(encryptedKey.ToString())
				.Append("-secret")
				.Append(secret)
			});
			
		if (!FileExists(decryptedKey))
		{
			throw new Exception("Cannot decrypt signing key file");
		}
	});
	
Task("DotNetCore-Signing-Build")
	.IsDependentOn("Clean")
	.IsDependentOn("Restore")
	.IsDependentOn("Decrypt-Key")
    .Does(() => {
        Information("Building {0}", BuildParameters.SolutionFilePath);

        var msBuildSettings = new DotNetCoreMSBuildSettings()
                            .WithProperty("Version", BuildParameters.Version.SemVersion)
                            .WithProperty("AssemblyVersion", BuildParameters.Version.Version)
                            .WithProperty("FileVersion",  BuildParameters.Version.Version)
                            .WithProperty("AssemblyInformationalVersion", BuildParameters.Version.InformationalVersion);

        if(!IsRunningOnWindows())
        {
            var frameworkPathOverride = new FilePath(typeof(object).Assembly.Location).GetDirectory().FullPath + "/";

            // Use FrameworkPathOverride when not running on Windows.
            Information("Build will use FrameworkPathOverride={0} since not building on Windows.", frameworkPathOverride);
            msBuildSettings.WithProperty("FrameworkPathOverride", frameworkPathOverride);
        }
		
		if (FileExists(decryptedKey))
		{
			Information("Signing with key {0}", decryptedKey);
			msBuildSettings.WithProperty("AssemblyOriginatorKeyFile", decryptedKey.FullPath);
		}
		else
		{
			Warning("Signing key not found");
		}

        DotNetCoreBuild(BuildParameters.SolutionFilePath.FullPath, new DotNetCoreBuildSettings
        {
            Configuration = BuildParameters.Configuration,
            MSBuildSettings = msBuildSettings
        });

        if(BuildParameters.ShouldExecuteGitLink)
        {
            ExecuteGitLink();
        }

        CopyBuildOutput();
    });

Teardown(context =>
{
    if (FileExists(decryptedKey))
	{
		Information("Deleting snk file...");
		DeleteFile(decryptedKey.FullPath);
	}
});
	
BuildParameters.Tasks.DotNetCorePackTask
	.IsDependentOn("DotNetCore-Signing-Build");