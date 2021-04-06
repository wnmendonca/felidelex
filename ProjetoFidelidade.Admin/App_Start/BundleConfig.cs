using System.Web.Optimization;

namespace ProjetoFidelidade.Admin.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bootstrap/js").Include("~/Js/bootstrap.js", "~/Js/site.js"));
            bundles.Add(new StyleBundle("~/bootstrap/css").Include("~/Css/bootstrap.css", "~/Css/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}