using System.Web.Mvc;

namespace BookPortal.Controllers
{
	public class HomeController : Controller
	{



		// GET: Home
		public ActionResult Index()
		{
			return View();
		}
		//public ActionResult AddReview()
		//{
		//	return View();
		//}
		//public ActionResult Contact()
		//{
		//	ViewBag.Message = "Your contact page.";

		//	return View();
		//}
		//public ActionResult Review()
		//{
		//	ViewBag.Message = "Your review page.";

		//	return View();
		//}
	}
}