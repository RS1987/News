using News.AppContext;
using News.Repositories;

namespace News.Domain
{
	public static class Unit
	{
		static AppDbContext _context;
		public static NewsRepository NewsRepository { get; private set; }

		static Unit()
		{
			_context = new AppDbContext();

			NewsRepository = new NewsRepository(_context);
		}
	}
}