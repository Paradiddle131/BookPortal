using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace BookPortal.Models
{
    public class ReviewInitializer : DropCreateDatabaseIfModelChanges<ReviewContext>
    {
        protected override void Seed(ReviewContext context)
        {
            List<Categories> categories = new List<Categories>()
                {
                    new Categories(){CategoryName="Horror"},
                    new Categories(){CategoryName="Adventure"}
                };

            foreach (Categories item in categories)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();
            // BookPortal.Reviev
            //List<Review> reviews = new List<Review>()
            //{
            //    new Review() { BookName="Jules Verne" , BookSubject="life of jules verne", BookWriter="seyfettin", BookAnalysis="güzel", OtherBooks="kasagı", ReviewType="general", AddingDate=DateTime.Now.AddDays(-10), MainPage=true, Confirmation=true, CategoryId=1 },
            //    new Review() { BookName="sol ayağım" , BookSubject="life of jules verne", BookWriter="raci", BookAnalysis="kötü", OtherBooks="kasagı", ReviewType="character", AddingDate=DateTime.Now.AddDays(-10), MainPage=true, Confirmation=true, CategoryId=2 },
            //    new Review() { BookName="beyaz diş" , BookSubject="life of jules verne", BookWriter="mehmet", BookAnalysis="orta", OtherBooks="kasagı", ReviewType="general", AddingDate=DateTime.Now.AddDays(-10), MainPage=true, Confirmation=true, CategoryId=1 }
            //};

            //DataLibrary.RevivewModel
            List<Review> reviews = new List<Review>()
                {
                    new Review() { BookName="Jules Verne" , BookSubject="life of jules verne", AuthorName="seyfettin", BookAnalysis="güzel", OtherBooks="kasagı", ReviewType="general", DateAdded=Convert.ToDateTime("2019-01-01")},
                    new Review() { BookName="sol ayağım" , BookSubject="life of jules verne", AuthorName="raci", BookAnalysis="kötü", OtherBooks="kasagı", ReviewType="character", DateAdded=Convert.ToDateTime("2019-01-02")},
                    new Review() { BookName="beyaz diş" , BookSubject="life of jules verne", AuthorName="mehmet", BookAnalysis="orta", OtherBooks="kasagı", ReviewType="general", DateAdded=Convert.ToDateTime("2019-01-03")}
                };

            foreach (Review item in reviews)
            {
                context.Reviews.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
