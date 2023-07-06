using PlayOnProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayOnProject.Controllers
{
    public class PurchasesController : Controller
    {
        public ProductDbEntities db = new ProductDbEntities();
        public ActionResult Index()
        {
            var data = db.SpSelectAllpurchases().ToList();
            return View(data);
        }
        public ActionResult create()
        {
            ViewBag.Products = db.Products.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult create(purchase p)
        {
            SqlParameter p1 = new SqlParameter("@pd", p.PurchaseDate);
            SqlParameter p2 = new SqlParameter("@q", p.Quantity);
            SqlParameter p3 = new SqlParameter("@p", p.Price);
            SqlParameter p4 = new SqlParameter("@pi", p.ProductId);
            db.Database.ExecuteSqlCommand("SpInsertpurchase @pd, @q, @p, @pi", p1, p2, p3, p4);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var data = db.purchases.FirstOrDefault(o => o.purchaseId == id);
            ViewBag.Products = db.Products.ToList();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(int id, purchase p)
        {
            var data = db.purchases.FirstOrDefault(o => o.purchaseId == id);
            SqlParameter p0 = new SqlParameter("@i", data.purchaseId);
            SqlParameter p1 = new SqlParameter("@pd", p.PurchaseDate);
            SqlParameter p2 = new SqlParameter("@q", p.Quantity);
            SqlParameter p3 = new SqlParameter("@p", p.Price);
            SqlParameter p4 = new SqlParameter("@pi", p.ProductId);
            db.Database.ExecuteSqlCommand("SpEditpurchase @i, @pd, @q, @p, @pi",p0, p1, p2, p3, p4);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var data = db.purchases.FirstOrDefault(p => p.purchaseId == id);
            SqlParameter p1 = new SqlParameter("@i", data.purchaseId);
            db.Database.ExecuteSqlCommand("SpDeletepurchase @i", p1);
            return Json(new { id = id });
        }
    }
}