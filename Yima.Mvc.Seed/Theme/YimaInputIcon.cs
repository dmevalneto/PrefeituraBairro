using System;
using System.Web.Mvc;
using IssatisLab.Helpers.Bootstrap;
using IssatisLab.Helpers.Bootstrap.Components;
using IssatisLab.Helpers.Core;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding an input icon component.
    /// </summary>
    public static class YimaInputIconExtensions
    {
        /// <summary>
        /// Returns an input icon component.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="textBox">The text box component of input icon.</param>
        /// <returns>An input icon component.</returns>
        public static YimaInputIcon YimaInputIcon(this HtmlHelper htmlHelper, TextBoxBase textBox)
        {
            return new YimaInputIcon(htmlHelper, textBox);
        }

        /// <summary>
        /// Returns an input icon component.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="textBox">The text box component of input icon.</param>
        /// <returns>An input icon component.</returns>
        public static YimaInputIcon YimaInputIcon(this HtmlHelper htmlHelper, FormTextBoxBase textBox)
        {
            return new YimaInputIcon(htmlHelper, textBox);
        }

        /// <summary>
        /// Returns an input icon component.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="textArea">The text area component of input icon.</param>
        /// <returns>An input icon component.</returns>
        public static YimaInputIcon YimaInputIcon(this HtmlHelper htmlHelper, TextAreaBase textArea)
        {
            return new YimaInputIcon(htmlHelper, textArea);
        }

        /// <summary>
        /// Returns an input icon component.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="formTextArea">The text area component of input icon.</param>
        /// <returns>An input icon component.</returns>
        public static YimaInputIcon YimaInputIcon(this HtmlHelper htmlHelper, FormTextAreaBase formTextArea)
        {
            return new YimaInputIcon(htmlHelper, formTextArea);
        }

        /// <summary>
        /// Returns an input icon component.
        /// </summary>
        /// <param name="form">The Form instance that this method extends.</param>
        /// <param name="textBox">The text box component of input icon.</param>
        /// <returns>An input icon component.</returns>
        public static YimaFormInputIcon InputIcon(this IForm form, TextBoxBase textBox)
        {
            return new YimaFormInputIcon(form, textBox);
        }

        /// <summary>
        /// Returns an input icon component.
        /// </summary>
        /// <param name="form">The Form instance that this method extends.</param>
        /// <param name="textBox">The text box component of input icon.</param>
        /// <returns>An input icon component.</returns>
        public static YimaFormInputIcon InputIcon(this IForm form, FormTextBoxBase textBox)
        {
            return new YimaFormInputIcon(form, textBox);
        }

        /// <summary>
        /// Returns an input icon component.
        /// </summary>
        /// <param name="formGroup">The form group instance that this method extends.</param>
        /// <param name="textBox">The text box component of input icon.</param>
        /// <returns>An input icon component.</returns>
        public static YimaFormInputIcon InputIcon(this IFormGroup formGroup, TextBoxBase textBox)
        {
            return new YimaFormInputIcon(formGroup, textBox);
        }

        /// <summary>
        /// Returns an input icon component.
        /// </summary>
        /// <param name="formGroup">The form group instance that this method extends.</param>
        /// <param name="textBox">The text box component of input icon.</param>
        /// <returns>An input icon component.</returns>
        public static YimaFormInputIcon InputIcon(this IFormGroup formGroup, FormTextBoxBase textBox)
        {
            return new YimaFormInputIcon(formGroup, textBox);
        }

        /// <summary>
        /// Returns an input icon component.
        /// </summary>
        /// <param name="form">The form instance that this method extends.</param>
        /// <param name="textArea">The text area component of input icon.</param>
        /// <returns>An input icon component.</returns>
        public static YimaFormInputIcon InputIcon(this IForm form, TextAreaBase textArea)
        {
            return new YimaFormInputIcon(form, textArea);
        }

        /// <summary>
        /// Returns an input icon component.
        /// </summary>
        /// <param name="form">The form instance that this method extends.</param>
        /// <param name="textArea">The text area component of input icon.</param>
        /// <returns>An input icon component.</returns>
        public static YimaFormInputIcon InputIcon(this IForm form, FormTextAreaBase textArea)
        {
            return new YimaFormInputIcon(form, textArea);
        }

        /// <summary>
        /// Returns an input icon component.
        /// </summary>
        /// <param name="formGroup">The form group instance that this method extends.</param>
        /// <param name="textArea">The text area component of input icon.</param>
        /// <returns>An input icon component.</returns>
        public static YimaFormInputIcon InputIcon(this IFormGroup formGroup, TextAreaBase textArea)
        {
            return new YimaFormInputIcon(formGroup, textArea);
        }

        /// <summary>
        /// Returns an input icon component.
        /// </summary>
        /// <param name="formGroup">The form group instance that this method extends.</param>
        /// <param name="textArea">The text area component of input icon.</param>
        /// <returns>An input icon component.</returns>
        public static YimaFormInputIcon InputIcon(this IFormGroup formGroup, FormTextAreaBase textArea)
        {
            return new YimaFormInputIcon(formGroup, textArea);
        }
    }

    /// <summary>
    /// Represents input icon component.
    /// </summary>
    public class YimaInputIcon : ParentComponent<YimaInputIcon>
    {
        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper and text box.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="textBox">The text box.</param>
        public YimaInputIcon(HtmlHelper htmlHelper, TextBoxBase textBox) : base(htmlHelper)
        {
            Init(textBox);
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper and text box.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="textBox">The text box.</param>
        public YimaInputIcon(HtmlHelper htmlHelper, FormTextBoxBase textBox) : base(htmlHelper)
        {
            Init(textBox);
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper and text area.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="textArea">The text area.</param>
        public YimaInputIcon(HtmlHelper htmlHelper, TextAreaBase textArea) : base(htmlHelper)
        {
            Init(textArea);
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper and text area.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="textArea">The text area.</param>
        public YimaInputIcon(HtmlHelper htmlHelper, FormTextAreaBase textArea) : base(htmlHelper)
        {
            Init(textArea);
        }

        private void Init(IHtml textBox)
        {
            AddChild(textBox);
        }

        /// <summary>
        /// Adds an icon before the text box.
        /// </summary>
        /// <typeparam name="T">The type of the icon.</typeparam>
        /// <param name="icon">The value of the icon.</param>
        /// <returns>Current component.</returns>
        public YimaInputIcon AddonBefore<T>(IIcon<T> icon) where T : IIcon<T>
        {
            AddCssClass("prepend-icon");
            AddChild(icon);

            return this;
        }

        /// <summary>
        /// Adds an icon after the text box.
        /// </summary>
        /// <typeparam name="T">The type of the icon.</typeparam>
        /// <param name="icon">The value of the icon.</param>
        /// <returns>Current component.</returns>
        public YimaInputIcon AddonAfter<T>(IIcon<T> icon) where T : IIcon<T>
        {
            AddCssClass("append-icon");
            AddChild(icon);

            return this;
        }

        /// <summary>
        /// Returns base CSS class name for current component.
        /// </summary>
        /// <returns>The base CSS class of current component.</returns>
        public override string GetBaseClass()
        {
            return null;
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

    /// <summary>
    /// Represents input icon component.
    /// </summary>
    public class YimaFormInputIcon : FormParentComponent<YimaFormInputIcon>
    {
        /// <summary>
        /// HTML attributes of the label.
        /// </summary>
        public HtmlAttribute LabelHtmlAttribute
        {
            get;
            private set;
        }

        /// <summary>
        /// The value of the label.
        /// </summary>
        public string LabelValue
        {
            get;
            private set;
        }

        /// <summary>
        /// The HTML "Id" attribute of the help block.
        /// </summary>
        public string HelpId
        {
            get;
            private set;
        }

        /// <summary>
        /// The value of the help block.
        /// </summary>
        public string Help
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified form and text box.
        /// </summary>
        /// <param name="form">The form.</param>
        /// <param name="textBox">The text box.</param>
        public YimaFormInputIcon(IForm form, TextBoxBase textBox) : base(form)
        {
            Init(textBox);
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified form and text box.
        /// </summary>
        /// <param name="form">The form.</param>
        /// <param name="textBox">The text box.</param>
        public YimaFormInputIcon(IForm form, FormTextBoxBase textBox) : base(form)
        {
            Init(textBox);
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified form group and text box.
        /// </summary>
        /// <param name="formGroup">The form group.</param>
        /// <param name="textBox">The text box.</param>
        public YimaFormInputIcon(IFormGroup formGroup, TextBoxBase textBox) : base(formGroup)
        {
            Init(textBox);
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified form group and text box.
        /// </summary>
        /// <param name="formGroup">The form group.</param>
        /// <param name="textBox">The text box.</param>
        public YimaFormInputIcon(IFormGroup formGroup, FormTextBoxBase textBox) : base(formGroup)
        {
            Init(textBox);
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper and text box.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="textArea">The text area.</param>
        public YimaFormInputIcon(IForm form, TextAreaBase textArea) : base(form)
        {
            Init(textArea);
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified form and text area.
        /// </summary>
        /// <param name="form">The form.</param>
        /// <param name="textArea">The text area.</param>
        public YimaFormInputIcon(IForm form, FormTextAreaBase textArea) : base(form)
        {
            Init(textArea);
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified form group and text area.
        /// </summary>
        /// <param name="formGroup">The form group.</param>
        /// <param name="textArea">The text area.</param>
        public YimaFormInputIcon(IFormGroup formGroup, TextAreaBase textArea) : base(formGroup)
        {
            Init(textArea);
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified form group and text area.
        /// </summary>
        /// <param name="formGroup">The form group.</param>
        /// <param name="textArea">The text area.</param>
        public YimaFormInputIcon(IFormGroup formGroup, FormTextAreaBase textArea) : base(formGroup)
        {
            Init(textArea);
        }

        private void Init(IHtml textBox)
        {
            AddChild(textBox);
            LabelHtmlAttribute = new HtmlAttribute();
            LabelHtmlAttribute.Append("class", GetLabelSize());
        }

        /// <summary>
        /// Adds an icon before the text box.
        /// </summary>
        /// <typeparam name="T">The type of the icon.</typeparam>
        /// <param name="icon">The value of the icon.</param>
        /// <returns>Current component.</returns>
        public YimaFormInputIcon AddonBefore<T>(IIcon<T> icon) where T : IIcon<T>
        {
            AddCssClass("prepend-icon");
            AddChild(icon);

            return this;
        }

        /// <summary>
        /// Adds an icon after the text box.
        /// </summary>
        /// <typeparam name="T">The type of the icon.</typeparam>
        /// <param name="icon">The value of the icon.</param>
        /// <returns>Current component.</returns>
        public YimaFormInputIcon AddonAfter<T>(IIcon<T> icon) where T : IIcon<T>
        {
            AddCssClass("append-icon");
            AddChild(icon);

            return this;
        }

        /// <summary>
        /// Sets the value of the label.
        /// </summary>
        /// <param name="label">The value of the label.</param>
        /// <returns>Current component.</returns>
        public YimaFormInputIcon Label(string label)
        {
            LabelValue = label;
            LabelHtmlAttribute.Append("class", "control-label");

            return this;
        }

        /// <summary>
        /// Hides the label.
        /// </summary>
        /// <returns>Current component.</returns>
        public YimaFormInputIcon HideLabel()
        {
            LabelHtmlAttribute.Append("class", "sr-only");

            return this;
        }

        /// <summary>
        /// Sets the help block value.
        /// </summary>
        /// <param name="help">The help block value.</param>
        /// <returns>Current component.</returns>
        public YimaFormInputIcon HelpBlock(string help)
        {
            Help = help;
            HelpId = "helpBlock" + RandomIdGenerator.Instance.GetId();
            SetAttribute("aria-describedby", HelpId);

            return this;
        }

        /// <summary>
        /// Returns base CSS class name for current component.
        /// </summary>
        /// <returns>The base CSS class of current component.</returns>
        public override string GetBaseClass()
        {
            return null;
        }

        /// <summary>
        /// Returns Base HTML tag for the current component.
        /// </summary>
        /// <returns>Base HTML tag of current component.</returns>
        protected override string GetBaseTag()
        {
            return "div";
        }

        /// <summary>
        /// Returns HTML representation of the component.
        /// </summary>
        /// <returns>HTML representation of the component.</returns>
        public override string ToHtmlString()
        {
            var label = GetLabel(LabelValue, LabelHtmlAttribute);

            return base.ToHtmlString(label, Help, HelpId);
        }
    }
}
