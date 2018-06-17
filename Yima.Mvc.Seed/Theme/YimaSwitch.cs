using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using IssatisLab.Helpers.Bootstrap;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    public static class YimaSwitchExtensions
    {
        /// <summary>
        /// Returns a switch input element for each property in the object that is represented by the specified expression.
        /// </summary>
        /// 
        /// <returns>
        /// A switch input element for each property in the object that is represented by the specified expression.
        /// </returns>
        /// <param name="form">The IForm instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        public static YimaFormSwitch<TModel> YimaSwitchFor<TModel>(this IForm<TModel> form, Expression<Func<TModel, bool>> expression)
        {
            return form.YimaSwitchFor<TModel>(expression, (IDictionary<string, object>)null);
        }

        /// <summary>
        /// Returns a switch input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// A switch input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </returns>
        /// <param name="form">The IForm instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        public static YimaFormSwitch<TModel> YimaSwitchFor<TModel>(this IForm<TModel> form, Expression<Func<TModel, bool>> expression, object htmlAttributes)
        {
            return form.YimaSwitchFor<TModel>(expression, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// Returns a switch input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// A switch input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </returns>
        /// <param name="form">The IForm instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="htmlAttributes">A dictionary that contains the HTML attributes to set for the element.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        public static YimaFormSwitch<TModel> YimaSwitchFor<TModel>(this IForm<TModel> form, Expression<Func<TModel, bool>> expression, IDictionary<string, object> htmlAttributes)
        {
            return new YimaFormSwitch<TModel>(form, expression, htmlAttributes);
        }

        /// <summary>
        /// Returns a switch input element for each property in the object that is represented by the specified expression.
        /// </summary>
        /// 
        /// <returns>
        /// A switch input element for each property in the object that is represented by the specified expression.
        /// </returns>
        /// <param name="formGroup">The IFormGroup instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        public static YimaFormSwitch<TModel> YimaSwitchFor<TModel>(this IFormGroup<TModel> formGroup, Expression<Func<TModel, bool>> expression)
        {
            return formGroup.YimaSwitchFor<TModel>(expression, (IDictionary<string, object>)null);
        }

        /// <summary>
        /// Returns a switch input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// A switch input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </returns>
        /// <param name="formGroup">The IFormGroup instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        public static YimaFormSwitch<TModel> YimaSwitchFor<TModel>(this IFormGroup<TModel> formGroup, Expression<Func<TModel, bool>> expression, object htmlAttributes)
        {
            return formGroup.YimaSwitchFor<TModel>(expression, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// Returns a switch input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// A switch input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </returns>
        /// <param name="formGroup">The IFormGroup instance that this method extends.</param><
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="htmlAttributes">A dictionary that contains the HTML attributes to set for the element.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        public static YimaFormSwitch<TModel> YimaSwitchFor<TModel>(this IFormGroup<TModel> formGroup, Expression<Func<TModel, bool>> expression, IDictionary<string, object> htmlAttributes)
        {
            return new YimaFormSwitch<TModel>(formGroup, expression, htmlAttributes);
        }
        
        /// <summary>
        /// Returns a switch input element by using the specified HTML helper and the name of the form field.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "checkbox".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field.</param>
        public static YimaSwitch YimaSwitch(this HtmlHelper htmlHelper, string name)
        {
            return htmlHelper.YimaSwitch(name, (object)null);
        }

        /// <summary>
        /// Returns a switch input element by using the specified HTML helper, the name of the form field, and a value to indicate whether the check box is selected.
        /// </summary>
        /// 
        /// <returns>
        /// A switch input element.
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="isChecked">true to select the check box; otherwise, false. The value of the check box is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a checked attribute in the html attributes.</param>
        public static YimaSwitch YimaSwitch(this HtmlHelper htmlHelper, string name, bool isChecked)
        {
            return htmlHelper.YimaSwitch(name, isChecked, (object)null);
        }

        /// <summary>
        /// Returns a switch input element by using the specified HTML helper, the name of the form field, a value that indicates whether the check box is selected, and the HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// A switch input element.
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="isChecked">true to select the check box; otherwise, false. The value of the check box is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a checked attribute in the html attributes.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public static YimaSwitch YimaSwitch(this HtmlHelper htmlHelper, string name, bool isChecked, object htmlAttributes)
        {
            return htmlHelper.YimaSwitch(name, isChecked, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// Returns a switch input element by using the specified HTML helper, the name of the form field, and the HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// A switch input element.
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public static YimaSwitch YimaSwitch(this HtmlHelper htmlHelper, string name, object htmlAttributes)
        {
            return htmlHelper.YimaSwitch(name, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// Returns a switch input element by using the specified HTML helper, the name of the form field, and the HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// A switch input element.
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public static YimaSwitch YimaSwitch(this HtmlHelper htmlHelper, string name, IDictionary<string, object> htmlAttributes)
        {
            return new YimaSwitch(htmlHelper, name, htmlAttributes);
        }

        /// <summary>
        /// Returns a switch input element by using the specified HTML helper, the name of the form field, a value to indicate whether the check box is selected, and the HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// A switch input element.
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="isChecked">true to select the check box; otherwise, false. The value of the check box is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a checked attribute in the html attributes.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public static YimaSwitch YimaSwitch(this HtmlHelper htmlHelper, string name, bool isChecked, IDictionary<string, object> htmlAttributes)
        {
            return new YimaSwitch(htmlHelper, name, isChecked, htmlAttributes);
        }
    }

    /// <summary>
    /// Represents a form switch component.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    public class YimaFormSwitch<TModel> : FormCheckBox<TModel>
    {
        /// <summary>
        /// Initializes a new instance of the form check box for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <param name="form">The current form instance.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="htmlAttributes">A dictionary that contains the HTML attributes to set for the element.</param>
        public YimaFormSwitch(IForm<TModel> form, Expression<Func<TModel, bool>> expression, IDictionary<string, object> htmlAttributes) : base(form, expression, htmlAttributes)
        {
        }

        /// <summary>
        /// Initializes a new instance of the form check box for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <param name="formGroup">The current form group instance.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="htmlAttributes">A dictionary that contains the HTML attributes to set for the element.</param>
        public YimaFormSwitch(IFormGroup<TModel> formGroup, Expression<Func<TModel, bool>> expression, IDictionary<string, object> htmlAttributes) : base(formGroup, expression, htmlAttributes)
        {
        }

        /// <summary>
        /// Set the label of the switch.
        /// </summary>
        /// <param name="label">The value of the label.</param>
        /// <returns>Current component.</returns>
        public override FormCheckBoxBase Label(string label)
        {
            return base.Label(string.Format("<span class=\"text\">{0}</span>", label));
        }

        /// <summary>
        /// Sets the type of the switch.
        /// </summary>
        /// <param name="type">The value of the switch type.</param>
        /// <returns>Current component.</returns>
        public virtual YimaFormSwitch<TModel> Type(YimaSwitchType type)
        {
            AddCssClass(type.ToString());

            return this;
        }

        /// <summary>
        /// Changes switch to yes/no mode.
        /// </summary>
        /// <returns>Current component.</returns>
        public virtual YimaFormSwitch<TModel> YesNo()
        {
            AddCssClass("yesno");

            return this;
        }

        /// <summary>
        /// Sets the color of the switch.
        /// </summary>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public virtual YimaFormSwitch<TModel> Color(BootstrapColorBase color)
        {
            AddCssClass(string.Format("switch-{0}", color));

            return this;
        }

        /// <summary>
        /// Returns HTML representation of the component.
        /// </summary>
        /// <returns>HTML representation of the component.</returns>
        public override string ToHtmlString()
        {
            AddCssClass("switch");
            NoWrapper();
            Label("");
            return string.Format("<label>{0}</label>", base.ToHtmlString());
        }
    }

    /// <summary>
    /// Represents a switch component.
    /// </summary>
    public class YimaSwitch : CheckBox
    {
        /// <summary>
        /// Returns a check box input element by using the specified HTML helper, the name of the form field, and the HTML attributes.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public YimaSwitch(HtmlHelper htmlHelper, string name, IDictionary<string, object> htmlAttributes) : base(htmlHelper, name, htmlAttributes)
        {
        }

        /// <summary>
        /// Returns a check box input element by using the specified HTML helper, the name of the form field, a value to indicate whether the check box is selected, and the HTML attributes.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="isChecked">true to select the check box; otherwise, false. The value of the check box is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a checked attribute in the HTML attributes.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public YimaSwitch(HtmlHelper htmlHelper, string name, bool isChecked, IDictionary<string, object> htmlAttributes) : base(htmlHelper, name, isChecked, htmlAttributes)
        {
        }

        /// <summary>
        /// Set the label of the switch.
        /// </summary>
        /// <param name="label">The value of the label.</param>
        /// <returns>Current component.</returns>
        public override CheckBoxBase Label(string label)
        {
            return base.Label(string.Format("<span class=\"text\">{0}</span>", label));
        }

        /// <summary>
        /// Sets the type of the switch.
        /// </summary>
        /// <param name="type">The value of the switch type.</param>
        /// <returns>Current component.</returns>
        public virtual YimaSwitch Type(YimaSwitchType type)
        {
            AddCssClass(type.ToString());

            return this;
        }

        /// <summary>
        /// Changes switch to yes/no mode.
        /// </summary>
        /// <returns>Current component.</returns>
        public virtual YimaSwitch YesNo()
        {
            AddCssClass("yesno");

            return this;
        }

        /// <summary>
        /// Sets the color of the switch.
        /// </summary>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public virtual YimaSwitch Color(BootstrapColorBase color)
        {
            AddCssClass(string.Format("switch-{0}", color));

            return this;
        }

        /// <summary>
        /// Returns HTML representation of the component.
        /// </summary>
        /// <returns>HTML representation of the component.</returns>
        public override string ToHtmlString()
        {
            AddCssClass("switch");
            NoWrapper();
            Label("");
            return string.Format("<label>{0}</label>", base.ToHtmlString());
        }
    }

    /// <summary>
    /// Represents the switch type.
    /// </summary>
    public class YimaSwitchType
    {
        private string _name;

        /// <summary>
        /// Default switch type.
        /// </summary>
        public static readonly YimaSwitchType Default = new YimaSwitchType("");

        /// <summary>
        /// Slider switch type.
        /// </summary>
        public static readonly YimaSwitchType Slider = new YimaSwitchType("slider-icon");

        /// <summary>
        /// Toggle switch type.
        /// </summary>
        public static readonly YimaSwitchType Toggle = new YimaSwitchType("toggle");

        private YimaSwitchType(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Returns string representation of switch type.
        /// </summary>
        /// <returns>String representation of switch type.</returns>
        public override string ToString()
        {
            return _name;
        }
    }
}
