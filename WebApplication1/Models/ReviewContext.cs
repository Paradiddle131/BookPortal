using DataLibrary.ModelsD;
using System.Data.Entity;

namespace BookPortal.Models
{
	public class ReviewContext : DbContext
	{

		public ReviewContext() : base("ReviewDb")
		{
			Database.SetInitializer(new ReviewInitializer());
		}

		//public DbSet<Review> Reviews{ get; set; }
		public DbSet<ReviewModel> Reviews { get; set; }
		public DbSet<Categories> Categories { get; set; }


	}
}