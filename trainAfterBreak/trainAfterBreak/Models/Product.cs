using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trainAfterBreak.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Barcode { get; set; }
        public DateTime DateCreated { get; set; }
        public Models.Manufacturer Manufacturer { get; set; }
    }
}