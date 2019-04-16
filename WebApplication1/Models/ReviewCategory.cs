using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookPortal.Models
{
    public class ReviewCategory
    {
        public List<Review> Reviews { get; set; }
        public int NumberOfReview { get; set; }
        public List<Categories> Categories { get; set; }
    }
}