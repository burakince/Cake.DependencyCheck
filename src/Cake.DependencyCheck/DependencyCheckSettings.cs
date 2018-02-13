using Cake.Core.Tooling;

namespace Cake.DependencyCheck
{
    /// <summary>
    /// Required:
    ///  - Project
    ///  - Scan
    /// </summary>
    public class DependencyCheckSettings : ToolSettings
    {
        public DependencyCheckSettings()
        {
        }

        public DependencyCheckSettings(string project, string scan)
        {
            Project = project;
            Scan = scan;
        }

        /// <summary>
        /// The name of the project being scanned.
        /// </summary>
        [Argument("--project")]
        public string Project { get; set; }

        /// <summary>
        /// The path to scan - this option can be specified multiple times. It is also possible to specify Ant style paths (e.g. directory/*/.jar).
        /// </summary>
        [Argument("--scan")]
        public string Scan { get; set; }

        /// <summary>
        /// The path patterns to exclude from the scan - this option can be specified multiple times. This accepts Ant style path patterns (e.g. /exclude/).
        /// </summary>
        [Argument("--exclude")]
        public string Exclude { get; set; }

        /// <summary>
        /// The depth that symbolic links will be followed; the default is 0 meaning symbolic links will not be followed.
        /// </summary>
        [Argument("--symLink")]
        public string SymLink { get; set; }

        /// <summary>
        /// The folder to write reports to. This defaults to the current directory. If the format is not set to ALL one could specify a specific file name.
        /// </summary>
        [Argument("--out")]
        public string Out { get; set; }

        /// <summary>
        /// The output format to write to (XML, HTML, CSV, JSON, VULN, ALL). The default is HTML.
        /// </summary>
        [Argument("--format")]
        public string Format { get; set; }

        /// <summary>
        /// If the score set between 0 and 10 the exit code from dependency-check will indicate if a vulnerability with a CVSS score equal to or higher was identified.
        /// </summary>
        [Argument("--failOnCVSS")]
        public string FailOnCVSS { get; set; }

        /// <summary>
        /// The file path to write verbose logging information.
        /// </summary>
        [Argument("--log")]
        public string Log { get; set; }

        /// <summary>
        /// Disables the automatic updating of the CPE data.
        /// </summary>
        [Argument("--noupdate", hasValue: false)]
        public bool Noupdate { get; set; }

        /// <summary>
        /// The file paths to the suppression XML files; used to suppress false positives. This can be specified more than once to utilize multiple suppression files.
        /// </summary>
        [Argument("--suppression")]
        public string Suppression { get; set; }

        /// <summary>
        /// Print the help message.
        /// </summary>
        [Argument("--help", hasValue: false)]
        public bool Help { get; set; }

        /// <summary>
        /// Print the advanced help message.
        /// </summary>
        [Argument("--advancedHelp", hasValue: false)]
        public bool AdvancedHelp { get; set; }

        /// <summary>
        /// Print the runner version information.
        /// </summary>
        [Argument("--version", hasValue: false)]
        public bool Version { get; set; }

        /// <summary>
        /// The number of hours to wait before checking for new updates from the NVD. The default is 4 hours.
        /// </summary>
        [Argument("--cveValidForHours")]
        public string CveValidForHours { get; set; }

        /// <summary>
        /// Enable the experimental analyzers. If not set the analyzers marked as experimental below will not be loaded or used.
        /// </summary>
        [Argument("--enableExperimental", hasValue: false)]
        public bool EnableExperimental { get; set; }

        /// <summary>
        /// Enable the retired analyzers. If not set the analyzers marked as retired below will not be loaded or used.
        /// </summary>
        [Argument("--enableRetired", hasValue: false)]
        public bool EnableRetired { get; set; }

        /// <summary>
        /// URL for the modified CVE 1.2
        /// </summary>
        [Argument("--cveUrl12Modified")]
        public string CveUrl12Modified { get; set; }

        /// <summary>
        /// URL for the modified CVE 2.0
        /// </summary>
        [Argument("--cveUrl20Modified")]
        public string CveUrl20Modified { get; set; }

