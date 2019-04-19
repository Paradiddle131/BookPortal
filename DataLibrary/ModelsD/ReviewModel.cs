using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.ModelsD
{
	public class ReviewModel
	{
		public string Category { get; set; }
		public string BookName { get; set; }
		public string ReviewType { get; set; }
		public string BookSubject { get; set; }
		public string BookAnalysis { get; set; }
		public string AuthorName { get; set; }
		public string OtherBooks { get; set; }
	}
}
