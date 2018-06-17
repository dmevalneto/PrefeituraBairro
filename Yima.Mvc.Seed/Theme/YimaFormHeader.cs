using System;
using IssatisLab.Helpers.Bootstrap;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a form header.
    /// </summary>
    public static class YimaFormHeaderExtensions
    {
        /// <summary>
        /// Returns a form header component.
        /// </summary>
        /// <param name="form">The form instance that this method extends.</param>
        /// <param name="header">The value of the header.</param>
        /// <returns>A form header component.</returns>
        public static YimaFormHeader FormHeader(this IForm form, string header)
        {
            return new YimaFormHeader(form).AddChild(header);
        }

        /// <summary>
        /// Returns a form header component.
        /// </summary>
        /// <param name="formGroup">The formGroup instance that this method extends.</param>
        /// <param name="header">The value of the header.</param>
        /// <returns>A form header component.</returns>
        public static YimaFormHeader FormHeader(this IFormGroup formGroup, string header)
        {
            return new YimaFormHeader(formGroup).AddChild(header);
        }
    }

    /// <summary>
    /// Represents form header component.
    /// </summary>
    public class YimaFormHeader : FormParentComponent<YimaFormHeader>
    {
        /// <summary>
        /// Initializes a new instance of the component with the specified form.
        /// </summary>
        /// <param name="form">The form.</param>
        public YimaFormHeader(IForm form) : base(form)
        {
            Init();
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified form group.
        /// </summary>
        /// <param name="formGroup">The form group.</param>
        public YimaFormHeader(IFormGroup formGroup) : base(formGroup)
        {
            Init();
        }

        private void Init()
        {
            AddCssClass(GetBaseClass());
        }

        /// <summary>
        /// Returns base CSS class name for current component.
        /// </summary>
        /// <returns>The base CSS class of current component.</returns>
        public override string GetBaseClass()
        {
            return "form-heading";
        }

        /// <summary>
        /// Returns Base HTML tag for the current component.
        /// </summary>
        /// <returns>Base HTML tag of current component.</returns>
        protected override string GetBaseTag()
        {
            return "div";
        }
    }
}
