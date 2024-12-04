using Microsoft.AspNetCore.Mvc;

namespace my_project.Controllers
{
    public class My : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string firstName, string lastName)
        {
            ViewBag.Name = string.Format("Name: {0} {1}", firstName, lastName);
            return View();
        }
    }
}