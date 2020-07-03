using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Serwis.Models
{
    public class Products
    {

        [Key]
        public int ProductID { set; get; }

        public string ProductCategory { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        [Required]
        public string ProductState { get; set; }
        public DateTime ProductWarranty { get; set; }
        public string Image { get; set; }


        public virtual Company CompanyID { get; set; }

        public virtual Customer CustomerID { get; set; }

        public virtual IEnumerable<Complaints> Complaints { set; get; }
    }
}
