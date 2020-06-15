using Microsoft.AspNetCore.Mvc;
using Serwis.Services;
using System;
using System.Linq;

namespace Serwis.Models.Catalog
{
    public class ProductListingModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string  Description{ get; set; }
        public string State { get; set; }
        public DateTime Warranty { get; set; }
        public Company Company { get; set; }
        public Customer Owner { get; set; }
        public int ComplaintsCount { set; get; }
    }
}
