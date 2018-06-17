using System;
using System.Web.Mvc;
using IssatisLab.Helpers.Bootstrap;
using IssatisLab.Helpers.Bootstrap.Components;
using IssatisLab.Helpers.Bootstrap.Helpers;
using IssatisLab.Helpers.Core;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a progress bar.
    /// </summary>
    public static class YimaProgressBarExtensions
    {
        /// <summary>
        /// Returns a progress bar component by using the specified value.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="value">The value of the progress bar.</param>
        /// <returns>A progress bar component.</returns>
        public static YimaProgressBar YimaProgressBar(this HtmlHelper htmlHelper, int value)
        {
            return new YimaProgressBar(new YimaProgressBarCore(value, htmlHelper), htmlHelper);
        }

        /// <summary>
        /// Returns a progress bar component with the specified minimum and maximum value that shows specified value.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="value">The current value of the progress bar.</param>
        /// <param name="min">The minimum value of the progress bar.</param>
        /// <param name="max">The maximum value of the progress bar.</param>
        /// <returns>A progress bar component.</returns>
        public static YimaProgressBar YimaProgressBar(this HtmlHelper htmlHelper, int value, int min, int max)
        {
            return new YimaProgressBar(new YimaProgressBarCore(value, min, max, htmlHelper), htmlHelper);
        }
    }

    /// <summary>
    /// Represents support for adding a progress bar.
    /// </summary>
    public static class ProgressBarExtensions
    {
        /// <summary>
        /// Sets the size of the progress bar.
        /// </summary>
        /// <param name="progressBarBase">The progress bar instance that this method extends.</param>
        /// <param name="size">The value of the size.</param>
        /// <returns>Current component.</returns>
        public static ProgressBarBase Size(this ProgressBarBase progressBarBase, BootstrapSizeBase size)
        {
            SizeHelper.Size(progressBarBase, size);

            return progressBarBase;
        }

        /// <summary>
        /// Adds border to the progress bar.
        /// </summary>
        /// <param name="progressBarBase">The progress bar instance that this method extends.</param>
        /// <returns>Current component.</returns>
        public static ProgressBarBase Border(this ProgressBarBase progressBarBase)
        {
            progressBarBase.AddCssClass(string.Format("{0}-bordered", progressBarBase.GetBaseClass()));

            return progressBarBase;
        }

        /// <summary>
        /// Makes the progress bar to start from right side.
        /// </summary>
        /// <param name="progressBarBase">The progress bar instance that this method extends.</param>
        /// <returns>Current component.</returns>
        public static ProgressBarBase Right(this ProgressBarBase progressBarBase)
        {
            progressBarBase.AddCssClass(string.Format("{0}-right", progressBarBase.GetBaseClass()));

            return progressBarBase;
        }

        /// <summary>
        /// Makes the progress bar vertical and whether it starts from bottom or not.
        /// </summary>
        /// <param name="progressBarBase">The progress bar instance that this method extends.</param>
        /// <param name="bottom">Sets whether progress bar should start from bottom or not.</param>
        /// <returns>Current component.</returns>
        public static ProgressBarBase Vertical(this ProgressBarBase progressBarBase, bool bottom = true)
        {
            progressBarBase.Core.Properties.Add("IsVertival", true);
            progressBarBase.AddCssClass(string.Format("{0}-vertical", progressBarBase.GetBaseClass()));
            if (bottom)
                progressBarBase.AddCssClass(string.Format("{0}-bottom", progressBarBase.GetBaseClass()));

            return progressBarBase;
        }
    }

    /// <summary>
    /// Represents progress bar core component.
    /// </summary>
    public class YimaProgressBarCore : ProgressBarCore
    {
        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="htmlHelper">The HTML helper.</param>
        public YimaProgressBarCore(int value, HtmlHelper htmlHelper) : base(value, htmlHelper)
        {
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="htmlHelper"></param>
        public YimaProgressBarCore(int value, int min, int max, HtmlHelper htmlHelper) : base(value, min, max, htmlHelper)
        {
        }

        /// <summary>
        /// Sets the label of the progress bar.
        /// </summary>
        /// <param name="label">The value of the label.</param>
        /// <returns>Current component.</returns>
        public override ProgressBarCoreBase Label(string label)
        {
            return base.Label(string.Format("<span>{0}</span>", label));
        }

        /// <summary>
        /// Returns HTML representation of the component.
        /// </summary>
        /// <returns>HTML representation of the component.</returns>
        public override string ToHtmlString()
        {
            object isVertivalObj;
            Properties.TryGetValue("IsVertival", out isVertivalObj);
            var isVertival = isVertivalObj as bool?;

            if (isVertival.HasValue && isVertival.Value)
            {
                for (var i = 0; i < Styles.Count; i++)
                {
                    Styles[i] = Styles[i].Replace("width", "height");
                }    
            }

            return base.ToHtmlString();
        }
    }

    /// <summary>
    /// Represents progress bar component.
    /// </summary>
    public class YimaProgressBar : ProgressBarBase
    {
        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper and progress bar core.
        /// </summary>
        /// <param name="core">The progress bar core value.</param>
        /// <param name="htmlHelper">The HTML helper.</param>
        public YimaProgressBar(ProgressBarCoreBase core, HtmlHelper htmlHelper) : base(core, htmlHelper)
        {
        }

        /// <summary>
        /// Returns HTML representation of the component.
        /// </summary>
        /// <returns>HTML representation of the component.</returns>
        public override string ToHtmlString()
        {
            AddSelfChild(new RawHtml(Core.ToHtmlString()));

            return base.ToHtmlString();
        }
    }
}
