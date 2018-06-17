using System;
using IssatisLab.Helpers.Bootstrap;
using IssatisLab.Helpers.Bootstrap.Components;
using IssatisLab.Helpers.FontAwesome;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a button dropdown.
    /// </summary>
    public static class ButtonDropdownExtensions
    {
        /// <summary>
        /// Changes a split button dropdown buttons to anchor.
        /// </summary>
        /// <param name="buttonDropdownBase">The button dropdown instance that this method extends.</param>
        /// <param name="buttonText">The value of the main button of the dropdown.</param>
        /// <returns>Current component.</returns>
        public static ButtonDropdownBase AnchorSplitButton(this ButtonDropdownBase buttonDropdownBase, string buttonText)
        {
            var button = buttonDropdownBase.HtmlHelper.BootstrapButton(buttonText);
            button.Anchor();

            var splitButton = buttonDropdownBase.HtmlHelper.BootstrapButton(buttonDropdownBase.HtmlHelper.FontAwesome(FontAwesomeType.AngleDown));
            splitButton.Anchor();

            buttonDropdownBase.SplitButton(button, splitButton);

            return buttonDropdownBase;
        }
    }
}
