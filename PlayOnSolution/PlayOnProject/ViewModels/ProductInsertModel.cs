using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlayOnProject.ViewModels
{
    public class ProductInsertModel
    {
        public int ProductId { get; set; }
        [Required, StringLength(50)]
        public string ProductName { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public DateTime ManufacturerDate { get; set; }
        [Required]
        public HttpPostedFileBase Picture { get; set; }
    }
}