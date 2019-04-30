using System.Web.Mvc;


namespace BookPortal.Controllers
{
	public class AddReviewController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Add Review.";

			return View();
		}
		// GET: AddReview
		[HttpPost]
		[ValidateAntiForgeryToken]

		public ActionResult Index(ReviewController model)
		{
			if (ModelState.IsValid)
			{
				//ReviewProcessor.CreateReview()
				int recordsCreated = CreateReview(model.Category, model.BookName, model.ReviewType, model.BookSubject, model.BookAnalysis, model.AuthorName, model.OtherBooks);
				return RedirectToAction("Index");
			}
			ViewBag.Message = "Add Review.";

			return View();
		}
	}
}