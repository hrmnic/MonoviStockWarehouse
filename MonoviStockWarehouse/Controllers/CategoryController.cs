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
        public ActionResult CategoryRemove(int id)
        {
            var ctg = c.Categories.Find(id);
            c.Categories.Remove(ctg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CategoryGet(int id)
        {
            var cat = c.Categories.Find(id);
            return View("CategoryGet",cat);
        }
        public ActionResult CategoryUpdate(Category k)
        {
            var ctgr = c.Categories.Find(k.CategoryID);
            ctgr.CategoryName = k.CategoryName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}