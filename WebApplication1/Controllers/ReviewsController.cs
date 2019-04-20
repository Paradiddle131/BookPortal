using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookPortal.Models;
using DataLibrary;
using static DataLibrary.BusinessLogic.ReviewProcessor;
using DataLibrary.ModelsD;

namespace BookPortal.Controllers
{
    public class ReviewsController : Controller
    {

        //private ReviewContext context = new ReviewContext();

        // GET: Reviews
        public ActionResult Index()
        {
			//return View(context.Reviews.ToList());
			ViewBag.Message = "Review List";

			var data = LoadReviews();
			List<ReviewModel> reviews = new List<ReviewModel>();
			foreach (var row in data)
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

			return View(reviews);
		}
    }
}