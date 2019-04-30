using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookPortal.Models
{
	public class CategoriesDB
	{
		[Key]
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }

		//public List<Review> Reviews { get; set; }
		public List<ReviewsDB> Reviews { get; set; }
	}
}