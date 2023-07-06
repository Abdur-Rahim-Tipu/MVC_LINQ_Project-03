using PlayOnProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayOnProject.Controllers
{
    public class SellsController : Controller
    {
        // GET: Sells
        public ProductDbEntities db = new ProductDbEntities();
        public ActionResult Index()
        {
            var data = db.SpSelectAllOrder().ToList();
            return View(data);
        }
        public ActionResult create()
        {
            ViewBag.Customers = db.Customers.ToList();
            ViewBag.Products = db.Products.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult create(Order sell)
        {
            SqlParameter p1 = new SqlParameter("@ci", sell.CustomerId);
            SqlParameter p2 = new SqlParameter("@pi", sell.ProductId);
            SqlParameter p3 = new SqlParameter("@p", sell.Price);
            SqlParameter p4 = new SqlParameter("@q", sell.Quantity);
            SqlParameter p5 = new SqlParameter("@od", sell.OrderDate);
            db.Database.ExecuteSqlCommand("SpInsertOrder @ci, @pi, @p, @q, @od", p1, p2, p3, p4, p5);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var data = db.Orders.FirstOrDefault(o => o.OrderId == id);
            ViewBag.Customers = db.Customers.ToList();
            ViewBag.Products = db.Products.ToList();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(int id, Order sell)
        {
            var data = db.Orders.FirstOrDefault(o => o.OrderId == id);
            SqlParameter p0 = new SqlParameter("@i", data.OrderId);
            SqlParameter p1 = new SqlParameter("@ci", sell.CustomerId);
            SqlParameter p2 = new SqlParameter("@pi", sell.ProductId);
            SqlParameter p3 = new SqlParameter("@p", sell.Price);
            SqlParameter p4 = new SqlParameter("@q", sell.Quantity);
            SqlParameter p5 = new SqlParameter("@od", sell.OrderDate);
            db.Database.ExecuteSqlCommand("SpEditOrder @i, @ci, @pi, @p, @q, @od",p0, p1, p2, p3, p4, p5);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var data = db.Orders.FirstOrDefault(p => p.OrderId == id);
            SqlParameter p1 = new SqlParameter("@i", data.OrderId);
            db.Database.ExecuteSqlCommand("SpDeleteOrder @i", p1);
            return Json(new { id = id });
        }
    }
}