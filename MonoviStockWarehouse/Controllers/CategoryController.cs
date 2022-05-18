using MonoviStockWarehouse.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonoviStockWarehouse.Controllers
{
    public class CategoryController : Controller
    {
        Context c = new Context();

        public ActionResult Index()
        {
            var values = c.Categories.ToList();
            
            return View(values);
        }
        [HttpGet]
        public ActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryAdd(Category cat)
        {
            c.Categories.Add(cat);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}