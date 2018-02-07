using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.DependencyCheck.Attributes;
using System.Linq;
using System.Reflection;

namespace Cake.DependencyCheck
{
    public class ArgumentAppender
    {
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