using System.Web.Mvc;
using News.AppContext;

namespace News.Controllers
{
    public class AddNewsController : Controller
    {
		AppDbContext db = new AppDbContext();

	    [HttpPost]
	    public ActionResult Create(Entities.News news)
	    {
		    db.News.Add(news);
		    db.SaveChanges();
		    return RedirectToRoute("Default");
	    }
	}
}