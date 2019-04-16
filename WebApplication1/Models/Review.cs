using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookPortal.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string BookName { get; set; }
        public string BookSubject { get; set; }
        public string BookAnalysis { get; set; }
        public string BookWriter { get; set; }
        public string OtherBooks { get; set; }
        public bool Confirmation { get; set; }
        public bool MainPage { get; set; }
        public string ReviewType { get; set; }
        public DateTime AddingDate { get; set; }


        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
            


    }
}