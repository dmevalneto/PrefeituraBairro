using System;
using System.Web.Mvc;

namespace IssatisLab.Yima.Mvc.Seed
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
