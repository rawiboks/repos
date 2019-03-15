using Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_System.Data
{
    public class ProductsRepository
    {
        public List<Product> GetProducts()
        {
            return Data.Products;
        }

        public Product GetProduct(int Id)
        {
            return Data.Products.Where(p => p.Id == Id).SingleOrDefault();
        }
    }
}