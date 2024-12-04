using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ItemsContext db;

        public HomeController(ItemsContext _db)
        {
            db  = _db;
        }

        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }

        public IActionResult Additems ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Additems(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditItems(int id)
        {
            var items = db.Items.FirstOrDefault(x => x.Id == id);
            return View();
        }

        [HttpPost]
        public IActionResult Edititems(Item item)
        {
            db.Items.Update(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Deleteitems(int id)
        {
            var item = db.Items.FirstOrDefault(x => x.Id == id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Deleteitemsreq(int id)
        {
            var item1 = db.Items.FirstOrDefault(x => x.Id == id);
            db.Items.Remove(item1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ItemsDetail(int id)
        {
            var item = db.Items.FirstOrDefault(x => x.Id == id);
            return View(item);
        }

        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
