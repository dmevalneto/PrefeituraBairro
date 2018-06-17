using System;
using System.Web.Optimization;

namespace IssatisLab.Yima.Mvc.Seed
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                       "~/assets/js/methods_pt.js"));
        }
    }
}
