using System;

namespace Cake.DependencyCheck
{
    /// <summary>
    /// Argument attribute class
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ArgumentAttribute : Attribute
    {
        /// <summary>
        /// Argument name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Argument has value flag
        /// </summary>
        public bool HasValue { get; set; }

        /// <summary>
        /// Argument Attribute
        /// </summary>
        /// <param name="name">A required argument name.</param>
        /// <param name="hasValue">A optional has value flag.</param>
        public ArgumentAttribute(string name, bool hasValue = true)
        {
            Name = name;
            HasValue = hasValue;
        }
    }
}
