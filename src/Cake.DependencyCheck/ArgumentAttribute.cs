using System;

namespace Cake.DependencyCheck
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ArgumentAttribute : Attribute
    {
        public string Name { get; set; }

        public bool HasValue { get; set; }

        public ArgumentAttribute(string name, bool hasValue = true)
        {
            Name = name;
            HasValue = hasValue;
        }
    }
}
