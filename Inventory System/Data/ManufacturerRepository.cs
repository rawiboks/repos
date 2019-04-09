using Inventory_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_System.Data
{
    public class ManufacturerRepository
    {
        Context context = new Context();

        public List<Manufacturer> GetManufacturers()
        {
            //var manufacturers = Data.Manufacturers;
            //return manufacturers;

            //Context context = new Context();
            return context.Manufacturer.ToList();
        }

        public void AddManufacturer(Manufacturer manufacturer)
        {
            manufacturer.Id = context.Manufacturer.Max(m => m.Id)+1;
            context.Manufacturer.Add(manufacturer);
            context.SaveChanges();
            //Data.Manufacturers.Add(manufacturer);
        }
    }
}