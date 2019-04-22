using DataLibrary.ModelsD;
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
				new Categories(){CategoryName="Fear"},
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
			List<ReviewModel> reviews = new List<ReviewModel>()
			{
				new ReviewModel() { BookName="Jules Verne" , BookSubject="life of jules verne", AuthorName="seyfettin", BookAnalysis="güzel", OtherBooks="kasagı", ReviewType="general"},
				new ReviewModel() { BookName="sol ayağım" , BookSubject="life of jules verne", AuthorName="raci", BookAnalysis="kötü", OtherBooks="kasagı", ReviewType="character"},
				new ReviewModel() { BookName="beyaz diş" , BookSubject="life of jules verne", AuthorName="mehmet", BookAnalysis="orta", OtherBooks="kasagı", ReviewType="general"}
			};

			foreach (ReviewModel item in reviews)
			{
				context.Reviews.Add(item);
			}

			context.SaveChanges();

			base.Seed(context);
		}
	}
}