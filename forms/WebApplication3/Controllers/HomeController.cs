﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(string email, string pswd)
        {
            if (email == "admin@gmail.com" && pswd == "aptech123")
            {
                return Content("Thankyou Login Successfully");

                TempData["userData"] = "user Email is: " + email;
                TempData.Keep();
                return RedirectToAction("privacy");

            }
            return View();
        }

        public IActionResult Privacy()
        {
            TempData.Keep();
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        [HttpGet]
        public IActionResult my()
        {


            return View();
        }
        [HttpPost]
        public IActionResult my(IFormCollection frm)
        {
            string name = frm["email"];
            string pass = frm["pswd"];
            ViewBag.a = name;

            return View();
        }

    }
}
