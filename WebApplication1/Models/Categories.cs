using DataLibrary.ModelsD;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookPortal.Models
{
	public class Categories
	{
		[Key]
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }

		//public List<Review> Reviews { get; set; }
		public List<ReviewModel> Reviews { get; set; }
	}
}