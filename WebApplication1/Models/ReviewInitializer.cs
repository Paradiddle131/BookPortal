using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookPortal.Models
{
    public class ReviewInitializer : DropCreateDatabaseIfModelChanges<ReviewContext>
    {
        protected override void Seed(ReviewContext context)
        {
            List<Categories> categories = new List<Categories>()
            {
                new Categories(){CategoryName="Fear"},
                new Categories(){CategoryName="Adventure"}
            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();

            List<Review> reviews = new List<Review>()
            {
                new Review() { BookName="Jules Verne" , BookSubject="life of jules verne", BookWriter="seyfettin", BookAnalysis="güzel", OtherBooks="kasagı", ReviewType="general", AddingDate=DateTime.Now.AddDays(-10), MainPage=true, Confirmation=true, CategoryId=1 },
                new Review() { BookName="sol ayağım" , BookSubject="life of jules verne", BookWriter="raci", BookAnalysis="kötü", OtherBooks="kasagı", ReviewType="character", AddingDate=DateTime.Now.AddDays(-10), MainPage=true, Confirmation=true, CategoryId=2 },
                new Review() { BookName="beyaz diş" , BookSubject="life of jules verne", BookWriter="mehmet", BookAnalysis="orta", OtherBooks="kasagı", ReviewType="general", AddingDate=DateTime.Now.AddDays(-10), MainPage=true, Confirmation=true, CategoryId=1 }
            };

            foreach (var item in reviews)
            {
                context.Reviews.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}