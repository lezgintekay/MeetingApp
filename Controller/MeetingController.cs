using Microsoft.AspNetCore.Mvc;


namespace MeetingApp.Controllers
{

    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Apply() {
            return View();
        }
         public IActionResult List() {
            return View();
        }

    }
}