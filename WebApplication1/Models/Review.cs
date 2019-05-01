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
    }
}