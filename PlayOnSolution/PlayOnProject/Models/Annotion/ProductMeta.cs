﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlayOnProject.Models
{
    [MetadataType(typeof(ProductMeta))]
    public partial class Product
    {
    }
    public partial class ProductMeta
    {
        public int ProductId { get; set; }
        [Required, StringLength(50)]
        public string ProductName { get; set; }
        [Required, StringLength(50)]
        public string Category { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public DateTime ManufacturerDate { get; set; }
        [Required]
        public string Picture { get; set; }

    }
}