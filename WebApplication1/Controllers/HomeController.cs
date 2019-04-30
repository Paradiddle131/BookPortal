using BookPortal.Models;
using System.Linq;
using System.Web.Mvc;

namespace BookPortal.Controllers
{
	public class HomeController : Controller
	{
		private readonly RevDBEntities db = new RevDBEntities();

		private readonly ReviewContext _db;
		public HomeController(ReviewContext db)
		{
			_db = db;
		}
		public HomeController()
		{
		}
		//private readonly RevDBEntities db = new RevDBEntities();
		// GET: Home
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult TopReviews()
		{
			return View(db.Reviews.ToList());
		}
		public ActionResult LastFiveReviews(int? id)
		{
			return View(db.Reviews.ToList());
		}
		public ReviewDTO GetFirstFiveReviews(int? id)
		{
			return db.Reviews.Include("Review").Select(t => new ReviewDTO
			{
				ReviewId = t.ReviewId,
				Category = t.Category,
				BookName = t.BookName,
				ReviewType = t.ReviewType,
				BookSubject = t.BookSubject,
				BookAnalysis = t.BookAnalysis,
				AuthorName = t.AuthorName,
				OtherBooks = t.OtherBooks
				//}).Where(c => c.ReviewId < 5).ToList()[0];
			}).Where(c => c.ReviewId == id).ToList()[0];
		}
		//public ActionResult FirstFiveReviews(int? id)
		//{
		//	ReviewDTO review = GetFirstFiveReviews(id);
		//	return View(review);
		//}

		public ActionResult FirstFiveReviews()
		{
			return View(db.Reviews.ToList());
		}

		//public Review GetCategoryScienceFiction(string category)
		//{
		//	return db.Reviews.Include("Review").Select(t => new Review
		//	{
		//		ReviewId = t.ReviewId,
		//		Category = t.Category,
		//		BookName = t.BookName,
		//		ReviewType = t.ReviewType,
		//		BookSubject = t.BookSubject,
		//		BookAnalysis = t.BookAnalysis,
		//		AuthorName = t.AuthorName,
		//		OtherBooks = t.OtherBooks
		//	}).Where(c => c.Category == category).ToList()[0];
		//}
		//public ActionResult CategoryScienceFiction(string category)
		//{
		//	Review review = GetCategoryScienceFiction(category);
		//	return View(review);
		//}
		public ActionResult CategoryScienceFiction()
		{
			return View(db.Reviews.ToList());
		}
		public ActionResult CategoryGuide()
		{
			return View(db.Reviews.ToList());
		}
		public ActionResult CategoryDiaries()
		{
			return View(db.Reviews.ToList());
		}
		public ActionResult CategoryJournals()
		{
			return View(db.Reviews.ToList());
		}
		public ActionResult CategoryDrama()
		{
			return View(db.Reviews.ToList());
		}
		public ActionResult CategoryArt()
		{
			return View(db.Reviews.ToList());
		}


		/*
		public ActionResult TopReviews()
		{
			ViewBag.Message = "Top Reviews";

			public List<Review> data = GetReviews()
			{
				var v = from a in db.Reviews where
			}
			List<Review> reviews = new List<Review>();
			foreach (Review row in data)
			{
				reviews.Add(new Review
				{
					ReviewId = row.ReviewId,
					Category = row.Category,
					BookName = row.BookName,
					BookSubject = row.ReviewType,
					BookAnalysis = row.BookAnalysis,
					AuthorName = row.AuthorName,
					OtherBooks = row.OtherBooks
				});
			}

			return View(reviews);
		}
		*/
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