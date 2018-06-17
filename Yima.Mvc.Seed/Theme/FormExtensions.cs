using System;
using IssatisLab.Helpers.Bootstrap;

namespace IssatisLab.Yima.Mvc.Seed.Theme
{
    /// <summary>
    /// Represents support for adding a form.
    /// </summary>
    public static class FormExtensions
    {
        /// <summary>
        /// Adds border to the form.
        /// </summary>
        /// <param name="form">The form instance that this method extends.</param>
        /// <returns>Current component.</returns>
        public static Form<TModel> Border<TModel>(this Form<TModel> form)
        {
            form.AddCssClass("form-bordered");

            return form;
        }
    }
}
