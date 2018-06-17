using System;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a multi progress bar.
    /// </summary>
    public static class MultiProgressBarExtensions
    {
        /// <summary>
        /// Adds border to the progress bar.
        /// </summary>
        /// <param name="multiProgressBase">The multi progress bar instance that this method extends.</param>
        /// <returns>Current component.</returns>
        public static MultiProgressBase Border(this MultiProgressBase multiProgressBase)
        {
            multiProgressBase.AddCssClass(string.Format("{0}-bordered", multiProgressBase.GetBaseClass()));

            return multiProgressBase;
        }
    }
}
