using Serwis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serwis.Services
{
    public interface IProduct
    {
        Complaints LastComplain(int id);

        IEnumerable<Products> GetAll();
        Products GetByID(int id);
        void Add(Products newproduct);
        string GetProductCategory(int id);
        string GetProductName(int id);
        string GetProductDescription(int id);
        string GetProductState(int id);
        DateTime GetProductWarranty(int id);
        int GetComplaintsCount(int id);

        Company GetCurrentComapny(int id);
        Customer GetCurrentOwner(int id);

    }
}
