using DataLibrary.ModelsD;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BookPortal.Controllers
{
	public class ReviewsController : Controller
	{
		private readonly RevDBEntities rb = new RevDBEntities();

		// GET: Reviews

		public ActionResult Index(string searching)
		{
			ViewBag.Message = "Review List";

			List<ReviewModel> data = DataLibrary.BusinessLogic.ReviewProcessor.LoadReviews();
			List<ReviewModel> reviews = new List<ReviewModel>();
			foreach (ReviewModel row in data)
			{
				reviews.Add(new ReviewModel
				{
					Category = row.Category,
					BookName = row.BookName,
					ReviewType = row.ReviewType,
					BookSubject = row.BookSubject,
					BookAnalysis = row.BookAnalysis,
					AuthorName = row.AuthorName,
					OtherBooks = row.OtherBooks
				});
			}
			//return View(rb.Reviews.Where);
			return View(rb.Reviews.Where(x => x.AuthorName.Contains(searching) || searching == null).ToList());
			//return View(reviews);



		}

		//public ActionResult Index()
		//{
		//return View(context.Reviews.ToList());
		//ViewBag.Message = "Review List";

		//List<ReviewModel> data = DataLibrary.BusinessLogic.ReviewProcessor.LoadReviews();
		//List<ReviewModel> reviews = new List<ReviewModel>();
		//foreach (ReviewModel row in data)
		//{
		//	reviews.Add(new ReviewModel
		//	{
		//		Category = row.Category,
		//		BookName = row.BookName,
		//		ReviewType = row.ReviewType,
		//		BookSubject = row.BookSubject,
		//		BookAnalysis = row.BookAnalysis,
		//		AuthorName = row.AuthorName,
		//		OtherBooks = row.OtherBooks
		//	});
		//}

		//return View(reviews);
		//}
	}
}