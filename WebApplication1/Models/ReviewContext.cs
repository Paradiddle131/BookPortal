using System.Data.Entity;
using DbContext = System.Data.Entity.DbContext;

namespace BookPortal.Models
{
	public class ReviewContext : DbContext
	{

		//public ReviewContext() : base("RevDBEntities")
		public ReviewContext() 
		{
			Database.SetInitializer(new ReviewInitializer());
		}
		public DbSet<ReviewsDB> Reviews { get; set; }
		public DbSet<CategoriesDB> Categories { get; set; }


	}
}