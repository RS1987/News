using System.Collections.Generic;
using System.Linq;

namespace News.Domain.Abstract
{

	public interface IDbRepository<T>
		where T : class, IDbEntity
	{
		bool AddItem(T item);
		bool AddItems(IEnumerable<T> items);
		IQueryable<T> AllItems { get; }
		bool EditItem(T item);
		bool DeleteItem(int id);
		T GetItem(int id);
		bool SaveChanges();
	}
}