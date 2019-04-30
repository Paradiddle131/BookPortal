using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookPortal.Models
{
	public class ReviewDTO
	{
		public ReviewDTO()
		{
			reviews = new HashSet<Review>();
		}
		[Key]
		public int ReviewId { get; set; }
		public string Category { get; set; }
		public string BookName { get; set; }
		public string ReviewType { get; set; }
		public string BookSubject { get; set; }
		public string BookAnalysis { get; set; }
		public string AuthorName { get; set; }
		public string OtherBooks { get; set; }

		[DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
		[Display(Name = "Date")]
		[DataType(DataType.Date)]
		public DateTime DateAdded { get; set; }
		public ICollection<Review> reviews { get; set; }
	}
}