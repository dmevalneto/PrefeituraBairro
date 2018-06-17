using System;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a panel.
    /// </summary>
    public static class PanelExtensions
    {
        /// <summary>
        /// Adds specified tools to the panel header.
        /// </summary>
        /// <param name="panelHeader">The panel header instance that this method extends.</param>
        /// <param name="toolsType">Type of the tools to add to header.</param>
        /// <returns>Current component.</returns>
        public static PanelHeaderBase Tools(this PanelHeaderBase panelHeader, PanelHeaderToolsTypes toolsType)
        {
            var headerTools = string.Empty;
            if (toolsType.HasFlag(PanelHeaderToolsTypes.Collapse))
            {
                headerTools += @"<a class=""tools-action"" href=""#"" data-toggle=""collapse"">
                                    <i class=""pe-7s-angle-up""></i>
                                </a>";
            }
            if (toolsType.HasFlag(PanelHeaderToolsTypes.Maximize))
            {
                headerTools += @"<a class=""tools-action"" href=""#"" data-toggle=""maximize"">
                                    <i class=""pe-7s-expand1""></i>
                                </a>";
            }
            if (toolsType.HasFlag(PanelHeaderToolsTypes.Dispose))
            {
                headerTools += @"<a class=""tools-action"" href=""#"" data-toggle=""dispose"">
                                    <i class=""pe-7s-close""></i>
                                </a>";
            }

            headerTools = string.Format(@"<div class=""panel-tools"">{0}</div>", headerTools);

            panelHeader.AddChild(headerTools, int.MinValue);

            return panelHeader;
        }
    }

    [Flags]
    public enum PanelHeaderToolsTypes
    {
        None = 0,
        Collapse = 1,
        Maximize = 2,
        Dispose = 4
    }
}
