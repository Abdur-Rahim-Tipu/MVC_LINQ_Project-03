using PlayOnProject.Models;
using PlayOnProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.EnterpriseServices.Internal;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace PlayOnProject.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ProductDbEntities db = new ProductDbEntities();
        public ActionResult Index()
        {
           var data = db.SpSelectAllProducts().ToList();
            return View(data);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductInsertModel product)
        {
            var p = new Product
            {
                ProductName = product.ProductName,
                Category = product.Category,
                Stock = product.Stock,
                Price = product.Price,
                ManufacturerDate = product.ManufacturerDate
            };

            if (product.Picture != null)
            {
                string ext = Path.GetExtension(product.Picture.FileName);
                string fileName = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + ext;
                string savePath = Path.Combine(Server.MapPath("~/Uploads"), fileName);
                product.Picture.SaveAs(savePath);
                p.Picture = fileName;
            }
            SqlParameter p1 = new SqlParameter("@n", p.ProductName);
            SqlParameter p2 = new SqlParameter("@c", p.Category);
            SqlParameter p3 = new SqlParameter("@p", p.Price);
            SqlParameter p4 = new SqlParameter("@s", p.Stock);
            SqlParameter p5 = new SqlParameter("@md", p.ManufacturerDate);
            SqlParameter p6 = new SqlParameter("@pic", p.Picture);
            try
            {
                db.Database.ExecuteSqlCommand("SpInsertProduct @n, @c, @p, @s, @md, @pic", p1, p2, p3, p4, p5,p6);
            }
            catch (Exception ex)
            {
                
            }
            return RedirectToAction("Index");
            
        }
        public ActionResult Edit(int id)
        {
            var data = db.Products.FirstOrDefault(p => p.ProductId == id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            var data = db.Products.FirstOrDefault(p => p.ProductId == id);
            SqlParameter p0 = new SqlParameter("@i", data.ProductId);
            SqlParameter p1 = new SqlParameter("@n", product.ProductName);
            SqlParameter p2 = new SqlParameter("@c", product.Category);
            SqlParameter p3 = new SqlParameter("@p", product.Price);
            SqlParameter p4 = new SqlParameter("@s", product.Stock);
            SqlParameter p5 = new SqlParameter("@md", product.ManufacturerDate);
            db.Database.ExecuteSqlCommand("SpEditProduct @i, @n,@c, @p, @s, @md", p0, p1, p2, p3, p4,p5);
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            var o = db.Orders.ToList();
            var pur = db.purchases.ToList();
            if (o == null && pur == null)
            {
                var data = db.Products.FirstOrDefault(p => p.ProductId == id);
                SqlParameter p1 = new SqlParameter("@i", data.ProductId);
                db.Database.ExecuteSqlCommand("SpdeleteProduct @i", p1);
                return Json(new { id = id });
            }
            return Json(new { id = id });
        }
    }
}