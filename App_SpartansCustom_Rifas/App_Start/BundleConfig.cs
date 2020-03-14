using System.Web;
using System.Web.Optimization;

namespace App_SpartansCustom_Rifas
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //BUNDLE LEXA RESPONSIVE
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery.min.js",
                    "~/Scripts/bootstrap.bundle.min.js",
                    "~/Scripts/jquery.slimscroll.js",
                    "~/Scripts/waves.min.js",
                    "~/plugins/jquery-sparkline/jquery.sparkline.min.js",
                    "~/Scripts/app.js"));

            //BUNDLE JQUERY VALIDATE
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"));

            //BUNDLE CSS STYLES
            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/css/bootstrap.min.css",
                    "~/Content/css/icons.css",
                    "~/Content/css/style.css",
                    "~/Content/scss/style.css"));

            //HABILITAR LA MANIFICACIÓN
            BundleTable.EnableOptimizations = false;

            //VALIDAR SI ESTA EN DEBUG PARA NO MANIFICAR
            #if (DEBUG)
                BundleTable.EnableOptimizations = false;
            #endif
        }
    }
}
