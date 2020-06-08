using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Serwis.Models
{
    public class Customer
    {
        [Required]
        [Key]
        public int CustomerID { get; set; }
        [Required]
        public string CustomerLogin { get; set; }
        [Required]
        public string CustomerPassword { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerVorname { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }


        public virtual Company CompanyID { get; set; }

        public virtual IEnumerable<Products> Products { set; get; }
    }
}
