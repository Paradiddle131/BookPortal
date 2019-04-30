namespace BookPortal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string Category { get; set; }
        public string BookName { get; set; }
        public string Picture { get; set; }
        public string Content { get; set; }
        public string ReviewType { get; set; }
        public string BookSubject { get; set; }
        public string BookAnalysis { get; set; }
        public string AuthorName { get; set; }
        public DateTime UploadDate { get; set; }
        public bool Confirmation { get; set; }
        public string OtherBooks { get; set; }
        public bool MainPage { get; set; }

        public int CategoryId { get; set; }
        public CategoriesDB Categories { get; set; }
    }


    
}

