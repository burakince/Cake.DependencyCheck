using System;
using System.Collections;
using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.DependencyCheck.Attributes;
using System.Linq;
using System.Reflection;
using Cake.Core.Tooling;

namespace Cake.DependencyCheck
{
    public class DependencyCheckSettings : ToolSettings
    {
        [Argument("--project")]
        public string Project { get; set; }

        [Argument("--scan")]
        public string Scan { get; set; }

        [Argument("--exclude")]
        public string Exclude { get; set; }

        [Argument("--symLink")]
        public string SymLink { get; set; }

        [Argument("--out")]
        public string Out { get; set; }

        [Argument("--format")]
        public string Format { get; set; }

        [Argument("--failOnCVSS")]
        public string FailOnCVSS { get; set; }

        [Argument("--log")]
        public string Log { get; set; }

        [Flag("--noupdate")]
        public bool Noupdate { get; set; }

        [Argument("--suppression")]
        public string Suppression { get; set; }

        [Flag("--help")]
        public bool Help { get; set; }

        [Flag("--advancedHelp")]
        public bool AdvancedHelp { get; set; }

        [Flag("--version")]
        public bool Version { get; set; }

        [Argument("--cveValidForHours")]
        public string CveValidForHours { get; set; }

        [Flag("--enableExperimental")]
        public bool EnableExperimental { get; set; }

        [Flag("--enableRetired")]
        public bool EnableRetired { get; set; }

        public void AppendArguments(DependencyCheckSettings settings, ProcessArgumentBuilder arguments)
        {
            foreach (var property in settings.GetType().GetProperties())
            {
                AppendArgument(settings, arguments, property);
                AppendFlag(settings, arguments, property);
            }

            if (settings.ArgumentCustomization != null)
            {
                arguments = settings.ArgumentCustomization(arguments);
                settings.ArgumentCustomization = null;
            }
        }

        private void AppendArgument(DependencyCheckSettings settings, ProcessArgumentBuilder arguments, PropertyInfo property)
        {
            var attr = property.GetCustomAttributes<ArgumentAttribute>().FirstOrDefault();
            if (attr == null)
            {
                return;
            }

            var value = property.GetValue(settings);
            if (value == null)
            {
                return;
            }

            var stringValue = value.ToString();
            if (!string.IsNullOrEmpty(stringValue))
            {
                arguments.Append(string.Format("{0} \"{1}\"", attr.Name, stringValue));
            }
        }

        private void AppendFlag(DependencyCheckSettings settings, ProcessArgumentBuilder arguments, PropertyInfo property)
        {
            var attr = property.GetCustomAttributes<FlagAttribute>().FirstOrDefault();
            if (attr == null)
            {
                return;
            }

            var value = property.GetValue(settings);
            if (value == null)
            {
                return;
            }

            var booleanValue = Convert.ToBoolean(value);
            if (booleanValue)
            {
                arguments.Append(string.Format("{0}", attr.Name));
            }
        }
    }
}
