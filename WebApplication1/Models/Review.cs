//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.DataAnnotations;

namespace BookPortal.Models
{

	public partial class Review
	{
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

		//public bool CompareTo(int s1, int s2)
		//{
		//	if (s1 < s2) return true;
		//	return false;
		//}

		//public bool CompareTo(int s1, int s2)
		//{
		//	if (s1 < s2) return true;
		//	return ReviewId.CompareTo(s1, s2);
		//}
		/*
		int IComparable.CompareTo(object obj)
		{
			int counter = 0;
			if (Int32.Parse(s1.ToString()) < Int32.Parse(s2.ToString())) return 1;
			return 0;
			throw new NotImplementedException();
		}*/
	}
}