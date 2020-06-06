using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serwis.Models
{
    public class Company
    {
        public int CompanyID { set; get; }
        public string CompanyLogin { set; get; }
        public string CompanyPassword { set; get; }
        public string CompanyName { set; get; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyEmail { get; set; }

       // public virtual CustomerID CustomerID { set; get; }
    }
}
