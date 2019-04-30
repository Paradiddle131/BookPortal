using System.Collections.Generic;

namespace BookPortal.Models
{
    public class ReviewCategory
	{
		//public List<Review> Reviews { get; set; }
		public List<ReviewsDB> Reviews { get; set; }
		public int NumberOfReview { get; set; }
		public List<CategoriesDB> Categories { get; set; }
	}
}