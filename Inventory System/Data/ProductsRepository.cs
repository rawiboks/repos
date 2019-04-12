using Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_System.Data
{
    public class ProductsRepository
    {
        Context context = new Context();

        public List<Product> GetProducts()
        {
            Context context = new Context();
            return context.Product.ToList();
            //return Data.Products;
        }

        public Product GetProduct(int Id)
        {
            return context.Product.Where(m => m.Id == Id).SingleOrDefault();
            //return Data.Products.Where(p => p.Id == Id).SingleOrDefault();
        }

        public List<Product> searchProduct(string search)
        {
            return context.Product.Where(p => p.Name.Contains(search)).ToList();
        }

        public void AddProduct(Product product)
        {
            //var context = new Context();
            int count = context.Product.Max(i => i.Id) +1;
            product.Id = count;
            product.Manufacturer = Data.Manufacturers.Where(m => m.Id == product.ManufacturerId).SingleOrDefault();
            product.DateCreated = DateTime.Now;

           //Context context = new Context();
            context.Product.Add(product);
            context.SaveChanges();
            //Data.Products.Add(product);

        }
    }
}