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
    .Does<BuildVersion>((context, buildVersion) => {
        Information("Building {0}", BuildParameters.SolutionFilePath);

        // We need to clone the settings class, so we don't
        // add additional properties to every other task.
        var msBuildSettings = new DotNetCoreMSBuildSettings();
        foreach (var kv in context.Data.Get<DotNetCoreMSBuildSettings>().Properties)
        {
            string value = string.Join(" ", kv.Value);
            msBuildSettings.WithProperty(kv.Key, value);
        }
        msBuildSettings.WithLogger("BinaryLogger," + context.Tools.Resolve("Cake.Issues.MsBuild*/**/StructuredLogger.dll"),
            "",
            BuildParameters.Paths.Files.BuildBinLogFilePath.ToString());
		
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
            MSBuildSettings = msBuildSettings,
            NoRestore = true
        });

		// We set this here, so we won't have a failure in case this task is never called
        IssuesParameters.InputFiles.AddMsBuildBinaryLogFile(BuildParameters.Paths.Files.BuildBinLogFilePath);

        CopyBuildOutput(buildVersion);
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