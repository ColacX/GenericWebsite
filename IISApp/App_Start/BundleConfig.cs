using System.Configuration;
using System.Web.Optimization;

public class BundleConfig
{
	// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
	public static void RegisterBundles(BundleCollection bundles)
	{
		//styles----------------------------------------------------
		bundles.Add(new StyleBundle("~/bundle/styles/bootstrap").Include(
			"~/Content/bootstrap-theme.css",
			//"~/Content/bootstrap-theme.css.map",
			"~/Content/bootstrap-theme.min.css",
			//"~/Content/bootstrap-theme.min.css.map",
			"~/Content/bootstrap.css",
			//"~/Content/bootstrap.css.map",
			"~/Content/bootstrap.min.css",
			//"~/Content/bootstrap.min.css.map",
			"~/Content/ui-bootstrap-csp.css"
		));

		bundles.Add(new StyleBundle("~/bundle/styles/phone").Include(
			"~/Content/Phone/*.css"
		));

		//scripts---------------------------------------------------
		bundles.Add(new ScriptBundle("~/bundle/scripts/angular").Include(
			"~/Scripts/modernizr-{version}.js",
			"~/Scripts/jquery-{version}.js",

			"~/Scripts/angular.js",
			"~/Scripts/angular.min.js",
			//"~/Scripts/angular.min.js.map",

			"~/Scripts/angular-route.js",
			"~/Scripts/angular-route.min.js",
			//"~/Scripts/angular-route.min.js.map",

			"~/Scripts/angular-animate.js",
			"~/Scripts/angular-animate.min.js",
			//"~/Scripts/angular-animate.min.js.map",

			"~/Scripts/angular-touch.js",
			"~/Scripts/angular-touch.min.js",
			//"~/Scripts/angular-touch.min.js.map",

			"~/Scripts/angular-ui-router.js",
			"~/Scripts/angular-ui-router.min.js"
		));

		bundles.Add(new ScriptBundle("~/bundle/scripts/bootstrap").Include(
			"~/Scripts/bootstrap.js",
			"~/Scripts/bootstrap.min.js",

			"~/Scripts/angular-ui/ui-bootstrap.js",
			"~/Scripts/angular-ui/ui-bootstrap.min.js",
			"~/Scripts/angular-ui/ui-bootstrap-tpls.js",
			"~/Scripts/angular-ui/ui-bootstrap-tpls.min.js"
		));

		bundles.Add(new ScriptBundle("~/bundle/scripts/test")
		.IncludeDirectory(
			"~/Scripts/Test", "*.js", true
		));

		bundles.Add(new ScriptBundle("~/bundle/scripts/site")
		.IncludeDirectory(
			"~/Scripts/Site", "*.js", true
		));

		bundles.Add(new ScriptBundle("~/bundle/scripts/phone")
		.IncludeDirectory(
			"~/Scripts/Phone", "*.js", true
		));

		bundles.Add(new ScriptBundle("~/bundle/scripts/web")
		.IncludeDirectory(
			"~/Scripts/Web", "*.js", true
		));

		//.min files are automatically used in bundles when optimizations are enabled
		//.map files are useful for debugging in production, thus they should be included in the bundles
		BundleTable.EnableOptimizations = ConfigurationManager.AppSettings["DevMode"] != "true";
	}
}
