using System;
using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.DependencyCheck
{
    public class DependencyCheckRunner : Tool<DependencyCheckSettings>
    {
        private readonly IFileSystem _fileSystem;
        private readonly ICakeEnvironment _environment;
        private readonly IProcessRunner _processRunner;
        private readonly IToolLocator _tools;

        public DependencyCheckRunner(
            IFileSystem fileSystem,
            ICakeEnvironment environment,
            IProcessRunner processRunner,
            IToolLocator tools)
            : base(fileSystem, environment, processRunner, tools)
        {
            _fileSystem = fileSystem;
            _environment = environment;
            _processRunner = processRunner;
            _tools = tools;
        }

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

        protected override string GetToolName()
        {
            return "DependencyCheck";
        }

        protected internal void RunDependencyCheck(DependencyCheckSettings settings)
        {
            var arguments = new ProcessArgumentBuilder();

            settings.AppendArguments(settings, arguments);

            Run(settings, arguments);
        }
    }
}
