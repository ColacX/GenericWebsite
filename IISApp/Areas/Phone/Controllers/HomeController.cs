using System.Web.Mvc;

namespace IISApp.Areas.Phone.Controllers
{
	public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Home");
        }

		public ActionResult Test1()
		{
			return View("Test1");
		}

		public ActionResult Test2()
		{
			return View("Test2");
		}

		public ActionResult News()
		{
			return View("News");
		}

		public ActionResult Gallery()
		{
			return View("Gallery");
		}
	}
}
