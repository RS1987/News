using System.Web.Mvc;
using News.Models;

namespace News.Controllers
{
    public class EditNewsController : Controller
    {


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

	    [HttpPut]
	    public ActionResult Edit(NewsVM news)
	    {
		    return View();
	    }
    }
}