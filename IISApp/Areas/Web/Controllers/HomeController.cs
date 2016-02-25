using System.Web.Mvc;

namespace IISApp.Areas.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View("Home");
		}
	}
}
