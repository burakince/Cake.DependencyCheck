using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.DependencyCheck
{
    /// <summary>
    /// Dependency Check runner class.
    /// </summary>
    public class DependencyCheckRunner : Tool<DependencyCheckSettings>
    {
        private readonly IFileSystem _fileSystem;
        private readonly ICakeEnvironment _environment;
        private readonly IProcessRunner _processRunner;
        private readonly IToolLocator _tools;
        private readonly ArgumentAppender _appender;

        /// <summary>
        /// Dependency Check runner.
        /// </summary>
        /// <param name="fileSystem">A required file system object.</param>
        /// <param name="environment">A required cake environment object.</param>
        /// <param name="processRunner">A required process runner object.</param>
        /// <param name="tools">A required tool locator object.</param>
        public DependencyCheckRunner(
            IFileSystem fileSystem,
            ICakeEnvironment environment,
            IProcessRunner processRunner,
            IToolLocator tools)
            : this(fileSystem, environment, processRunner, tools, appender: new ArgumentAppender())
        {
        }

        /// <summary>
        /// Dependency Check runner.
        /// </summary>
        /// <param name="fileSystem">A required file system object.</param>
        /// <param name="environment">A required cake environment object.</param>
        /// <param name="processRunner">A required process runner object.</param>
        /// <param name="tools">A required tool locator object.</param>
        /// <param name="appender">A required argument appender object.</param>
        public DependencyCheckRunner(
            IFileSystem fileSystem,
            ICakeEnvironment environment,
            IProcessRunner processRunner,
            IToolLocator tools,
            ArgumentAppender appender)
            : base(fileSystem, environment, processRunner, tools)
        {
            _fileSystem = fileSystem;
            _environment = environment;
            _processRunner = processRunner;
            _tools = tools;
            _appender = appender;
        }

        /// <summary>
        /// Dependency Check executable names
        /// </summary>
        protected override IEnumerable<string> GetToolExecutableNames()
        {
            if (_environment.Platform.IsUnix())
            {
                return new[] { "dependency-check.sh", "dependency-check" };
            }
            else
            {
                return new[] { "dependency-check.bat", "dependency-check" };
            }
        }

        /// <summary>
        /// Tool name
        /// </summary>
        protected override string GetToolName()
        {
            return "DependencyCheck";
        }

        /// <summary>
        /// Runner method
        /// </summary>
        /// <param name="settings">A required settings object.</param>
        protected internal void RunDependencyCheck(DependencyCheckSettings settings)
        {
            var arguments = new ProcessArgumentBuilder();

            _appender.AppendArguments(settings, arguments);

            Run(settings, arguments);
        }
    }
}
