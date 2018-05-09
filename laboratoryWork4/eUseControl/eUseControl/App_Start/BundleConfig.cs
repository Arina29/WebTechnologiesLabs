using System.Web;
using System.Web.Optimization;

namespace eUseControl
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            BundleTable.EnableOptimizations = true;
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                      "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/main/css").Include(
                      "~/Content/main.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/navbar/css").Include(
                      "~/Content/navbar.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/scripts").IncludeDirectory("~/Scripts/", "*.js", true));


        }
    }
}
