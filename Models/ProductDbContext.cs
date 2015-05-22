namespace weshiop.net.Models.
{

	public class WeshopDbContext:DbContext 
	{

		public DbSet<Product> Products { get; set; }

	}
}