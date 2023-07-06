using PlayOnProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlayOnProject.ViewModels
{
    public class InvioceModel
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string address { get; set; }
        public string ProductName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}