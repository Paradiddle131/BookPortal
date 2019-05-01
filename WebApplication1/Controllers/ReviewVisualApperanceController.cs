using System.Linq;
using System.Web.Mvc;
using BookPortal.Models;


namespace BookPortal.Controllers
{
    public class ReviewVisualApperanceController : Controller
    {
        private ReviewsContext context = new ReviewsContext();

        public ActionResult Index()
        {
            return View(context.Reviews.ToList());
        }
        public ActionResult NewestBook()
        {
            return View(context.Reviews.ToList());
        }
        public ActionResult PopularBook()
        {
            return View(context.Reviews.ToList());
        }
        public ActionResult OldestBook()
        {
            return View(context.Reviews.ToList());
        }
    }
}