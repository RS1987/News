using System.ComponentModel.DataAnnotations;

namespace News.Models
{
	public class NewsVM
	{
		[ScaffoldColumn(false)]
		public int Id { get; set; }

		[Display(Name = "Название")]
		public string Title { get; set; }

		[Display(Name = "Текст статьи")]
		public string Article { get; set; }
	}
}