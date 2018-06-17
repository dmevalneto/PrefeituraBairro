using System;
using System.Web.Mvc;
using System.Web.WebPages;
using IssatisLab.Helpers.Bootstrap;
using IssatisLab.Helpers.Bootstrap.Components;
using IssatisLab.Helpers.Bootstrap.Helpers;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding an accordion.
    /// </summary>
    public static class AccordionExtensions
    {
        /// <summary>
        /// Returns a bootstrap accordion component.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <returns>A bootstrap accordion component.</returns>
        public static YimaAccordion YimaAccordion(this HtmlHelper htmlHelper)
        {
            return new YimaAccordion(htmlHelper);
        }

        /// <summary>
        /// Returns a bootstrap accordion panel component.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <returns>A bootstrap accordion panel component.</returns>
        public static YimaAccordionPanel YimaAccordionPanel(this HtmlHelper htmlHelper)
        {
            return new YimaAccordionPanel(htmlHelper);
        }

        /// <summary>
        /// Changes the color of the bootstrap accordion panel.
        /// </summary>
        /// <param name="accordionPanel">The accordion panel instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static AccordionPanelBase Color(this AccordionPanelBase accordionPanel, BootstrapColorBase color)
        {
            ColorHelper.Color(accordionPanel, color);

            return accordionPanel;
        }
    }

    /// <summary>
    /// Represents accordion component.
    /// </summary>
    public class YimaAccordion : Accordion
    {
        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        public YimaAccordion(HtmlHelper htmlHelper) : base(htmlHelper)
        {
            AddCssClass("accordion");
        }
    }

    /// <summary>
    /// Represents accordion panel component 
    /// </summary>
    public class YimaAccordionPanel : AccordionPanel
    {
        private readonly HtmlHelper _htmlHelper;

        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        public YimaAccordionPanel(HtmlHelper htmlHelper) : base(htmlHelper)
        {
            _htmlHelper = htmlHelper;
        }

        /// <summary>
        /// Adds the specified content to the body.
        /// </summary>
        /// <param name="content">The content of the body.</param>
        /// <returns>Current component.</returns>
        public YimaAccordionPanel Body(string content)
        {
            Body(_htmlHelper.BootstrapAccordionPanelBody().AddChild(content));

            return this;
        }

        /// <summary>
        /// Adds the specified content to the body.
        /// </summary>
        /// <param name="content">The content of the body.</param>
        /// <returns>Current component.</returns>
        public YimaAccordionPanel Body(Func<object, HelperResult> content)
        {
            Body(_htmlHelper.BootstrapAccordionPanelBody().AddChild(content));

            return this;
        }
    }
}
