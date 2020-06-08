using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Serwis.Models
{
    public class Company
    {
        [Required]
        [Key]
        public int CompanyID { set; get; }
        [Required]
        public string CompanyLogin { set; get; }
        [Required]
        public string CompanyPassword { set; get; }
        [Required]
        public string CompanyName { set; get; }
        [Required]
        public string CompanyAddress { get; set; }
        [Required]
        public string CompanyPhone { get; set; }
        [Required]
        public string CompanyEmail { get; set; }

        public virtual IEnumerable<Products> Products { set; get; }
        public virtual IEnumerable<Customer> Customers { set; get; }

    }
}
