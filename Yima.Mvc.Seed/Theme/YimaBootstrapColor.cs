using System;
using System.Collections.Generic;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents available colors in current theme
    /// </summary>
    public sealed class YimaBootstrapColor : BootstrapColorBase
    {
        /// <summary>
        /// Default color
        /// </summary>
        public static readonly YimaBootstrapColor Default = new YimaBootstrapColor("default");

        /// <summary>
        /// Primary color
        /// </summary>
        public static readonly YimaBootstrapColor Primary = new YimaBootstrapColor("primary");

        /// <summary>
        /// Success color
        /// </summary>
        public static readonly YimaBootstrapColor Success = new YimaBootstrapColor("success");

        /// <summary>
        /// Info color
        /// </summary>
        public static readonly YimaBootstrapColor Info = new YimaBootstrapColor("info");

        /// <summary>
        /// Warning color
        /// </summary>
        public static readonly YimaBootstrapColor Warning = new YimaBootstrapColor("warning");

        /// <summary>
        /// Danger color
        /// </summary>
        public static readonly YimaBootstrapColor Danger = new YimaBootstrapColor("danger");

        /// <summary>
        /// Inverse color
        /// </summary>
        public static readonly YimaBootstrapColor Inverse = new YimaBootstrapColor("inverse");

        /// <summary>
        /// White color
        /// </summary>
        public static readonly YimaBootstrapColor White = new YimaBootstrapColor("white");

        /// <summary>
        /// Initializes a new instance of the component with the specified name.
        /// </summary>
        /// <param name="name">The HTML helper.</param>
        private YimaBootstrapColor(string name) : base(name)
        {
        }

        /// <summary>
        /// Returns all available colors.
        /// </summary>
        /// <returns>All available colors.</returns>
        public override IEnumerable<BootstrapColorBase> GetAll()
        {
            yield return Default;
            yield return Primary;
            yield return Success;
            yield return Info;
            yield return Warning;
            yield return Danger;
            yield return Inverse;
            yield return White;
        }
    }
}
