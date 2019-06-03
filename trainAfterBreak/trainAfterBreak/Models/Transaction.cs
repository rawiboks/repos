using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace trainAfterBreak.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Product product { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Quantity { get; set; }
    }
}