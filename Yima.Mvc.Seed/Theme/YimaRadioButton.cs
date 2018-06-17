using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using IssatisLab.Helpers.Bootstrap;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a radio button.
    /// </summary>
    public static class RadioButtonExtensions
    {
        /// <summary>
        /// Sets the color for the radio button.
        /// </summary>
        /// <param name="radioButton">The radio button instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static RadioButtonBase Color(this RadioButtonBase radioButton, BootstrapColorBase color)
        {
            radioButton.AddCssClass(string.Format("radio-{0}", color));

            return radioButton;
        }

        /// <summary>
        /// Sets the color for the radio button.
        /// </summary>
        /// <param name="formRadioButton">The form radio button instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static FormRadioButtonBase Color(this FormRadioButtonBase formRadioButton, BootstrapColorBase color)
        {
            formRadioButton.AddCssClass(string.Format("radio-{0}", color));

            return formRadioButton;
        }
    }

    /// <summary>
    /// Represents support for adding a radio button.
    /// </summary>
    public static class YimaRadioButtonExtensions
    {
        /// <summary>
        /// Returns a radio button input element for each property in the object that is represented by the specified expression.
        /// </summary>
        /// 
        /// <returns>
        /// An HTML input element whose type attribute is set to "radio" for each property in the object that is represented by the specified expression.
        /// </returns>
        /// <param name="form">The IForm instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the value.</typeparam>
        public static YimaFormRadioButton<TModel, TProperty> YimaRadioButtonFor<TModel, TProperty>(this IForm<TModel> form, Expression<Func<TModel, TProperty>> expression, object value)
        {
            return form.YimaRadioButtonFor<TModel, TProperty>(expression, value, (IDictionary<string, object>)null);
        }

        /// <summary>
        /// Returns a radio button input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// An HTML input element whose type attribute is set to "radio" for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </returns>
        /// <param name="form">The IForm instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the value.</typeparam>
        public static YimaFormRadioButton<TModel, TProperty> YimaRadioButtonFor<TModel, TProperty>(this IForm<TModel> form, Expression<Func<TModel, TProperty>> expression, object value, object htmlAttributes)
        {
            return form.YimaRadioButtonFor<TModel, TProperty>(expression, value, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// Returns a radio button input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// An HTML input element whose type attribute is set to "radio" for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </returns>
        /// <param name="form">The IForm instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <param name="htmlAttributes">A dictionary that contains the HTML attributes to set for the element.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the value.</typeparam>
        public static YimaFormRadioButton<TModel, TProperty> YimaRadioButtonFor<TModel, TProperty>(this IForm<TModel> form, Expression<Func<TModel, TProperty>> expression, object value, IDictionary<string, object> htmlAttributes)
        {
            return new YimaFormRadioButton<TModel, TProperty>(form, expression, value, htmlAttributes);
        }

        /// <summary>
        /// Returns a radio button input element for each property in the object that is represented by the specified expression.
        /// </summary>
        /// 
        /// <returns>
        /// An HTML input element whose type attribute is set to "radio" for each property in the object that is represented by the specified expression.
        /// </returns>
        /// <param name="formGroup">The IFormGroup instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the value.</typeparam>
        public static YimaFormRadioButton<TModel, TProperty> YimaRadioButtonFor<TModel, TProperty>(this IFormGroup<TModel> formGroup, Expression<Func<TModel, TProperty>> expression, object value)
        {
            return formGroup.YimaRadioButtonFor<TModel, TProperty>(expression, value, (IDictionary<string, object>)null);
        }

        /// <summary>
        /// Returns a radio button input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// An HTML input element whose type attribute is set to "radio" for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </returns>
        /// <param name="formGroup">The IFormGroup instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the value.</typeparam>
        public static YimaFormRadioButton<TModel, TProperty> YimaRadioButtonFor<TModel, TProperty>(this IFormGroup<TModel> formGroup, Expression<Func<TModel, TProperty>> expression, object value, object htmlAttributes)
        {
            return formGroup.YimaRadioButtonFor<TModel, TProperty>(expression, value, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// Returns a radio button input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// An HTML input element whose type attribute is set to "radio" for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </returns>
        /// <param name="formGroup">The IFormGroup instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <param name="htmlAttributes">A dictionary that contains the HTML attributes to set for the element.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the value.</typeparam>
        public static YimaFormRadioButton<TModel, TProperty> YimaRadioButtonFor<TModel, TProperty>(this IFormGroup<TModel> formGroup, Expression<Func<TModel, TProperty>> expression, object value, IDictionary<string, object> htmlAttributes)
        {
            return new YimaFormRadioButton<TModel, TProperty>(formGroup, expression, value, htmlAttributes);
        }

        /// <summary>
        /// Returns a radio button input element that is used to present mutually exclusive options.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "radio".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field and the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> key that is used to look up the value.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        public static YimaRadioButton YimaRadioButton(this HtmlHelper htmlHelper, string name, object value)
        {
            return htmlHelper.YimaRadioButton(name, value, (object)null);
        }

        /// <summary>
        /// Returns a radio button input element that is used to present mutually exclusive options.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "radio".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field and the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> key that is used to look up the value.</param><param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public static YimaRadioButton YimaRadioButton(this HtmlHelper htmlHelper, string name, object value, object htmlAttributes)
        {
            return htmlHelper.YimaRadioButton(name, value, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// Returns a radio button input element that is used to present mutually exclusive options.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "radio".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field and the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> key that is used to look up the value.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public static YimaRadioButton YimaRadioButton(this HtmlHelper htmlHelper, string name, object value, IDictionary<string, object> htmlAttributes)
        {
            return new YimaRadioButton(htmlHelper, name, value, htmlAttributes);
        }

        /// <summary>
        /// Returns a radio button input element that is used to present mutually exclusive options.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "radio".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field and the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> key that is used to look up the value.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <param name="isChecked">true to select the radio button; otherwise, false.</param>
        public static YimaRadioButton YimaRadioButton(this HtmlHelper htmlHelper, string name, object value, bool isChecked)
        {
            return htmlHelper.YimaRadioButton(name, value, isChecked, (object)null);
        }

        /// <summary>
        /// Returns a radio button input element that is used to present mutually exclusive options.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "radio".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field and the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> key that is used to look up the value.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <param name="isChecked">true to select the radio button; otherwise, false.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public static YimaRadioButton YimaRadioButton(this HtmlHelper htmlHelper, string name, object value, bool isChecked, object htmlAttributes)
        {
            return htmlHelper.YimaRadioButton(name, value, isChecked, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// Returns a radio button input element that is used to present mutually exclusive options.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "radio".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field and the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> key that is used to look up the value.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <param name="isChecked">true to select the radio button; otherwise, false.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public static YimaRadioButton YimaRadioButton(this HtmlHelper htmlHelper, string name, object value, bool isChecked, IDictionary<string, object> htmlAttributes)
        {
            return new YimaRadioButton(htmlHelper, name, value, isChecked, htmlAttributes);
        }
    }

    /// <summary>
    /// Represents a form radio button component.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    /// <typeparam name="TProperty">The type of the property.</typeparam>
    public class YimaFormRadioButton<TModel, TProperty> : FormRadioButton<TModel, TProperty>
    {
        /// <summary>
        /// Initializes a new instance of form radio button for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <param name="form">The current form instance.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the HTML attributes.</param>
        /// <param name="htmlAttributes">A dictionary that contains the HTML attributes to set for the element.</param>
        public YimaFormRadioButton(IForm<TModel> form, Expression<Func<TModel, TProperty>> expression, object value, IDictionary<string, object> htmlAttributes) : base(form, expression, value, htmlAttributes)
        {
        }

        /// <summary>
        /// Initializes a new instance of form radio button for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <param name="formGroup">The current form group instance.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the HTML attributes.</param>
        /// <param name="htmlAttributes">A dictionary that contains the HTML attributes to set for the element.</param>
        public YimaFormRadioButton(IFormGroup<TModel> formGroup, Expression<Func<TModel, TProperty>> expression, object value, IDictionary<string, object> htmlAttributes) : base(formGroup, expression, value, htmlAttributes)
        {
        }

        /// <summary>
        /// Sets the value of the label.
        /// </summary>
        /// <param name="label">The value of the label.</param>
        /// <returns>Current component.</returns>
        public override FormRadioButtonBase Label(string label)
        {
            return base.Label(string.Format("<span class=\"text\">{0}</span>", label));
        }
    }

    /// <summary>
    /// Represents radio button component.
    /// </summary>
    public class YimaRadioButton : RadioButton
    {
        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper, name, value and HTML attributes.
        /// </summary>
        /// 
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field and the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> key that is used to look up the value.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public YimaRadioButton(HtmlHelper htmlHelper, string name, object value, IDictionary<string, object> htmlAttributes) : base(htmlHelper, name, value, htmlAttributes)
        {
        }

        /// <summary>
        /// Initializes a new instance of the component with the specified HTML helper, name, value, whether its checked or not and HTML attributes.
        /// </summary>
        /// 
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="name">The name of the form field and the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> key that is used to look up the value.</param>
        /// <param name="value">The value of the selected radio button. The value is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a value attribute in the html attributes.</param>
        /// <param name="isChecked">true to select the radio button; otherwise, false.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public YimaRadioButton(HtmlHelper htmlHelper, string name, object value, bool isChecked, IDictionary<string, object> htmlAttributes) : base(htmlHelper, name, value, isChecked, htmlAttributes)
        {
        }

        /// <summary>
        /// Sets the value of the label.
        /// </summary>
        /// <param name="label">The value of the label.</param>
        /// <returns>Current component.</returns>
        public override RadioButtonBase Label(string label)
        {
            return base.Label(string.Format("<span class=\"text\">{0}</span>", label));
        }
    }
}