        /// <summary>
        /// Base URL for each year’s CVE 1.2, the %d will be replaced with the year
        /// </summary>
        [Argument("--cveUrl12Base")]
        public string CveUrl12Base { get; set; }

        /// <summary>
        /// Base URL for each year’s CVE 2.0, the %d will be replaced with the year
        /// </summary>
        [Argument("--cveUrl20Base")]
        public string CveUrl20Base { get; set; }

        /// <summary>
        /// Specifies a file that contains properties to use instead of applicaion defaults.
        /// </summary>
        [Argument("--propertyfile")]
        public string Propertyfile { get; set; }

        /// <summary>
        /// If set only the update phase of dependency-check will be executed; no scan will be executed and no report will be generated.
        /// </summary>
        [Argument("--updateonly", hasValue: false)]
        public bool Updateonly { get; set; }

        /// <summary>
        /// Sets whether the experimental Python Distribution Analyzer will be used.
        /// </summary>
        [Argument("--disablePyDist", hasValue: false)]
        public bool DisablePyDist { get; set; }

        /// <summary>
        /// Sets whether the experimental Python Package Analyzer will be used.
        /// </summary>
        [Argument("--disablePyPkg", hasValue: false)]
        public bool DisablePyPkg { get; set; }

        /// <summary>
        /// Sets whether the retired Node.js Package Analyzer will be used.
        /// </summary>
        [Argument("--disableNodeJS", hasValue: false)]
        public bool DisableNodeJS { get; set; }

        /// <summary>
        /// Sets whether the NSP Analyzer will be used.
        /// </summary>
        [Argument("--disableNSP", hasValue: false)]
        public bool DisableNSP { get; set; }

        /// <summary>
        /// Sets whether the experimental Ruby Gemspec Analyzer will be used.
        /// </summary>
        [Argument("--disableRubygems", hasValue: false)]
        public bool DisableRubygems { get; set; }

        /// <summary>
        /// Sets whether the experimental Ruby Bundler Audit Analyzer will be used.
        /// </summary>
        [Argument("--disableBundleAudit", hasValue: false)]
        public bool DisableBundleAudit { get; set; }

        /// <summary>
        /// Sets whether the experimental Cocoapods Analyzer will be used.
        /// </summary>
        [Argument("--disableCocoapodsAnalyzer", hasValue: false)]
        public bool DisableCocoapodsAnalyzer { get; set; }

        /// <summary>
        /// Sets whether the experimental Swift Package Manager Analyzer will be used.
        /// </summary>
        [Argument("--disableSwiftPackageManagerAnalyzer", hasValue: false)]
        public bool DisableSwiftPackageManagerAnalyzer { get; set; }

        /// <summary>
        /// Sets whether the experimental Autoconf Analyzer will be used.
        /// </summary>
        [Argument("--disableAutoconf", hasValue: false)]
        public bool DisableAutoconf { get; set; }

        /// <summary>
        /// Sets whether the OpenSSL Analyzer will be used.
        /// </summary>
        [Argument("--disableOpenSSL", hasValue: false)]
        public bool DisableOpenSSL { get; set; }

        /// <summary>
        /// Sets whether the experimental Cmake Analyzer will be disabled.
        /// </summary>
        [Argument("--disableCmake", hasValue: false)]
        public bool DisableCmake { get; set; }

        /// <summary>
        /// Sets whether the Archive Analyzer will be disabled.
        /// </summary>
        [Argument("--disableArchive", hasValue: false)]
        public bool DisableArchive { get; set; }

        /// <summary>
        /// A comma-separated list of additional file extensions to be treated like a ZIP file, the contents will be extracted and analyzed.
        /// </summary>
        [Argument("--zipExtensions")]
        public string ZipExtensions { get; set; }

        /// <summary>
        /// Sets whether the Jar Analyzer will be disabled.
        /// </summary>
        [Argument("--disableJar", hasValue: false)]
        public bool DisableJar { get; set; }

        /// <summary>
        /// Sets whether the experimental PHP Composer Lock File Analyzer will be disabled.
        /// </summary>
        [Argument("--disableComposer", hasValue: false)]
        public bool DisableComposer { get; set; }

