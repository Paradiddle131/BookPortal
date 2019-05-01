﻿using BookPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookPortal.Controllers
{
    public class ContentController : Controller
    {
        private ReviewsContext context = new ReviewsContext();

        // GET: Content
        public ActionResult Index()
        {
            return View(context.Reviews.ToList());
        }
        public ActionResult review_id_1()
        {
            var contents = context.Reviews.Where(i => i.ReviewId == 1);
            return View(contents.ToList());
        }
        public ActionResult review_id_2()
        {
            var contents = context.Reviews.Where(i => i.ReviewId == 2);
            return View(contents.ToList());
        }
        public ActionResult review_id_3()
        {
            var contents = context.Reviews.Where(i => i.ReviewId == 3);
            return View(contents.ToList());
        }
        public ActionResult review_id_4()
        {
            var contents = context.Reviews.Where(i => i.ReviewId == 4);
            return View(contents.ToList());
        }
        public ActionResult review_id_5()
        {
            var contents = context.Reviews.Where(i => i.ReviewId == 5);
            return View(contents.ToList());
        }
        public ActionResult review_id_6()
        {
            var contents = context.Reviews.Where(i => i.ReviewId == 6);
            return View(contents.ToList());
        }
        public ActionResult review_id_7()
        {
            var contents = context.Reviews.Where(i => i.ReviewId == 7);
            return View(contents.ToList());
        }
        public ActionResult review_id_8()
        {
            var contents = context.Reviews.Where(i => i.ReviewId == 8);
            return View(contents.ToList());
        }
        public ActionResult review_id_9()
        {
            var contents = context.Reviews.Where(i => i.ReviewId == 9);
            return View(contents.ToList());
        }
    }
}