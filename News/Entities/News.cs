using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using News.Domain.Common;

namespace News.Entities
{
	[Table("News")]
	public class News : DbEntity
	{
		[StringLength(64)]
		public string Title { get; set; }

		[StringLength(64)]
		public string Article { get; set; }
	}
}