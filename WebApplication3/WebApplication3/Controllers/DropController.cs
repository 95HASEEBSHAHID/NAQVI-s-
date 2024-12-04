using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class DropController : Controller
    {
        // GET: Drop
        public ActionResult Bikes()
        {
            ViewBag.Message = "Your application Bikes page.";

            return View();
        }

        public ActionResult Bikes_Delivery()
        {
            ViewBag.Message = "Your application Bikes_Deliver page.";

            return View();
        }

        public ActionResult Bikes_Purchase()
        {
            ViewBag.Message = "Your application Bikes_Purchase page.";

            return View();
        }

      
    }
}