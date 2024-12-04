using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            TempData["designation"] = "Software Developer";
            TempData.Keep();

            ViewBag.name = "HASEEB SHAHID";

            ViewData["GreetMessg"] = "WELCOME TO OUR COMPANY....!";
            return View();
        }

        public IActionResult Index2()
        {
            TempData.Keep();
            return View();
        }


    }



}
