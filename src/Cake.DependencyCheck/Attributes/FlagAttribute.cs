using System;

namespace Cake.DependencyCheck.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ArgumentAttribute : Attribute
    {
        public string Name { get; set; }

        public ArgumentAttribute(string name)
        {
            Name = name;
        }
    }
}
