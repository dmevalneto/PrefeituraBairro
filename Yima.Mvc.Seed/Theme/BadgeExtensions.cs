using System;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a badge.
    /// </summary>
    public static class BadgeExtensions
    {
        /// <summary>
        /// Changes the badge to a square.
        /// </summary>
        /// <param name="badge">The badge instance that this method extends.</param>
        /// <returns>Current component.</returns>
        public static BadgeBase Square(this BadgeBase badge)
        {
            badge.AddCssClass(string.Format("{0}-square", badge.GetBaseClass()));

            return badge;
        }
    }
}
