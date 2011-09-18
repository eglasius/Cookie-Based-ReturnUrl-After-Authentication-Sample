using System.Web.Mvc;
using NavigationSample.Navigation;

namespace NavigationSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        [ReturnAfterAuthentication]
        public ActionResult About()
        {
            return View();
        }
    }
}
