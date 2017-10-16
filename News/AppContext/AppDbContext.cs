using System.Data.Entity;

namespace News.AppContext
{
	public class AppDbContext : DbContext
	{
		public DbSet<Entities.News> News { get; set; }

		public AppDbContext(string connStrName)
			: base(connStrName)
		{
			Database.SetInitializer<AppDbContext>( new AppDbInitializer());
		}
	}
}