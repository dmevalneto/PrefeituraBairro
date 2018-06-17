using System;
using System.Web.WebPages;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a modal.
    /// </summary>
    public static class ModalExtensions
    {
        /// <summary>
        /// Adds content to the modal.
        /// </summary>
        /// <param name="modalBase">The modal instance that this method extends.</param>
        /// <param name="content">The value of the content.</param>
        /// <returns>Current component.</returns>
        public static ModalBase Body(this ModalBase modalBase, string content)
        {
            modalBase.AddChild(content);

            return modalBase;
        }

        /// <summary>
        /// Adds content to the modal.
        /// </summary>
        /// <param name="modalBase">The modal instance that this method extends.</param>
        /// <param name="content">The value of the content.</param>
        /// <returns>Current component.</returns>
        public static ModalBase Body(this ModalBase modalBase, Func<object, HelperResult> content)
        {
            modalBase.AddChild(content);

            return modalBase;
        }

        /// <summary>
        /// Turns modal to a message box with the specified color.
        /// </summary>
        /// <param name="modalBase">The modal instance that this method extends.</param>
        /// <param name="color">The color of the modal.</param>
        /// <returns>Current component.</returns>
        public static ModalBase Message(this ModalBase modalBase, BootstrapColorBase color)
        {
            modalBase.AddCssClass("modal-message");
            modalBase.AddCssClass(string.Format("{0}-{1}", modalBase.GetBaseClass(), color));

            return modalBase;
        }

        /// <summary>
        /// Sets the title of the modal content.
        /// </summary>
        /// <param name="modalContentBase">The modal content instance that this method extends.</param>
        /// <param name="title">The color of the modal.</param>
        /// <returns>Current component.</returns>
        public static ModalContentBase Title(this ModalContentBase modalContentBase, string title)
        {
            modalContentBase.AddChild(string.Format("<div class=\"modal-title\">{0}</div>", title), int.MinValue + 101);

            return modalContentBase;
        }

        /// <summary>
        /// Sets the color of the modal header.
        /// </summary>
        /// <param name="modalHeaderBase">The modal header instance that this method extends.</param>
        /// <param name="color">The color of the modal header.</param>
        /// <returns>Current component.</returns>
        public static ModalHeaderBase Color(this ModalHeaderBase modalHeaderBase, BootstrapColorBase color)
        {
            modalHeaderBase.AddCssClass(string.Format("header-{0}", color));

            return modalHeaderBase;
        }
    }
}
