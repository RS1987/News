using System.Data.Entity;
using News.Domain.Common;

namespace News.Repositories
{
	public class NewsRepository : DbRepository<Entities.News>
	{
		public NewsRepository(DbContext context) : base(context)
		{
		}
	}
}