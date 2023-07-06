using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlayOnProject.Models
{
    [MetadataType(typeof(CustomerMeta))]
    public partial class Customer
    {

    }
    public partial class CustomerMeta
    {
        public int CustomerId { get; set; }
        [Required, StringLength(50)]
        public string CustomerName { get; set; }
        [Required, StringLength(50), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, StringLength(11)]
        public string PhoneNumber { get; set; }
        [Required, StringLength(250)]
        public string address { get; set; }
    }
}