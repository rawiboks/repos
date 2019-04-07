using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_System.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }


        public Transaction()
        {

        }

        public Transaction(int id, Product product, int quantity, DateTime transactionDate)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
            TransactionDate = transactionDate;
        }
    }
}