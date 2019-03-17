using Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_System.Data
{
    public static class Data
    {
        public static List<Manufacturer> Manufacturers { get; set; }
        public static List<Product> Products { get; set; }

        static Data()
        {
            InitData();
        }

        private static void InitData()
        {

            var manufacturers = new List<Manufacturer>()
            {
                new Manufacturer(1, "Nestle", "LosAngeles, California"),
                new Manufacturer(2, "Mondalez", "London, UK"),
                new Manufacturer(3, "P&G", "Swindon, UK"),
                new Manufacturer(4, "Pepsi", "San Antonio, California"),
                new Manufacturer(5, "TEst Manu", "San Antonio, California")
            };

            var products = new List<Product>()
            {
                new Product(1, "Chocapic", manufacturers[0], "#0001", DateTime.Parse("20/01/2010"), "~/Images/chocapic2.jpg", false ),
                new Product(2, "Pepsi 2L Bottle", manufacturers[3], "#0002", DateTime.Parse("01/01/2012"), "~/Images/pepsi.jpg", false ),
                new Product(3, "Pepsi 0.33 Can", manufacturers[3], "#0003", DateTime.Parse("24/06/2009"), "~/Images/pepsi 0.3.jpg", false ),
                new Product(4, "Lipton Tea 100bags", manufacturers[2], "#0004", DateTime.Parse("20/01/2010"), "~/Images/lipton 100bags.jpg", false )
            };

            Manufacturers = manufacturers;
            Products = products;
        }
    }
}