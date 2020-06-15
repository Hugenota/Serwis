using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serwis.Models;

namespace Serwis.Services
{
    public class ProductsService : IProduct
    {
        private SerwisContext _context;

        public ProductsService(SerwisContext context)    // mamy teraz pełny dostęp do bazy danych w całym serwisie
        {
            _context = context;                      
        }

        public void Add(Products newproduct)
        {
            _context.Add(newproduct);
            _context.SaveChanges();
        }

        public IEnumerable<Products> GetAll()
        {
            return _context.Products
                .Include(Products => Products.ProductCategory)
                .Include(Products => Products.ProductName)
                .Include(Products => Products.ProductWarranty);
        }

        public Products GetByID(int id)
        {
            return _context.Products
                .Include(Products => Products.ProductCategory)
                .Include(Products => Products.ProductName)
                .Include(Products => Products.ProductDescription)
                .Include(Products => Products.ProductWarranty)
                .Include(Products => Products.ProductState)
                .Include(Products => Products.CustomerID)
                .Include(Products => Products.CustomerID)
                .Include(Products => Products.Complaints)
                .FirstOrDefault(Products => Products.ProductID == id);
        }

        public Company GetCurrentComapny(int id)
        {
            return GetByID(id).CompanyID;
        }

        public Customer GetCurrentOwner(int id)
        {
            return GetByID(id).CustomerID;
        }

        public string GetProductCategory(int id)
        {
            return _context.Products.FirstOrDefault(a => a.ProductID == id).ProductCategory;
        }

        public string GetProductDescription(int id)
        {
            return _context.Products.FirstOrDefault(a => a.ProductID == id).ProductDescription;
        }

        public string GetProductName(int id)
        {
            return _context.Products.FirstOrDefault(a => a.ProductID == id).ProductName;
        }

        public string GetProductState(int id)
        {
            return _context.Products.FirstOrDefault(a => a.ProductID == id).ProductState;
        }

        public DateTime GetProductWarranty(int id)
        {
            return _context.Products.FirstOrDefault(a => a.ProductID == id).ProductWarranty;
        }

        public int GetComplaintsCount(int id)
        {
            return _context.Products.Sum(s => s.Complaints.Count());
        }
    }
}