        /// <summary>
        /// Sets whether the Central Analyzer will be used. Disabling this analyzer is not recommended as it could lead to false negatives (e.g. libraries that have vulnerabilities may not be reported correctly). If this analyzer is being disabled there is a good chance you also want to disable the Nexus Analyzer.
        /// </summary>
        [Argument("--disableCentral", hasValue: false)]
        public bool DisableCentral { get; set; }

        /// <summary>
        /// Sets whether the Nexus Analyzer will be used (requires Nexus Pro). Note, this has been superceded by the Central Analyzer. However, you can configure the Nexus URL to utilize an internally hosted Nexus Pro server.
        /// </summary>
        [Argument("--disableNexus", hasValue: false)]
        public bool DisableNexus { get; set; }

        /// <summary>
        /// The url to the Nexus Server’s web service end point (example: http://domain.enterprise/nexus/service/local/). If not set the Nexus Analyzer will be disabled.
        /// </summary>
        [Argument("--nexus")]
        public string Nexus { get; set; }

        /// <summary>
        /// Whether or not the defined proxy should be used when connecting to Nexus.
        /// </summary>
        [Argument("--nexusUsesProxy")]
        public string NexusUsesProxy { get; set; }

        /// <summary>
        /// Sets whether or not the .NET Nuget Nuspec Analyzer will be used.
        /// </summary>
        [Argument("--disableNuspec", hasValue: false)]
        public bool DisableNuspec { get; set; }

        /// <summary>
        /// Sets whether or not the .NET Assembly Analyzer should be used.
        /// </summary>
        [Argument("--disableAssembly", hasValue: false)]
        public bool DisableAssembly { get; set; }

        /// <summary>
        /// The path to Mono for .NET Assembly analysis on non-windows systems.
        /// </summary>
        [Argument("--mono")]
        public string Mono { get; set; }

        /// <summary>
        /// The path to the bundle-audit executable.
        /// </summary>
        [Argument("--bundleAudit")]
        public string BundleAudit { get; set; }

        /// <summary>
        /// The proxy server to use when downloading resources; see the proxy configuration page for more information.
        /// </summary>
        [Argument("--proxyserver")]
        public string ProxyServer { get; set; }

        /// <summary>
        /// The proxy port to use when downloading resources.
        /// </summary>
        [Argument("--proxyport")]
        public string ProxyPort { get; set; }

        /// <summary>
        /// The connection timeout (in milliseconds) to use when downloading resources.
        /// </summary>
        [Argument("--connectiontimeout")]
        public string ConnectionTimeout { get; set; }

        /// <summary>
        /// The proxy password to use when downloading resources.
        /// </summary>
        [Argument("--proxypass")]
        public string ProxyPassword { get; set; }

        /// <summary>
        /// The proxy username to use when downloading resources.
        /// </summary>
        [Argument("--proxyuser")]
        public string ProxyUser { get; set; }

        /// <summary>
        /// The connection string to the database.
        /// </summary>
        [Argument("--connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// The database driver name.
        /// </summary>
        [Argument("--dbDriverName")]
        public string DatabaseDriverName { get; set; }

        /// <summary>
        /// The path to the database driver; note, this does not need to be set unless the JAR is outside of the class path.
        /// </summary>
        [Argument("--dbDriverPath")]
        public string DatabaseDriverPath { get; set; }

        /// <summary>
        /// The password for connecting to the database.
        /// </summary>
        [Argument("--dbPassword")]
        public string DatabasePassword { get; set; }

        /// <summary>
        /// The username used to connect to the database.
        /// </summary>
        [Argument("--dbUser")]
        public string DatabaseUser { get; set; }

        /// <summary>
        /// The location of the data directory used to store persistent data. This option should generally not be set.
        /// </summary>
        [Argument("--data")]
        public string Data { get; set; }

        /// <summary>
        /// Delete the local copy of the NVD. This is used to force a refresh of the data.
        /// </summary>
        [Argument("--purge", hasValue: false)]
        public bool Purge { get; set; }
    }
}
