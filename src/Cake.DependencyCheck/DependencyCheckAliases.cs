using System;
using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.DependencyCheck
{
    [CakeAliasCategory("DependencyCheck")]
    public static class DependencyCheckAliases
    {
        [CakeMethodAlias]
        public static void DependencyCheck(this ICakeContext context, DependencyCheckSettings settings)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            var runner = new DependencyCheckRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
            runner.RunDependencyCheck(settings);
        }
    }
}
