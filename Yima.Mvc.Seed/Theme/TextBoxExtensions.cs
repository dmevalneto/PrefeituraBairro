using System;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a text box.
    /// </summary>
    public static class TextBoxExtensions
    {
        /// <summary>
        /// Changes the background color of the text box.
        /// </summary>
        /// <param name="textBoxBase">The text box instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static TextBoxBase Background(this TextBoxBase textBoxBase, BootstrapColorBase color)
        {
            textBoxBase.AddCssClass(string.Format("bg-{0}", color));

            return textBoxBase;
        }

        /// <summary>
        /// Changes the background color of the text box.
        /// </summary>
        /// <param name="textBoxBase">The text box instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static FormTextBoxBase Background(this FormTextBoxBase textBoxBase, BootstrapColorBase color)
        {
            textBoxBase.AddCssClass(string.Format("bg-{0}", color));

            return textBoxBase;
        }
    }
}
