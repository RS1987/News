using System.ComponentModel.DataAnnotations;

namespace News.Domain.Abstract
{
	public interface IDbEntity
	{
		[Key]
		int Id { get; set; }
	}
}