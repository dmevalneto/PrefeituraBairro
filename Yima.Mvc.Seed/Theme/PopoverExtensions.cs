using System;
using System.Web.Mvc;
using IssatisLab.Helpers.Bootstrap;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a popover.
    /// </summary>
    public static class PopoverExtensions
    {
        /// <summary>
        /// Returns a popover with the specified text and body.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="text">The text value of the popover.</param>
        /// <param name="popover">The value of the popover.</param>
        /// <returns>A bootstrap popover component.</returns>
        public static Popover YimaPopover(this HtmlHelper htmlHelper, string text, string popover)
        {
            var bootstrapPopover = htmlHelper.BootstrapPopover(text, popover);
            bootstrapPopover.SetAttribute("data-container", "body");

            return bootstrapPopover;
        }

        /// <summary>
        /// Changes the color of the popover title.
        /// </summary>
        /// <param name="popover">The popover instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static PopoverBase TitleColor(this PopoverBase popover, BootstrapColorBase color)
        {
            var value = popover.GetAttribute("data-titleclass");
            value = string.Join(" ", value, color);
            popover.SetAttribute("data-titleclass", value);

            return popover;
        }

        /// <summary>
        /// Changes the background color of the popover title.
        /// </summary>
        /// <param name="popover">The popover instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static PopoverBase TitleBackgroundColor(this PopoverBase popover, BootstrapColorBase color)
        {
            var value = popover.GetAttribute("data-titleclass");
            value = string.Join(" ", value, string.Format("bg-{0}", color));

            popover.SetAttribute("data-titleclass", value);

            return popover;
        }

        /// <summary>
        /// Changes the color of the popover content.
        /// </summary>
        /// <param name="popover">The popover instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static PopoverBase ContentColor(this PopoverBase popover, BootstrapColorBase color)
        {
            var value = popover.GetAttribute("data-titleclass");
            value = string.Join(" ", value, color);

            popover.SetAttribute("data-class", value);

            return popover;
        }

        /// <summary>
        /// Changes the background color of the popover content.
        /// </summary>
        /// <param name="popover">The popover instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static PopoverBase ContentBackgroundColor(this PopoverBase popover, BootstrapColorBase color)
        {
            var value = popover.GetAttribute("data-titleclass");
            value = string.Join(" ", value, string.Format("bg-{0}", color));

            popover.SetAttribute("data-class", value);

            return popover;
        }
    }
}
