using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using News.Domain;
using News.Models;

namespace News.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public ActionResult Index()
		{
			List<NewsVM> news = Unit.NewsRepository.AllItems.Select(
				x => new NewsVM()
				{
					Id = x.Id,
					Title = x.Title,
					Article = x.Article
				}
			).ToList();

			return View("Index", news);

		}
	}
}