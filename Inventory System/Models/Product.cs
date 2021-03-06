﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace Inventory_System.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
        [Required]
        public string Bardcode { get; set; }
        public DateTime DateCreated { get; set; }
        public string Picture { get; set; }
        //[NotMapped]
        //public HttpPostedFileBase File { get; set; }
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

        public Product()
        {

        }
    }
}