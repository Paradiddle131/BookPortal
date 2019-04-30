using System.Data.Entity;
using DbContext = System.Data.Entity.DbContext;

namespace BookPortal.Models
{
	public class ReviewContext : DbContext
	{

		//public ReviewContext() : base("RevDBEntities")
		public ReviewContext() : base("RevDBEntities")
		{
			Database.SetInitializer(new ReviewInitializer());
		}
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Categories> Categories { get; set; }


	}
}