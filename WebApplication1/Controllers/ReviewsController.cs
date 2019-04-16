using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookPortal.Models;

namespace BookPortal.Controllers
{
    public class ReviewsController : Controller
    {

        private ReviewContext context = new ReviewContext();

        // GET: Reviews
        public ActionResult Index()
        {
            return View(context.Reviews.ToList());
        }
    }
}