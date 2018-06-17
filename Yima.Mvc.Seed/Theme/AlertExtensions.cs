using System;
using System.Web.Mvc;
using IssatisLab.Helpers.Bootstrap;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding an alert.
    /// </summary>
    public static class AlertExtensions
    {
        /// <summary>
        /// Returns an alert component with the specified title and text.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="title">The title of the alert.</param>
        /// <param name="text">The body of the alert.</param>
        /// <returns>An alert component.</returns>
        public static AlertBase YimaAlert(this HtmlHelper htmlHelper, string title, string text)
        {
            var message = "";
            if (!string.IsNullOrEmpty(title))
            {
                message += string.Format("<strong>{0}</strong> ", title);
            }
            message += text;

            var bootstrapAlert = htmlHelper.BootstrapAlert(message);
            bootstrapAlert.Dismissible().Fade();

            return bootstrapAlert;
        }
    }
}
