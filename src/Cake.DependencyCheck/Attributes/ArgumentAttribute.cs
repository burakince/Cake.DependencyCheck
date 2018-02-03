using System;

namespace Cake.DependencyCheck.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FlagAttribute : Attribute
    {
        public string Name { get; set; }

        public FlagAttribute(string name)
        {
            Name = name;
        }
    }
}
