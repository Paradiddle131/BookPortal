using DataLibrary.DataAccess;
using DataLibrary.ModelsD;
using System.Collections.Generic;

namespace DataLibrary.BusinessLogic
{
	public static class ReviewProcessor
	{
		public static int CreateReview(string Category, string BookName, string ReviewType, string BookSubject, string BookAnalysis, string AuthorName, string OtherBooks)
		{
			ReviewModel data = new ReviewModel
			{
				Category = Category,
				BookName = BookName,
				ReviewType = ReviewType,
				BookSubject = BookSubject,
				BookAnalysis = BookAnalysis,
				AuthorName = AuthorName,
				OtherBooks = OtherBooks
			};
			string sql = @"INSERT INTO dbo.Review(Category, BookName, ReviewType, BookSubject, BookAnalysis, AuthorName, OtherBooks) 
				VALUES(@Category, @BookName, @ReviewType, @BookSubject, @BookAnalysis, @AuthorName, @OtherBooks);";
			return SqlDataAccess.SaveData(sql, data);
		}
		public static List<ReviewModel> LoadReviews()
		{ // Got inaccessibility error, solved by making ReviewModel.cs public.
			string sql = @"SELECT Category, BookName, ReviewType, BookSubject, BookAnalysis, AuthorName, OtherBooks FROM dbo.Review;";
			return SqlDataAccess.LoadData<ReviewModel>(sql);
		}
	}
}
