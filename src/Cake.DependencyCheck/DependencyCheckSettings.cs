using Cake.DependencyCheck.Attributes;
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
        [Flag("--noupdate")]
        public bool Noupdate { get; set; }

        /// <summary>
        /// The file paths to the suppression XML files; used to suppress false positives. This can be specified more than once to utilize multiple suppression files.
        /// </summary>
        [Argument("--suppression")]
        public string Suppression { get; set; }

        /// <summary>
        /// Print the help message.
        /// </summary>
        [Flag("--help")]
        public bool Help { get; set; }

        /// <summary>
        /// Print the advanced help message.
        /// </summary>
        [Flag("--advancedHelp")]
        public bool AdvancedHelp { get; set; }

        /// <summary>
        /// Print the runner version information.
        /// </summary>
        [Flag("--version")]
        public bool Version { get; set; }

        /// <summary>
        /// The number of hours to wait before checking for new updates from the NVD. The default is 4 hours.
        /// </summary>
        [Argument("--cveValidForHours")]
        public string CveValidForHours { get; set; }

        /// <summary>
        /// Enable the experimental analyzers. If not set the analyzers marked as experimental below will not be loaded or used.
        /// </summary>
        [Flag("--enableExperimental")]
        public bool EnableExperimental { get; set; }

        /// <summary>
        /// Enable the retired analyzers. If not set the analyzers marked as retired below will not be loaded or used.
        /// </summary>
        [Flag("--enableRetired")]
        public bool EnableRetired { get; set; }        
    }
}
