using System.Web.Mvc;

namespace News.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View("ShowNews");
        }
    }
}