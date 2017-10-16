using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using News.Domain.Abstract;

namespace News.Domain.Common
{
	public class DbEntity : IDbEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
	}
}