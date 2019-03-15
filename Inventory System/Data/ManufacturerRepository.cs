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
    }
}