using Nuke.Common;
using Nuke.Common.Tooling;

class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main() => Execute<Build>(x => x.CheckTestCases);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [NuGetPackage("bcf-tool.CommandLine", "tools/net5.0/bcf-tool.dll")] Tool BcfTool;

    Target CheckTestCases => _ => _
        .Executes(() =>
        {
            var bcfCheckToolPath = NuGetToolPathResolver.GetPackageExecutable("bcf-tool.CommandLine", "tools/net5.0/bcf-tool.dll");
            BcfTool($"check -q -r v4.0 \"{RootDirectory}\"", workingDirectory: System.IO.Path.GetDirectoryName(bcfCheckToolPath));
        });
}
