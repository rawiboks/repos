using Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_System.Data
{
    public class ManufacturerRepository
    {
        public List<Manufacturer> GetManufacturers()
        {
            var manufacturers = Data.Manufacturers;
            return manufacturers;
        }

        public void AddManufacturer(string name, string Address)
        {
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.Id = Data.Manufacturers.Max(m => m.Id)+1;
            manufacturer.Name = name;
            manufacturer.Address = Address;

            Data.Manufacturers.Add(manufacturer);
        }
    }
}