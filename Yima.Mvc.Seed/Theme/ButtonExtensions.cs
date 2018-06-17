using System;
using System.Web.Mvc;
using IssatisLab.Helpers.Bootstrap;
using IssatisLab.Helpers.Bootstrap.Components;
using IssatisLab.Helpers.Core;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a button.
    /// </summary>
    public static class ButtonExtensions
    {
        /// <summary>
        /// Makes the button block.
        /// </summary>
        /// <param name="button">The button instance that this method extends.</param>
        /// <returns>Current component.</returns>
        public static ButtonBase Block(this ButtonBase button)
        {
            button.AddCssClass(string.Format("{0}-block", button.GetBaseClass()));

            return button;
        }

        /// <summary>
        /// Changes the button to anchor.
        /// </summary>
        /// <param name="button">The button instance that this method extends.</param>
        /// <returns>Current component.</returns>
        public static ButtonBase Anchor(this ButtonBase button)
        {
            button.Anchor("#");

            return button;
        }

        /// <summary>
        /// Returns a button with the specified text and appended icon.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="text">The text value of the button.</param>
        /// <param name="icon">The icon of the button.</param>
        /// <returns>A bootstrap button.</returns>
        public static Button BootstrapButton<T>(this HtmlHelper htmlHelper, string text, IIcon<T> icon) where T : IIcon<T>
        {
            var bootstrapButton = htmlHelper.BootstrapButton(text);
            icon.AddCssClass("append");
            bootstrapButton.AddChild(icon);

            return bootstrapButton;
        }

        /// <summary>
        /// Returns a button with the specified text and prepended icon.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="icon">The icon of the button.</param>
        /// <param name="text">The text value of the button.</param>
        /// <returns>A bootstrap button.</returns>
        public static Button BootstrapButton<T>(this HtmlHelper htmlHelper, IIcon<T> icon, string text) where T : IIcon<T>
        {
            var bootstrapButton = htmlHelper.BootstrapButton(icon);
            bootstrapButton.AddChild(text);

            return bootstrapButton;
        }

        /// <summary>
        /// Returns a button with the specified text and prepended labeled icon.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="icon">The icon of the button.</param>
        /// <param name="text">The text value of the button.</param>
        /// <returns>A bootstrap button.</returns>
        public static Button BootstrapButtonLabeled<T>(this HtmlHelper htmlHelper, IIcon<T> icon, string text) where T : IIcon<T>
        {
            var bootstrapButton = htmlHelper.BootstrapButton();

            bootstrapButton.Anchor();
            icon.AddCssClass(string.Format("{0}-label", bootstrapButton.GetBaseClass()));
            bootstrapButton.AddCssClass(string.Format("{0}-labeled", bootstrapButton.GetBaseClass()));

            bootstrapButton.AddChild(icon);
            bootstrapButton.AddChild(text);

            return bootstrapButton;
        }
    }
}
