using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookPortal.Models
{
    public class ReviewContext:DbContext
    {

        public ReviewContext() : base("reviewDb")
        {
            Database.SetInitializer(new ReviewInitializer());
        }

        public DbSet<Review> Reviews{ get; set; }
        public DbSet<Categories> Categories { get; set; }

       
    }
}