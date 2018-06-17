using System;
using IssatisLab.Helpers.Bootstrap;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a tooltip.
    /// </summary>
    public static class TooltipExtensions
    {
        /// <summary>
        /// Changes the button to a tooltip with the specified value, placement, and color.
        /// </summary>
        /// <param name="button">The button instance that this method extends.</param>
        /// <param name="tooltip">The value of the tooltip.</param>
        /// <param name="placement">The placement of the tooltip.</param>
        /// <param name="color">The color of the tooltip.</param>
        /// <returns>Current component.</returns>
        public static ButtonBase Tooltip(this ButtonBase button, string tooltip, BootstrapTooltipPlacementType placement, BootstrapColorBase color)
        {
            button.AddCssClass(string.Format("tooltip-{0}", color));
            button.Tooltip(tooltip, placement);

            return button;
        }
    }
}
