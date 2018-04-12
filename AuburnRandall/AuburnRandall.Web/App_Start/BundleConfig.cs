using System.Web;
using System.Web.Optimization;

namespace AuburnRandall.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/AngularStyles")
                .Include("~/node_modules/angular-material/angular-material.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/AngularJS")
                .Include("~/node_modules/angular/angular.js")
                .Include("~/node_modules/angular-material/angular-material.js")
                .Include("~/node_modules/angular-animate/angular-animate.js")
                .Include("~/node_modules/angular-aria/angular-aria.js")
                );

            bundles.Add(new StyleBundle("~/bundles/MainApplicationStyles")
                .Include("~/css/styles.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/MainApplicationJs")
                .IncludeDirectory("~/src/mainApp", "*.js", true)
                );
        }
    }
}
