using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using trainAfterBreak.Models;

namespace trainAfterBreak.Data
{
    public static class Data
    {
        public static List<Manufacturer> manufacturers = new List<Manufacturer>
        {
            new Manufacturer{Id=1, Name="Nestle", Address="California-US"},
            new Manufacturer{Id=2, Name="Mars", Address="California-US"},
            new Manufacturer{Id=3, Name="Algida", Address="California-US"}
        };

        public static List<Product> product = new List<Product>
            {
                new Product
                    {
                        Id =1,
                        Barcode ="0005",
                        Name ="Lipton 100bags",
                        DateCreated =DateTime.Parse("01/01/2011"),
                        Picture="~/Images/lipton 100bags.jpg",
                        Manufacturer=manufacturers[0]
                    },
                new Product
                    {
                        Id =2,
                        Barcode ="0006",
                        Name ="Chocapic",
                        DateCreated =DateTime.Parse("10/10/2012"),
                        Picture="~/Images/chocapic.jpg",
                        Manufacturer=manufacturers[1]
                    }
            };

        public static List<Transaction> transaction = new List<Transaction>
        {
            new Transaction
                { Id=1,
                product =product.Where(p=>p.Id==1).Single(),
                Quantity =100,
                TransactionDate =DateTime.Parse("01/01/2010") },
            new Transaction
                { Id=2,
                product =product.Where(p=>p.Id==1).Single(),
                Quantity =200,
                TransactionDate =DateTime.Parse("15/05/2010") },
            new Transaction
                { Id=3,
                product =product.Where(p=>p.Id==1).Single(),
                Quantity =-50,
                TransactionDate =DateTime.Parse("02/01/2010") },
            new Transaction
                { Id=4,
                product =product.Where(p=>p.Id==1).Single(),
                Quantity =-50,
                TransactionDate =DateTime.Parse("01/06/2010") },
            new Transaction
                { Id=5,
                product =product.Where(p=>p.Id==2).Single(),
                Quantity =100,
                TransactionDate =DateTime.Parse("01/01/2010") },
            new Transaction
                { Id=6,
                product =product.Where(p=>p.Id==2).Single(),
                Quantity =-50,
                TransactionDate =DateTime.Parse("01/01/2010") },

        };

        

    }
}