using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers 
{
    public class HomeController : Controller
    {
        public string Index()
        {
            //localhost/home
            return "home/index";
        }
    }
}