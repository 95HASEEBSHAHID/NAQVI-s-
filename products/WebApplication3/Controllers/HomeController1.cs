using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Airbuds()
        {
            TempData["product"] = "Apple";
            TempData.Keep();


            ViewBag.name = "Airpods pro";
            ViewData["Price"] = "1500";


            return View();
        }


        public IActionResult LapTop()
        {
            TempData["product"] = "Apple";
            TempData.Keep();


            ViewBag.name = "LapTop";
            ViewData["Price"] = "2000";


            return View();
        }

        public IActionResult Mobile()
        {
            TempData["product"] = "Apple";
            TempData.Keep();


            ViewBag.name = "Mobile";
            ViewData["Price"] = "2500";


            return View();
        }




    }
}
