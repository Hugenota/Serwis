using Microsoft.AspNetCore.Mvc;
using Serwis.Models.Catalog;
using Serwis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serwis.Controllers
{
    public class CatalogController : Controller
    {
        private IProduct _product;
        public CatalogController(IProduct product)
        {
            _product = product;
        }
        public IActionResult Index()        //map every element of  collection in product models
        {
            var productModel = _product.GetAll();

            var listingResult = productModel
                .Select(result => new ProductListingModel
                {
                    Id = result.ProductID,
                    Category = result.ProductCategory,
                    Name = result.ProductName,
                    Description = result.ProductDescription,
                    State = result.ProductState,
                    Warranty = result.ProductWarranty,
                    Company = _product.GetCurrentComapny(result.ProductID),
                    Owner = _product.GetCurrentOwner(result.ProductID),
                    ComplaintsCount = _product.GetComplaintsCount(result.ProductID)
                });

            var model = new ProductIndexModel()
            {
                Products = listingResult
            };

            return View(); 
        }
    }
}
