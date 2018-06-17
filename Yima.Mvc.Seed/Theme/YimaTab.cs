using System;
using System.Web.Mvc;
using System.Web.WebPages;
using IssatisLab.Helpers.Bootstrap;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a tab.
    /// </summary>
    public static class YimaTabExtensions
    {
        /// <summary>
        /// Returns a tab component.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <returns>A tab component.</returns>
        public static YimaTab YimaTab(this HtmlHelper htmlHelper)
        {
            return new YimaTab(htmlHelper);
        }

        /// <summary>
        /// Returns a tab panel component.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <returns>A tab panel component.</returns>
        public static YimaTabPanel YimaTabPanel(this HtmlHelper htmlHelper)
        {
            return new YimaTabPanel(htmlHelper);
        }

        /// <summary>
        /// Returns a tab panel component with the specified id.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="id">The value of the id.</param>
        /// <returns>A tab panel component.</returns>
        public static YimaTabPanel YimaTabPanel(this HtmlHelper htmlHelper, string id)
        {
            return new YimaTabPanel(id, htmlHelper);
        }
    }

    /// <summary>
    /// Represents tab component.
    /// </summary>
    public class YimaTab : TabBase
    {
        private YimaTabListPlacementType _placementType;
        private bool _isJustify;

        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        public YimaTab(HtmlHelper htmlHelper) : base(htmlHelper)
        {
        }

        /// <summary>
        /// Sets the tab list placement type.
        /// </summary>
        /// <param name="placementType">The value of the tab placement type.</param>
        /// <returns>Current component.</returns>
        public YimaTab TabListPlacement(YimaTabListPlacementType placementType)
        {
            _placementType = placementType;

            if (_placementType == YimaTabListPlacementType.Left)
                AddCssClass("tabs-left");

            if (_placementType == YimaTabListPlacementType.Right)
                AddCssClass("tabs-right");

            return this;
        }

        /// <summary>
        /// Justifies the tab.
        /// </summary>
        /// <returns>Current component.</returns>
        public YimaTab Justify()
        {
            _isJustify = true;

            return this;
        }

        /// <summary>
        /// Returns HTML representation of the component.
        /// </summary>
        /// <returns>HTML representation of the component.</returns>
        public override string ToHtmlString()
        {
            var tabTitles = new TagBuilder("ul");
            tabTitles.AddCssClass("nav");
            tabTitles.AddCssClass(TabType.ToString());
            tabTitles.Attributes.Add("role", "tablist");
            if (_isJustify)
                tabTitles.AddCssClass("nav-justified");

            foreach (var tabPanel in TabPanels)
            {
                if (tabPanel.TitleValue != null)
                    tabTitles.InnerHtml += tabPanel.TitleValue.ToHtmlString();
            }

            var tabContent = new TagBuilder("div");
            tabContent.AddCssClass("tab-content");
            foreach (var tabPanel in TabPanels)
            {
                if (tabPanel.ContentValue != null)
                    tabContent.InnerHtml += tabPanel.ContentValue.ToHtmlString();
            }

            if (_placementType == YimaTabListPlacementType.Bottom)
            {
                AddChild(tabContent.ToString(), int.MinValue);
                AddChild(tabTitles.ToString(), int.MinValue + 1);
            }
            else
            {
                AddChild(tabTitles.ToString(), int.MinValue);
                AddChild(tabContent.ToString(), int.MinValue + 1);
            }

            return base.ToHtmlString();
        }
    }

    /// <summary>
    /// Represents tab panel component.
    /// </summary>
    public class YimaTabPanel : TabPanel
    {
        private BootstrapColorBase _color;
        private HtmlHelper _htmlHelper;

        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        public YimaTabPanel(HtmlHelper htmlHelper)
        {
            _htmlHelper = htmlHelper;
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper.
        /// </summary>
        /// <param name="id">The value of the id.</param>
        /// <param name="htmlHelper">The HTML helper.</param>
        public YimaTabPanel(string id, HtmlHelper htmlHelper) : base(id)
        {
            _htmlHelper = htmlHelper;
        }

        /// <summary>
        /// Sets the color of the tab panel.
        /// </summary>
        /// <param name="color">The value of color.</param>
        /// <returns>Current component.</returns>
        public YimaTabPanel Color(BootstrapColorBase color)
        {
            _color = color;
            if (TitleValue != null)
            {
                TitleValue.Color(_color);
            }
            if (ContentValue != null)
            {
                ContentValue.Color(_color);
            }

            return this;
        }

        /// <summary>
        /// Sets the title of the tab panel with the specified value.
        /// </summary>
        /// <param name="title">The value of the title.</param>
        /// <returns>Current component.</returns>
        public override TabPanel Title(TabPanelTitleBase title)
        {
            base.Title(title);
            if (_color != null)
                TitleValue.Color(_color);

            return this;
        }

        /// <summary>
        /// Sets the title of the tab panel with the specified value.
        /// </summary>
        /// <param name="title">The value of the title.</param>
        /// <returns>Current component.</returns>
        public YimaTabPanel Title(string title)
        {
            Title(_htmlHelper.BootstrapTabPanelTitle().Title(title));

            return this;
        }

        /// <summary>
        /// Sets the title of the tab panel with the specified value.
        /// </summary>
        /// <param name="dropdown">The value of the title.</param>
        /// <returns>Current component.</returns>
        public YimaTabPanel Title(DropdownBase dropdown)
        {
            Title(_htmlHelper.BootstrapTabPanelTitle().Title(dropdown));

            return this;
        }

        /// <summary>
        /// Sets the content of the tab panel with the specified value.
        /// </summary>
        /// <param name="content">The value of the content.</param>
        /// <returns>Current component.</returns>
        public override TabPanel Content(TabPanelContentBase content)
        {
            base.Content(content);
            if (_color != null)
                ContentValue.Color(_color);

            return this;
        }

        /// <summary>
        /// Sets the content of the tab panel with the specified value.
        /// </summary>
        /// <param name="content">The value of the content.</param>
        /// <returns>Current component.</returns>
        public TabPanel Content(string content)
        {
            Content(_htmlHelper.BootstrapTabPanelContent().AddChild(content));

            return this;
        }

        /// <summary>
        /// Sets the content of the tab panel with the specified value.
        /// </summary>
        /// <param name="content">The value of the content.</param>
        /// <returns>Current component.</returns>
        public TabPanel Content(Func<object, HelperResult> content)
        {
            Content(_htmlHelper.BootstrapTabPanelContent().AddChild(content));

            return this;
        }
    }

    public static class TabPanelExtensions
    {
        /// <summary>
        /// Sets the color of the tab panel title.
        /// </summary>
        /// <param name="tabPanelTitleBase">The tab panel title instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static TabPanelTitleBase Color(this TabPanelTitleBase tabPanelTitleBase, BootstrapColorBase color)
        {
            tabPanelTitleBase.AddCssClass(string.Format("tab-{0}", color));

            return tabPanelTitleBase;
        }

        /// <summary>
        /// Sets the color of the tab panel content.
        /// </summary>
        /// <param name="tabPanelContentBase">The tab panel content instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static TabPanelContentBase Color(this TabPanelContentBase tabPanelContentBase, BootstrapColorBase color)
        {
            tabPanelContentBase.AddCssClass(string.Format("tab-pane-{0}", color));

            return tabPanelContentBase;
        }
    }

    /// <summary>
    /// Represents tab list placement type.
    /// </summary>
    public enum YimaTabListPlacementType : byte
    {
        Top = 1,
        Bottom = 2,
        Left = 3,
        Right = 4
    }
}
