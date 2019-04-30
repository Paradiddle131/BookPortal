using BookPortal.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Web.Mvc;

namespace BookPortal.Controllers
{
	public class ReviewController : Controller
	{
		private readonly RevDBEntities db = new RevDBEntities();

		// GET: Review
		[HttpGet]
		public ActionResult Index()
		{
			ViewBag.BookName = "";
			ViewBag.AuthorName = "";
			ViewBag.Category = "";
			IQueryable<Review> reviews = db.Reviews.Include(a => a.AuthorName);
			return View(db.Reviews.ToList());
			//return View(reviews.ToList());
		}

		[HttpGet]
		public ActionResult SearchIndex(int page = 1, string sort = "BookName", string sortdir = "asc", string search = "")
		{
			int pageSize = 10;
			if (page < 1)
			{
				page = 1;
			}

			int skip = (page * pageSize) - pageSize;
			List<Review> data = GetReviews(search, sort, sortdir, skip, pageSize, out int totalRecord);
			ViewBag.TotalRows = totalRecord;
			return View(data);
		}


		[HttpPost]
		public ActionResult Index(string bookName, string authorName, string category, Review rev)
		{
			IEnumerable<Review> reviews = db.Reviews.ToList().Where(r => r.BookName.StartsWith(bookName) && r.AuthorName.StartsWith(authorName) && r.Category.StartsWith(category));
			return View(reviews);
		}

		public List<Review> GetReviews(string search, string sort, string sortdir, int skip, int pageSize, out int totalRecord)
		{
			IQueryable<Review> v = (from a in db.Reviews
									where
									   a.BookName.Contains(search) ||
									   a.AuthorName.Contains(search) ||
									   a.Category.Contains(search)
									select a
					 );
			totalRecord = v.Count();
			v = v.OrderBy(sort + " " + sortdir);
			if (pageSize > 0)
			{
				v = v.Skip(skip).Take(pageSize);
			}
			return v.ToList();
		}


		// GET: Review/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Review review = db.Reviews.Find(id);
			if (review == null)
			{
				return HttpNotFound();
			}
			return View(review);
		}

		// GET: Review/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Review/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "ReviewId,Category,BookName,ReviewType,BookSubject,BookAnalysis,AuthorName,OtherBooks,DateCreated")] Review review)
		{
			if (ModelState.IsValid)
			{
				db.Reviews.Add(review);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(review);
		}

		// GET: Review/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Review review = db.Reviews.Find(id);
			if (review == null)
			{
				return HttpNotFound();
			}
			return View(review);
		}

		// POST: Review/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "ReviewId,Category,BookName,ReviewType,BookSubject,BookAnalysis,AuthorName,OtherBooks,DateCreated")] Review review)
		{
			if (ModelState.IsValid)
			{
				db.Entry(review).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(review);
		}

		// GET: Review/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Review review = db.Reviews.Find(id);
			if (review == null)
			{
				return HttpNotFound();
			}
			return View(review);
		}

		// POST: Review/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			Review review = db.Reviews.Find(id);
			db.Reviews.Remove(review);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
