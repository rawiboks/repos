using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using trainAfterBreak.Models;
using trainAfterBreak.Data;

namespace trainAfterBreak.Data
{
    public class ProductRepository
    {
        public List<Product> ReturnProducts()
        {
            return Data.product;
        }

        public Product ReturnProduct(int id)
        {
            return Data.product.Where(p => p.Id == id).SingleOrDefault();
        }

        public void AddProduct(Models.Product product, int ManufacturerId)
        {
            int id = Data.product.Max(p => p.Id) + 1;
            Data.product.Add(new Product
            {
                Id = id,
                DateCreated = DateTime.Now,
                Barcode = product.Barcode,
                Name = product.Name,
                Picture = "~/Images/" + product.Name + ".jpg",
                //Picture = "~/Images/lipton 100bags.jpg",
                Manufacturer = Data.manufacturers.Where(m => m.Id == ManufacturerId).Single()
            });
        }
    }
}