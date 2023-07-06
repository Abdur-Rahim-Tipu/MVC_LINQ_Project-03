using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlayOnProject.Models
{
    [MetadataType(typeof(OrderMeta))]
    public partial class Order
    {

    }
    public partial class OrderMeta
    {
        public int OrderId { get; set; }
        [Required] 
        public int CustomerId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required, DataType(DataType.Date)]
        public System.DateTime OrderDate { get; set; }
    }
}