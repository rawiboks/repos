using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_System.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Bardcode { get; set; }
        public DateTime DateCreated { get; set; }
        public string Picture { get; set; }
        public bool Locked { get; set; }

        public Product(int id, string name, Manufacturer manufacturer, 
            string barcode, DateTime dateCreated, string picture, bool locked)
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Bardcode = barcode;
            DateCreated = dateCreated;
            Picture = picture;
            Locked = locked;
        }
    }
}