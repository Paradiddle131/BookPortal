using System.Linq;
using System.Web.Mvc;

namespace BookPortal.Controllers
{
	public class ReviewsController : Controller
	{
		//private readonly ReviewADO rado = new ReviewADO();
		//private readonly libraryEntities le = new libraryEntities();
		private readonly ReviewBookEntity rb = new ReviewBookEntity();

		//private ReviewContext context = new ReviewContext();

		// GET: Reviews

		public ActionResult Index(string searching)
		{
			//var reviews = from s in le.types
			//			  select s;
			return View(rb.Reviews.Where(x => x.Category.Contains(searching) || searching == null).ToList());
		}

		//public ActionResult Index()
		//      {
		//	//return View(context.Reviews.ToList());
		//	ViewBag.Message = "Review List";

		//	var data = LoadReviews();
		//	List<ReviewModel> reviews = new List<ReviewModel>();
		//	foreach (var row in data)
		//	{
		//		reviews.Add(new ReviewModel
		//		{
		//			Category = row.Category,
		//			BookName = row.BookName,
		//			ReviewType = row.ReviewType,
		//			BookSubject = row.BookSubject,
		//			BookAnalysis = row.BookAnalysis,
		//			AuthorName = row.AuthorName,
		//			OtherBooks = row.OtherBooks
		//		});
		//	}

		//	return View(reviews);
		//}
	}
}