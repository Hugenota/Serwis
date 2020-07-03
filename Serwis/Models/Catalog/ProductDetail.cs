using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serwis.Models.Catalog
{
    public class ProductDetail
    {
        public int ProdId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public DateTime Warranty { get; set; }
        public string Company { get; set; }
        public string Owner { get; set; }
        public int Complaints { set; get; }
        public string Picture { set; get; }
        public int LastCompalain { get; set; }

    }
}
