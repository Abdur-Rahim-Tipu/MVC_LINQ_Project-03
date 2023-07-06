using Microsoft.Ajax.Utilities;
using PlayOnProject.Models;
using PlayOnProject.Reports;
using PlayOnProject.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayOnProject.Controllers
{
    public class ReportsController : Controller
    {
        public ProductDbEntities db = new ProductDbEntities();
        // GET: Reports
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveInvoice(int id)
        {
            var Customers = db.Customers
               .Where(c => c.CustomerId == id);
            if (Customers.Count() == 0)
            {
                return new HttpNotFoundResult();
            }
            else
            {
                List<InvioceModel> list = new List<InvioceModel>();
                foreach (var c in Customers)
                {
                    var inv = new InvioceModel
                    {
                        CustomerId = c.CustomerId,
                        CustomerName = c.CustomerName,
                        PhoneNumber = c.PhoneNumber,
                        Email = c.Email,
                        address = c.address
                    };
                    foreach (var oi in c.Orders)
                    {
                        inv.Quantity = oi.Quantity;
                        inv.ProductName = oi.Product.ProductName;
                        inv.OrderId = oi.OrderId;
                        inv.OrderDate = oi.OrderDate;
                        inv.Price = oi.Product.Price;
                        inv.TotalPrice = (oi.Product.Price) * (inv.Quantity);
                            list.Add(inv);


                    }

                }

                CrystalReport1 rpt = new CrystalReport1();
                rpt.SetDataSource(list);
                Response.Buffer = false;
                Response.ClearContent();
                Response.ClearHeaders();


                Stream stream = rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                stream.Seek(0, SeekOrigin.Begin);
                return File(stream, "application/pdf", "CustomerList.pdf");
            }
        }
    }
}