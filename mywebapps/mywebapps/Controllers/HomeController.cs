using Microsoft.AspNetCore.Mvc;
using mywebapps.Models;
using System.Diagnostics;

namespace mywebapps.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }


    }
}