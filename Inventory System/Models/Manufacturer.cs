using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_System.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string ManufacturerName { get; set; }
        public string Address { get; set; }

        public Manufacturer(int id, string name, string address)
        {
            Id = id;
            ManufacturerName = name;
            Address = address;
        }

        public Manufacturer()
        {

        }
    }
}