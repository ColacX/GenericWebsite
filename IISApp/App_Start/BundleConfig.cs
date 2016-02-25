using System.Configuration;
using System.Web.Optimization;

public class BundleConfig
{
	// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
	public static void RegisterBundles(BundleCollection bundles)
	{
		//styles----------------------------------------------------
		bundles.Add(new StyleBundle("~/bundle/scripts/bootstrap").Include(
			"~/Content/bootstrap-theme.css",
			"~/Content/bootstrap-theme.css.map",
			"~/Content/bootstrap-theme.min.css",
			"~/Content/bootstrap-theme.min.css.map",
			"~/Content/bootstrap.css",
			"~/Content/bootstrap.css.map",
			"~/Content/bootstrap.min.css",
			"~/Content/bootstrap.min.css.map",
			"~/Content/ui-bootstrap-csp.css"
		));

		bundles.Add(new StyleBundle("~/bundle/styles/phone").Include(
			"~/Content/Phone/*.css"
		));

		//scripts---------------------------------------------------
		bundles.Add(new ScriptBundle("~/bundle/scripts/angular").Include(
			"~/Scripts/angular.js",
			"~/Scripts/angular.min.js"
			//"~/Scripts/angular.min.js.map"
		));

		bundles.Add(new ScriptBundle("~/bundle/scripts/test").Include(
			"~/Scripts/Test/*.js"
		));

		bundles.Add(new ScriptBundle("~/bundle/scripts/site").Include(
			"~/Scripts/Site/*.js"
		));

		bundles.Add(new ScriptBundle("~/bundle/scripts/phone")
		.IncludeDirectory(
			"~/Scripts/Phone", "*.js", true
		));

		bundles.Add(new ScriptBundle("~/bundle/scripts/web")
		.IncludeDirectory(
			"~/Areas/Web/Views", "*.js", true
		));

		//.min files are automatically used in bundles when optimizations are enabled
		//.map files are useful for debugging in production, thus they should be included in the bundles
		BundleTable.EnableOptimizations = ConfigurationManager.AppSettings["DevMode"] != "true";
	}
}
