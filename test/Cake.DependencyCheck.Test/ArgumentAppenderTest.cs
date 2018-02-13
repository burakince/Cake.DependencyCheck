using Xunit;
using Cake.Core.IO;

namespace Cake.DependencyCheck.Test
{
    public class ArgumentAppenderTest
    {
        [Fact]
        public void WhenHasArgumentShouldAddAttributeNameWithValue()
        {
            var settings = new DependencyCheckSettings
            {
                Project = "TestProject"
            };
            var arguments = new ProcessArgumentBuilder();

            var appender = new ArgumentAppender();
            appender.AppendArguments(settings, arguments);

            Assert.Equal("--project \"TestProject\"", arguments.Render());
        }

        [Fact]
        public void WhenHasArgumentWithoutValueShouldAddAttributeName()
        {
            var settings = new DependencyCheckSettings
            {
                Help = true
            };
            var arguments = new ProcessArgumentBuilder();

            var appender = new ArgumentAppender();
            appender.AppendArguments(settings, arguments);

            Assert.Equal("--help", arguments.Render());
        }

        [Fact]
        public void WhenHasNotArgumentShouldBlank()
        {
            var settings = new DependencyCheckSettings();
            var arguments = new ProcessArgumentBuilder();

            var appender = new ArgumentAppender();
            appender.AppendArguments(settings, arguments);

            Assert.Equal("", arguments.Render());
        }
    }
}
