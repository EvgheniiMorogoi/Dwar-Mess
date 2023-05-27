using System.Web;
using System.Web.Optimization;

namespace FlowerShop
{
     public class BundleConfig
     {
          // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
          public static void RegisterBundles(BundleCollection bundles)
          {
               bundles.Add(new ScriptBundle("~/bundles/jquery").Include( //edited
                           "~/Scripts/js/jquery.min.js",
                           "~/Scripts/js/jquery.easing.1.3.js",
                           "~/Scripts/js/jquery.min.js",
                           "~/Scripts/js/jquery.stellar.min.js",
                           "~/Scripts/js/jquery.waypoints.min.js",
                           "~/Scripts/js/owl.carousel.min.js",
                           "~/Scripts/js/respond.min.js",
                           "~/Scripts/js/google_map.js"
                           ));

               bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                           "~/Scripts/js/jquery.validate*"));

               // Use the development version of Modernizr to develop with and learn from. Then, when you're
               // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
               bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                           "~/Scripts/js/modernizr-2.6.2.min.js"));

               bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                         "~/Scripts/js/bootstrap.js")); //edited

               bundles.Add(new StyleBundle("~/Content/css").Include(
                         "~/Content/css/bootstrap.css", //edited
                         "~/Content/site.css"));

               //added new 
               bundles.Add(new Bundle("~/bundles/js").Include(
                         "~/Scripts/js/main.js",
                         "~/Scripts/js/respond.min.js"));
               bundles.Add(new StyleBundle("~/Content/template").Include(
                    "~/Content/css/style.css",
                    "~/Content/css/animate.css",
                    "~/Content/css/icomoon.css",
                    "~/Content/css/owl.carousel.min.css",
                    "~/Content/css/owl.theme.default.min.css",
                    "~/Content/fonts/bootstrap",
                    "~/Content/fonts/icomoon"));
          }
     }
}
