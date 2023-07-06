using Microsoft.Reporting.WebForms;
using PlayOnProject.Models;
using PlayOnProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayOnProject.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ProductDbEntities db = new ProductDbEntities();
        public ActionResult Index()
        {
            var data = db.SpSelectAllCustomers().ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            SqlParameter p1 = new SqlParameter("@n", customer.CustomerName);
            SqlParameter p2 = new SqlParameter("@e", customer.Email);
            SqlParameter p3 = new SqlParameter("@p", customer.PhoneNumber);
            SqlParameter p4 = new SqlParameter("@a", customer.address);
            db.Database.ExecuteSqlCommand("SpInsertCustomer @n, @e, @p, @a", p1, p2, p3, p4);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var data = db.Customers.FirstOrDefault(c=>c.CustomerId == id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            var data = db.Customers.FirstOrDefault(c => c.CustomerId == id);
            SqlParameter p0 = new SqlParameter("@i", data.CustomerId);
            SqlParameter p1 = new SqlParameter("@n", customer.CustomerName);
            SqlParameter p2 = new SqlParameter("@e", customer.Email);
            SqlParameter p3 = new SqlParameter("@p", customer.PhoneNumber);
            SqlParameter p4 = new SqlParameter("@a", customer.address);
            db.Database.ExecuteSqlCommand("SpEditCustomer @i, @n, @e, @p, @a",p0, p1, p2, p3, p4);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var data = db.Customers.FirstOrDefault(p => p.CustomerId == id);
            SqlParameter p1 = new SqlParameter("@i", data.CustomerId);
            db.Database.ExecuteSqlCommand("SpdeleteCustomer @i", p1);
            return Json(new { id = id });
        }
    }
}