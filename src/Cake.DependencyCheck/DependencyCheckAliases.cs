using System;
using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.DependencyCheck
{
    /// <summary>
    /// <para>
    /// Contains functionality for running a OWASP Dependency Check analysis on a C# project.
    /// </para>
    /// <para>
    /// In order to use the commands for this addin, include the following in your build.cake file to download and
    /// reference from NuGet.org:
    /// <code>
    ///     #tool "nuget:?package=DependencyCheck.Runner.Tool&amp;include=./**/dependency-check.sh&amp;include=./**/dependency-check.bat"
    ///     #addin "nuget:?package=Cake.DependencyCheck"
    /// </code>
    /// </para>
    /// </summary>
    /// <example>
    /// Project and Scan attributes required.
    /// Also Format can be (XML, HTML, CSV, JSON, VULN, ALL). The default is HTML.
    /// 
    /// <code>
    /// #tool "nuget:?package=DependencyCheck.Runner.Tool&amp;include=./**/dependency-check.sh&amp;include=./**/dependency-check.bat"
    /// #addin "nuget:?package=Cake.DependencyCheck"
    /// 
    /// Task("Dependency-Check")
    ///    .Does(() => {
    ///       DependencyCheck(new DependencyCheckSettings
    ///       {
    ///          Project = "ExampleProjectName",
    ///          Scan = "source/directory/*",
    ///          Format = "HTML"
    ///       });
    ///   });
    /// </code>
    /// </example>
    [CakeAliasCategory("DependencyCheck")]
    public static class DependencyCheckAliases
    {
        /// <summary>
        /// Run the actual OWASP Dependency Check analysis.
        /// </summary>
        /// <example>
        /// <code>
        /// Task("Dependency-Check")
        ///    .Does(() => {
        ///       DependencyCheck(project: "ExampleProjectName", scan: "source/directory/*");
        ///   });
        /// </code>
        /// </example>
        /// <param name="context"></param>
        /// <param name="project">A required project name.</param>
        /// <param name="scan">A required scan path.</param>
        [CakeMethodAlias]
        public static void DependencyCheck(this ICakeContext context, string project, string scan)
        {
            if (string.IsNullOrEmpty(project))
            {
                throw new ArgumentNullException(nameof(project));
            }
            if (string.IsNullOrEmpty(scan))
            {
                throw new ArgumentNullException(nameof(scan));
            }

            DependencyCheck(context, settings: new DependencyCheckSettings(project, scan));
        }

        /// <summary>
        /// Run the actual OWASP Dependency Check analysis.
        /// </summary>
        /// <example>
        /// <code>
        /// Task("Dependency-Check")
        ///    .Does(() => {
        ///       DependencyCheck(new DependencyCheckSettings
        ///       {
        ///          Project = "ExampleProjectName",
        ///          Scan = "source/directory/*",
        ///          Format = "HTML"
        ///       });
        ///   });
        /// </code>
        /// </example>
        /// <param name="context"></param>
        /// <param name="settings">A required settings object.</param>
        [CakeMethodAlias]
        public static void DependencyCheck(this ICakeContext context, DependencyCheckSettings settings)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            var runner = new DependencyCheckRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
            runner.RunDependencyCheck(settings);
        }
    }
}
