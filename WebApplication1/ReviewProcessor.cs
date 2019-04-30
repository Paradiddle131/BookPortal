using BookPortal.Models;
using System.Collections.Generic;

namespace BookPortal
{
	public static class ReviewProcessor
	{
		public static int CreateReview(int reviewId, string category, string bookName, string reviewType, string bookSubject, string bookAnalysis, string authorName, string otherBooks)
		{
			Review data = new Review
			{
				ReviewId = reviewId,
				Category = category,
				BookName = bookName,
				BookSubject = reviewType,
				BookAnalysis = bookAnalysis,
				AuthorName = authorName,
				OtherBooks = otherBooks
			};
			string sql = @"INSERT INTO dbo.Employee(EmployeeId, FirstName, LastName, EmailAddress) VALUES(@EmployeeId, @FirstName, @LastName, @EmailAddress);";
			return SqlDataAccess.SaveData(sql, data);
		}
		public static List<Review> LoadReviews()
		{
			string sql = @"SELECT Id, EmployeeId, FirstName, LastName, EmailAddress FROM dbo.Employee;";
			return SqlDataAccess.LoadData<Review>(sql);
		}
	}
}