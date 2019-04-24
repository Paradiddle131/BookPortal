using DataLibrary.ModelsD;
using System.Collections.Generic;

namespace BookPortal.Models
{
	public class ReviewCategory
	{
		//public List<Review> Reviews { get; set; }
		public List<ReviewModel> Reviews { get; set; }
		public int NumberOfReview { get; set; }
		public List<Categories> Categories { get; set; }
	}
}