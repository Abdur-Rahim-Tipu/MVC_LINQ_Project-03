using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlayOnProject.Models
{
    [MetadataType(typeof(PurchaseMeta))]
    public partial class purchase
    {

    }
    public partial class PurchaseMeta
    {
        public int purchaseId { get; set; }
        [Required]
        public System.DateTime PurchaseDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}