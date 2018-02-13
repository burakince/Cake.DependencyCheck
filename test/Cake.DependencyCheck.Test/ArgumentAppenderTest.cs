using Xunit;
using Cake.Core.IO;

namespace Cake.DependencyCheck.Test
{
    public class ArgumentAppenderTest
    {
        [Fact]
        public void WhenHasArgumentShouldAddValueWithAttributeName()
        {
            var settings = new DependencyCheckSettings();
            settings.Project = "TestProject";

            var arguments = new ProcessArgumentBuilder();

            var appender = new ArgumentAppender();
            appender.AppendArguments(settings, arguments);

            Assert.Equal("--project \"TestProject\"", arguments.Render());
        }

        [Fact]
        public void WhenHasFlagShouldAddAttributeName()
        {
            var settings = new DependencyCheckSettings();
            settings.Help = true;

            var arguments = new ProcessArgumentBuilder();

            var appender = new ArgumentAppender();
            appender.AppendArguments(settings, arguments);

            Assert.Equal("--help", arguments.Render());
        }
    }
}
