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
                    State = result.ProductState,
                    Company = _product.GetCurrentComapny(result.ProductID),
                    Owner = _product.GetCurrentOwner(result.ProductID)
                });

            var model = new ProductIndexModel()
            {
                Products = listingResult
            };

            return View(model); 
        }
        public IActionResult Detail (int id)
        {
            var product = _product.GetByID(id);

            var model = new ProductDetail
            {
                ProdId = product.ProductID,
                Category = product.ProductCategory,
                Name = product.ProductName,
                Description = product.ProductDescription,
                State = product.ProductState,
                Warranty = product.ProductWarranty,
                Company = product.CompanyID.CompanyName,
                Owner = product.CustomerID.CustomerLogin,
                Complaints = _product.GetComplaintsCount(id),
                Picture = product.Image,
                LastCompalain = _product.LastComplain(id).ComplaintID
            };

            return View(model);
        }
    }
}
