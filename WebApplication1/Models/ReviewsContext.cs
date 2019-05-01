using System.Data.Entity;
using DbContext = System.Data.Entity.DbContext;

namespace BookPortal.Models
{
    public class ReviewsContext : DbContext
    {

        public ReviewsContext()
        {
            Database.SetInitializer(new ReviewsInitializer());
        }
        public DbSet<ReviewsDB> Reviews { get; set; }
        public DbSet<CategoriesDB> Categories { get; set; }


    }
}