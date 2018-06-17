using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using IssatisLab.Helpers.Bootstrap;
using IssatisLab.Helpers.Bootstrap.Components;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a check box.
    /// </summary>
    public static class CheckBoxExtensions
    {
        /// <summary>
        /// Sets the color for the check box.
        /// </summary>
        /// <param name="checkBox">The check box instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static CheckBoxBase Color(this CheckBoxBase checkBox, BootstrapColorBase color)
        {
            checkBox.AddCssClass(string.Format("checkbox-{0}", color));

            return checkBox;
        }

        /// <summary>
        /// Sets the color for the check box.
        /// </summary>
        /// <param name="formCheckBox">The form check box instance that this method extends.</param>
        /// <param name="color">The value of the color.</param>
        /// <returns>Current component.</returns>
        public static FormCheckBoxBase Color(this FormCheckBoxBase formCheckBox, BootstrapColorBase color)
        {
            formCheckBox.AddCssClass(string.Format("checkbox-{0}", color));

            return formCheckBox;
        }
    }

    public static class YimaCheckBoxExtensions
    {
        /// <summary>
        /// Returns a check box input element for each property in the object that is represented by the specified expression.
        /// </summary>
        /// 
        /// <returns>
        /// An HTML input element whose type attribute is set to "checkbox" for each property in the object that is represented by the specified expression.
        /// </returns>
        /// <param name="form">The IForm instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        public static YimaFormCheckBox<TModel> YimaCheckBoxFor<TModel>(this IForm<TModel> form, Expression<Func<TModel, bool>> expression)
        {
            return form.YimaCheckBoxFor<TModel>(expression, (IDictionary<string, object>)null);
        }

        /// <summary>
        /// Returns a check box input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// An HTML input element whose type attribute is set to "checkbox" for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </returns>
        /// <param name="form">The IForm instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        public static YimaFormCheckBox<TModel> YimaCheckBoxFor<TModel>(this IForm<TModel> form, Expression<Func<TModel, bool>> expression, object htmlAttributes)
        {
            return form.YimaCheckBoxFor<TModel>(expression, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// Returns a check box input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// An HTML input element whose type attribute is set to "checkbox" for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </returns>
        /// <param name="form">The IForm instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="htmlAttributes">A dictionary that contains the HTML attributes to set for the element.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        public static YimaFormCheckBox<TModel> YimaCheckBoxFor<TModel>(this IForm<TModel> form, Expression<Func<TModel, bool>> expression, IDictionary<string, object> htmlAttributes)
        {
            return new YimaFormCheckBox<TModel>(form, expression, htmlAttributes);
        }

        /// <summary>
        /// Returns a check box input element for each property in the object that is represented by the specified expression.
        /// </summary>
        /// 
        /// <returns>
        /// An HTML input element whose type attribute is set to "checkbox" for each property in the object that is represented by the specified expression.
        /// </returns>
        /// <param name="formGroup">The IFormGroup instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        public static YimaFormCheckBox<TModel> YimaCheckBoxFor<TModel>(this IFormGroup<TModel> formGroup, Expression<Func<TModel, bool>> expression)
        {
            return formGroup.YimaCheckBoxFor<TModel>(expression, (IDictionary<string, object>)null);
        }

        /// <summary>
        /// Returns a check box input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// An HTML input element whose type attribute is set to "checkbox" for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </returns>
        /// <param name="formGroup">The IFormGroup instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        public static YimaFormCheckBox<TModel> YimaCheckBoxFor<TModel>(this IFormGroup<TModel> formGroup, Expression<Func<TModel, bool>> expression, object htmlAttributes)
        {
            return formGroup.YimaCheckBoxFor<TModel>(expression, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// Returns a check box input element for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// An HTML input element whose type attribute is set to "checkbox" for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </returns>
        /// <param name="formGroup">The IFormGroup instance that this method extends.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="htmlAttributes">A dictionary that contains the HTML attributes to set for the element.</param>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        public static YimaFormCheckBox<TModel> YimaCheckBoxFor<TModel>(this IFormGroup<TModel> formGroup, Expression<Func<TModel, bool>> expression, IDictionary<string, object> htmlAttributes)
        {
            return new YimaFormCheckBox<TModel>(formGroup, expression, htmlAttributes);
        }

        /// <summary>
        /// Returns a check box input element by using the specified HTML helper and the name of the form field.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "checkbox".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field.</param>
        public static YimaCheckBox YimaCheckBox(this HtmlHelper htmlHelper, string name)
        {
            return htmlHelper.YimaCheckBox(name, (object)null);
        }

        /// <summary>
        /// Returns a check box input element by using the specified HTML helper, the name of the form field, and a value to indicate whether the check box is selected.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "checkbox".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="isChecked">true to select the check box; otherwise, false. The value of the check box is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a checked attribute in the html attributes.</param>
        public static YimaCheckBox YimaCheckBox(this HtmlHelper htmlHelper, string name, bool isChecked)
        {
            return htmlHelper.YimaCheckBox(name, isChecked, (object)null);
        }

        /// <summary>
        /// Returns a check box input element by using the specified HTML helper, the name of the form field, a value that indicates whether the check box is selected, and the HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "checkbox".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="isChecked">true to select the check box; otherwise, false. The value of the check box is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a checked attribute in the html attributes.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public static YimaCheckBox YimaCheckBox(this HtmlHelper htmlHelper, string name, bool isChecked, object htmlAttributes)
        {
            return htmlHelper.YimaCheckBox(name, isChecked, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// Returns a check box input element by using the specified HTML helper, the name of the form field, and the HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "checkbox".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public static YimaCheckBox YimaCheckBox(this HtmlHelper htmlHelper, string name, object htmlAttributes)
        {
            return htmlHelper.YimaCheckBox(name, (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        /// <summary>
        /// Returns a check box input element by using the specified HTML helper, the name of the form field, and the HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "checkbox".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public static YimaCheckBox YimaCheckBox(this HtmlHelper htmlHelper, string name, IDictionary<string, object> htmlAttributes)
        {
            return new YimaCheckBox(htmlHelper, name, htmlAttributes);
        }

        /// <summary>
        /// Returns a check box input element by using the specified HTML helper, the name of the form field, a value to indicate whether the check box is selected, and the HTML attributes.
        /// </summary>
        /// 
        /// <returns>
        /// An input element whose type attribute is set to "checkbox".
        /// </returns>
        /// <param name="htmlHelper">The HTML helper instance that this method extends.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="isChecked">true to select the check box; otherwise, false. The value of the check box is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a checked attribute in the html attributes.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public static YimaCheckBox YimaCheckBox(this HtmlHelper htmlHelper, string name, bool isChecked, IDictionary<string, object> htmlAttributes)
        {
            return new YimaCheckBox(htmlHelper, name, isChecked, htmlAttributes);
        }
    }

    /// <summary>
    /// Represents form check box component
    /// </summary>
    public class YimaFormCheckBox<TModel> : FormCheckBox<TModel>
    {
        /// <summary>
        /// Initializes a new instance of the form check box for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <param name="form">The current form instance.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="htmlAttributes">A dictionary that contains the HTML attributes to set for the element.</param>
        public YimaFormCheckBox(IForm<TModel> form, Expression<Func<TModel, bool>> expression, IDictionary<string, object> htmlAttributes) : base(form, expression, htmlAttributes)
        {
        }

        /// <summary>
        /// Initializes a new instance of the form check box for each property in the object that is represented by the specified expression, using the specified HTML attributes.
        /// </summary>
        /// 
        /// <param name="formGroup">The current form group instance.</param>
        /// <param name="expression">An expression that identifies the object that contains the properties to render.</param>
        /// <param name="htmlAttributes">A dictionary that contains the HTML attributes to set for the element.</param>
        public YimaFormCheckBox(IFormGroup<TModel> formGroup, Expression<Func<TModel, bool>> expression, IDictionary<string, object> htmlAttributes) : base(formGroup, expression, htmlAttributes)
        {
        }

        /// <summary>
        /// Returns HTML representation of the component.
        /// </summary>
        /// <returns>HTML representation of the component.</returns>
        public override string ToHtmlString()
        {
            var html =  base.ToHtmlString();
            var regex = new Regex("(.*<input.*?>)(.+?)(</label>.*)");
            var match = regex.Match(html);
            return string.Format("{0}<span class=\"text\">{1}</span>{2}", match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value);
        }
    }

    /// <summary>
    /// Represents check box component
    /// </summary>
    public class YimaCheckBox : CheckBox
    {
        /// <summary>
        /// Returns a check box input element by using the specified HTML helper, the name of the form field, and the HTML attributes.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public YimaCheckBox(HtmlHelper htmlHelper, string name, IDictionary<string, object> htmlAttributes) : base(htmlHelper, name, htmlAttributes)
        {
        }

        /// <summary>
        /// Returns a check box input element by using the specified HTML helper, the name of the form field, a value to indicate whether the check box is selected, and the HTML attributes.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="name">The name of the form field.</param>
        /// <param name="isChecked">true to select the check box; otherwise, false. The value of the check box is retrieved in this order - the <see cref="T:System.Web.Mvc.ModelStateDictionary"/> object, the value of this parameter, the <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object, and lastly, a checked attribute in the HTML attributes.</param>
        /// <param name="htmlAttributes">An object that contains the HTML attributes to set for the element.</param>
        public YimaCheckBox(HtmlHelper htmlHelper, string name, bool isChecked, IDictionary<string, object> htmlAttributes) : base(htmlHelper, name, isChecked, htmlAttributes)
        {
        }

        /// <summary>
        /// Returns HTML representation of the component.
        /// </summary>
        /// <returns>HTML representation of the component.</returns>
        public override string ToHtmlString()
        {
            var html = base.ToHtmlString();
            var regex = new Regex("(.*<input.*?>)(.+?)(</label>.*)");
            var match = regex.Match(html);
            return string.Format("{0}<span class=\"text\">{1}</span>{2}", match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value);
        }
    }
}
