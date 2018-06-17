using System;
using System.Collections.Generic;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents available sizes
    /// </summary>
    public sealed class YimaBootstrapSize : BootstrapSizeBase
    {
        /// <summary>
        /// Extra large size
        /// </summary>
        public static readonly YimaBootstrapSize ExtraLarge = new YimaBootstrapSize("xlg");

        /// <summary>
        /// Extra large size
        /// </summary>
        public static readonly YimaBootstrapSize Large = new YimaBootstrapSize("lg");

        /// <summary>
        /// Default size
        /// </summary>
        public static readonly YimaBootstrapSize Default = new YimaBootstrapSize("");

        /// <summary>
        /// Small size
        /// </summary>
        public static readonly YimaBootstrapSize Small = new YimaBootstrapSize("sm");
        
        /// <summary>
        /// Extra small size
        /// </summary>
        public static readonly YimaBootstrapSize ExtraSmall = new YimaBootstrapSize("xs");

        /// <summary>
        /// Extra extra small size
        /// </summary>
        public static readonly YimaBootstrapSize ExtraExtraSmall = new YimaBootstrapSize("xxs");

        private YimaBootstrapSize(string name) : base(name)
        {
        }

        /// <summary>
        /// Returns all available sizes.
        /// </summary>
        /// <returns>All available sizes.</returns>
        public override IEnumerable<BootstrapSizeBase> GetAll()
        {
            yield return ExtraLarge;
            yield return Large;
            yield return Default;
            yield return Small;
            yield return ExtraSmall;
            yield return ExtraExtraSmall;
        }
    }
}
