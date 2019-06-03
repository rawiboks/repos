using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using trainAfterBreak.Models;

namespace trainAfterBreak.Data
{
    public class ManufacturerRepository
    {
        public List<Manufacturer> ReturnManufacturers()
        {
            return Data.manufacturers;
        }

        public void AddManufacturer(string name, string address)
        {
            int id = Data.manufacturers.Max(m=>m.Id)+1;
            Data.manufacturers.Add(new Manufacturer { Id = id, Name = name, Address = address });
        }
    }
}